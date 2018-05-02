//
//  Synuit.Blockchain.Api - Blockchain/Cryptocurrency Api's for .NET
//  Copyright © 2017-2018 Synuit Software. All Rights Reserved.
//
using Synuit.Blockchain.Api.Coin;
using Synuit.Blockchain.Api.CryptoCompare.Extensions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Synuit.Blockchain.Api.Types.Coin;
using Synuit.Blockchain.Api.CryptoCompare.Models;
using Synuit.Blockchain.Api.Coin.Models;
using Synuit.Toolkit.Utilities.Net;

namespace Synuit.Blockchain.Api.CryptoCompare
{
    public class ApiContext : IApiContext
    {
        private List<CoinInformation> _coinInfoResultSet = new List<CoinInformation>();

        /// <summary>
        /// Purpose of MAX_PARAM_COUNT
        /// Call to GetCoinInformation returns a result set with blank Price for each coin.
        /// GetCoinPriceMulti must be called for each coin in GetCoinInformation result set to retrieve the Price.
        /// GetCoinPriceMulti takes a list of coin symbols as parameters.  However, if all coins in
        /// GetCoinInformation result set are passed into GetCoinPriceMulti in a single call, GetCoinPriceMulti
        /// results in unacceptably slow performance.  Calling GetCoinPriceMulti separately for each coin is also
        /// too inefficient.  To optimize, the call to GetCoinPriceMulti is broken up into groups of
        /// MAX_PARAM_COUNT coins per call.
        /// </summary>
        public const int MAX_PARAM_COUNT = 60;

        /// <summary>
        /// API method: GetClosingPriceForDate - returns closing price for a given coin on a given date
        /// Note: all coin price values are based on 00:00 GMT time, per CryptoCompare.com API documentation
        /// 2 overloads: 1) Second parameter is a DateTime object; 2) Second parameter is a Unix date
        /// Parameters below are for overload #1
        /// </summary>
        /// <param name="coinNameSymbol"></param>
        /// <param name="targetDate"></param>
        /// <param name="userAgent"></param>
        /// <returns>closing price as a value of type double; 0 if price cannot be obtained</returns>
        public double GetClosingPriceForDate(string coinNameSymbol, DateTime targetDate, string userAgent = "")
        {
            // Convert targetDate of type DateTime to a Unix date
            Int32 targetUnixDate = (Int32)(targetDate.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            // Call second overload of this method
            return GetClosingPriceForDate(coinNameSymbol, targetUnixDate, userAgent);
        }

        /// <summary>
        /// API method: GetClosingPriceForDate - returns closing price for a given coin on a given date
        /// Note: all coin price values are based on 00:00 GMT time, per CryptoCompare.com API documentation
        /// 2 overloads: 1) Second parameter is a DateTime object; 2) Second parameter is a Unix date
        /// Parameters below are for overload #2
        /// </summary>
        /// <param name="coinNameSymbol"></param>
        /// <param name="targetUnixDate"></param>
        /// <param name="userAgent"></param>
        /// <returns>closing price as a value of type double; 0 if price cannot be obtained</returns>
        public double GetClosingPriceForDate(string coinNameSymbol, Int32 targetUnixDate, string userAgent = "")
        {
            return GetPriceForDate(coinNameSymbol, targetUnixDate, "close", userAgent);
        }

        /// <summary>
        /// API method: GetOpeningPriceForDate - returns opening price for a given coin on a given date
        /// Note: all coin price values are based on 00:00 GMT time, per CryptoCompare.com API documentation
        /// 2 overloads: 1) Second parameter is a DateTime object; 2) Second parameter is a Unix date
        /// Parameters below are for overload #1
        /// </summary>
        /// <param name="coinNameSymbol"></param>
        /// <param name="targetDate"></param>
        /// <param name="userAgent"></param>
        /// <returns>opening price as a value of type double; 0 if price cannot be obtained</returns>
        public double GetOpeningPriceForDate(string coinNameSymbol, DateTime targetDate, string userAgent = "")
        {
            // Convert targetDate of type DateTime to a Unix date
            Int32 targetUnixDate = (Int32)(targetDate.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            // Call second overload of this method
            return GetOpeningPriceForDate(coinNameSymbol, targetUnixDate, userAgent);
        }

        /// <summary>
        /// API method: GetOpeningPriceForDate - returns opening price for a given coin on a given date
        /// Note: all coin price values are based on 00:00 GMT time, per CryptoCompare.com API documentation
        /// 2 overloads: 1) Second parameter is a DateTime object; 2) Second parameter is a Unix date
        /// Parameters below are for overload #2
        /// </summary>
        /// <param name="coinNameSymbol"></param>
        /// <param name="targetUnixDate"></param>
        /// <param name="userAgent"></param>
        /// <returns>opening price as a value of type double; 0 if price cannot be obtained</returns>
        public double GetOpeningPriceForDate(string coinNameSymbol, Int32 targetUnixDate, string userAgent = "")
        {
            return GetPriceForDate(coinNameSymbol, targetUnixDate, "open", userAgent);
        }

        /// <summary>
        /// API method: GetHighPriceForDate - returns high price for a given coin on a given date
        /// Note: all coin price values are based on 00:00 GMT time, per CryptoCompare.com API documentation
        /// 2 overloads: 1) Second parameter is a DateTime object; 2) Second parameter is a Unix date
        /// Parameters below are for overload #1
        /// </summary>
        /// <param name="coinNameSymbol"></param>
        /// <param name="targetDate"></param>
        /// <param name="userAgent"></param>
        /// <returns>high price as a value of type double; 0 if price cannot be obtained</returns>
        public double GetHighPriceForDate(string coinNameSymbol, DateTime targetDate, string userAgent = "")
        {
            // Convert targetDate of type DateTime to a Unix date
            Int32 targetUnixDate = (Int32)(targetDate.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            // Call second overload of this method
            return GetHighPriceForDate(coinNameSymbol, targetUnixDate, userAgent);
        }

        /// <summary>
        /// API method: GetHighPriceForDate - returns high price for a given coin on a given date
        /// Note: all coin price values are based on 00:00 GMT time, per CryptoCompare.com API documentation
        /// 2 overloads: 1) Second parameter is a DateTime object; 2) Second parameter is a Unix date
        /// Parameters below are for overload #2
        /// </summary>
        /// <param name="coinNameSymbol"></param>
        /// <param name="targetUnixDate"></param>
        /// <param name="userAgent"></param>
        /// <returns>high price as a value of type double; 0 if price cannot be obtained</returns>
        public double GetHighPriceForDate(string coinNameSymbol, Int32 targetUnixDate,
                                                string userAgent = "")
        {
            return GetPriceForDate(coinNameSymbol, targetUnixDate, "high", userAgent);
        }

        /// <summary>
        /// API method: GetLowPriceForDate - returns low price for a given coin on a given date
        /// Note: all coin price values are based on 00:00 GMT time, per CryptoCompare.com API documentation
        /// 2 overloads: 1) Second parameter is a DateTime object; 2) Second parameter is a Unix date
        /// Parameters below are for overload #1
        /// </summary>
        /// <param name="coinNameSymbol"></param>
        /// <param name="targetDate"></param>
        /// <param name="userAgent"></param>
        /// <returns>low price as a value of type double; 0 if price cannot be obtained</returns>
        public double GetLowPriceForDate(string coinNameSymbol, DateTime targetDate,
                                                string userAgent = "")
        {
            // Convert targetDate of type DateTime to a Unix date
            Int32 targetUnixDate =
                    (Int32)(targetDate.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            // Call second overload of this method
            return GetLowPriceForDate(coinNameSymbol, targetUnixDate, userAgent);
        }

        /// <summary>
        /// API method: GetLowPriceForDate - returns low price for a given coin on a given date
        /// Note: all coin price values are based on 00:00 GMT time, per CryptoCompare.com API documentation
        /// 2 overloads: 1) Second parameter is a DateTime object; 2) Second parameter is a Unix date
        /// Parameters below are for overload #2
        /// </summary>
        /// <param name="coinNameSymbol"></param>
        /// <param name="targetUnixDate"></param>
        /// <param name="userAgent"></param>
        /// <returns>low price as a value of type double; 0 if price cannot be obtained</returns>
        public double GetLowPriceForDate(string coinNameSymbol, Int32 targetUnixDate,
                                                string userAgent = "")
        {
            return GetPriceForDate(coinNameSymbol, targetUnixDate, "low", userAgent);
        }

        /// <summary>
        /// Utility method: GetPriceForDate - returns price of a given type for a given coin on a given date
        /// priceType valid arguments are: "close", "open", "high", "low"
        /// Note: all coin price values are based on 00:00 GMT time, per CryptoCompare.com API documentation
        /// The API will convert all Unix dates passed in as something other than Midnight in GMT time zone of a
        /// given date to the Unix date value of Midnight in GMT
        /// </summary>
        /// <param name="coinNameSymbol"></param>
        /// <param name="targetUnixDate"></param>
        /// <param name="priceType"></param>
        /// <param name="userAgent"></param>
        /// <returns>price as a value of type double; 0 if price cannot be obtained</returns>
        private double GetPriceForDate(string coinNameSymbol, Int32 targetUnixDate,
                                         string priceType, string userAgent = "")
        {
            if (!(priceType.Equals("close") || priceType.Equals("open") ||
                                    priceType.Equals("high") || priceType.Equals("low")))
                return 0;
            if (coinNameSymbol.Equals(""))
                return 0;
            // Calculate current system date in Unix Date format to ensure target date is in the past
            DateTime currentDate = DateTime.Now.Date;
            Int32 currentUnixDate =
                        (Int32)(currentDate.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            if (targetUnixDate > currentUnixDate)
                return 0;

            ApiWebClient client = new ApiWebClient();
            if (!string.IsNullOrEmpty(userAgent))
                client.Headers.Add("user-agent", userAgent);

            // Build CryptoCompare.com API's HistoDay call URL with params, first using BuildApiUrlWithBasicParams
            // to build the URL of the common format: "https://[method_url]?fsym=[input_coin]&tsym=USD"
            // and then append additional URL parameters to it, needed specifically for the HistoDay call
            string apiUrl = BuildApiUrlWithBasicParams(coinNameSymbol, "HistoDay", false, false);
            apiUrl += "&limit=1&toTs=";
            apiUrl += targetUnixDate.ToString();

            // Invoke CryptoCompare.com API's HistoDay call URL, then deserialize result
            string json = client.DownloadAsString(apiUrl);

            int count = 0;
            double histPrice = 0;
            RootObjectHistoDay histodaylist = JsonConvert.DeserializeObject<RootObjectHistoDay>(json);

            // Obtain correct price element from deserialized result set
            // Skip 1st record because this API call returns 2 records - 1 for previous date, 1 for target date
            foreach (HistoDayInfo histoDay in histodaylist.Data)
            {
                if (count == 1)
                {
                    switch (priceType)
                    {
                        case "close":
                            histPrice = histoDay.close;
                            break;
                        case "open":
                            histPrice = histoDay.open;
                            break;
                        case "high":
                            histPrice = histoDay.high;
                            break;
                        case "low":
                            histPrice = histoDay.low;
                            break;
                    }
                }
                count += 1;
            }
            return histPrice;
        }

        /// <summary>
        /// API method: GetCoinInformation - returns result set of all coin records with fields including:
        /// numeric coin id, symbol, name, algorithm, proof type, total coin supply, and price (note: whenever
        /// any of these fields are unavailable for a certain coin, they are returned as 0 or blank, depending
        /// on data type)
        /// </summary>
        /// <param name="userAgent"></param>
        /// <returns>result set of coin records of type IEnumerable; null if cannot be obtained</returns>
        public IEnumerable<CoinInformation> GetCoinInformation(string userAgent = "")
        {
            ApiWebClient client = new ApiWebClient();
            if (!string.IsNullOrEmpty(userAgent))
                client.Headers.Add("user-agent", userAgent);

            // Clear out member variable that will store the result set from any previous call to this API
            if (_coinInfoResultSet.Count > 0)
                _coinInfoResultSet.RemoveRange(0, _coinInfoResultSet.Count - 1);

            // Call special no-parameter overload of GetApiUrl method to build CryptoCompare.com API's
            // coinlist call URL
            string apiUrl = GetApiUrl();

            // Invoke CryptoCompare.com API's coinlist call URL, then deserialize result
            string json = client.DownloadAsString(apiUrl);
            var coinlist = JsonConvert.DeserializeObject<RootObjectCoinList>(json);

            int count = 0;
            int index = 0;
            List<string> apiUrlInputParamsArray = new List<string>();
            apiUrlInputParamsArray.Add("");

            // Process each coin in result set to obtain elements such as symbol, name, total coin supply, etc.
            // Additionally, build parameter array of coin names for the separate pricemulti API call.
            // The parameter array is actually a list of arrays, to set up for multiple calls to pricemulti
            // and avoid a single performance-hindering call with hundreds of coin parameters.
            // Please refer to MAX_PARAM_COUNT documentation above.
            foreach (CoinInfo coin in coinlist.Data.Values)
            {
                count += 1;
                CoinInformation coinInformation = new CoinInformation();
                coinInformation.PopulateFromJson(coin);
                apiUrlInputParamsArray[index] += coinInformation.Symbol;
                apiUrlInputParamsArray[index] += ",";
                _coinInfoResultSet.Add(coinInformation);
                if (count == MAX_PARAM_COUNT)
                {
                    index += 1;
                    apiUrlInputParamsArray.Add("");
                    count = 0;
                }
            }

            // Obtain coin price for each coin in the result set by making CryptoCompare.com API's pricemulti 
            // calls for each array of coins in the input parameter list of arrays
            // Note: method GetCoinPriceMulti calculates the Market Cap in addition to obtaining the price;
            // however, since CryptoCompare.com API's coinlist call does not return Total Coins Mined, this
            // calculation of Market Cap will always come out to 0 here; therefore, Market Cap can only be 
            // provided by GetCoinPriceMulti calls from GetCoinInformationWithSnapshot API method
            for (int ind = 0; ind < apiUrlInputParamsArray.Count; ind++)
            {
                GetCoinPriceMulti(client, apiUrlInputParamsArray[ind]);
            }

            List<CoinInformation> result = new List<CoinInformation>();
            result = _coinInfoResultSet;
            return result;
        }

        /// <summary>
        /// API method: GetCoinInformationWithSnapshot - returns result set of complete coin records with all
        /// fields returned by GetCoinInformation plus additional fields, i.e. current blocks, block reward,
        /// total coins mined, reward reduction, estimated block time, hash rate per second, and market cap (note:
        /// whenever any of these fields are unavailable for a certain coin, they are returned as 0 or blank,
        /// depending on data type).  This method is only available with a comma-separated list of coins passed
        /// in as a parameter (e.g. "BTC,ETH,UIS"), because CryptoCompare's CoinSnapshotFullById call that
        /// provides this info requires a coin ID parameter, and calling it for the full result set of all coins
        /// in GetCoinInformation result set one by one would result in unacceptably slow performance.
        /// 2 overloads: 1) First parameter is a comma-separated string; 2) First parameter is a List of strings
        /// Parameters below are for overload #1
        /// </summary>
        /// <param name="targetCoinSymbolListCommaSep"></param>
        /// <param name="userAgent"></param>
        /// <returns>result set of coin records of type IEnumerable; null if cannot be obtained</returns>
        public IEnumerable<CoinInformation> GetCoinInformationWithSnapshot(string targetCoinSymbolListCommaSep,
                                        string userAgent = "")
        {
            IEnumerable<CoinInformation> result = new List<CoinInformation>();

            // Convert comma-separated string of coin symbols of type string to a List of strings
            string[] targetCoinSymbolArray = targetCoinSymbolListCommaSep.Split(',');
            List<string> targetCoinSymbolList = new List<string>();
            for (int ind = 0; ind < targetCoinSymbolArray.Length; ind++)
            {
                targetCoinSymbolList.Add(targetCoinSymbolArray[ind]);
            }

            // Call second overload of this method
            result = GetCoinInformationWithSnapshot(targetCoinSymbolList, userAgent);

            return result;
        }

        /// <summary>
        /// API method: GetCoinInformationWithSnapshot - returns result set of complete coin records with all
        /// fields returned by GetCoinInformation plus additional fields, i.e. current blocks, block reward,
        /// total coins mined, reward reduction, estimated block time, hash rate per second, and market cap (note:
        /// whenever any of these fields are unavailable for a certain coin, they are returned as 0 or blank,
        /// depending on data type).  This method is only available with a comma-separated list of coins passed
        /// in as a parameter (e.g. "BTC,ETH,UIS"), because CryptoCompare's CoinSnapshotFullById call that
        /// provides this info requires a coin ID parameter, and calling it for the full result set of all coins
        /// in GetCoinInformation result set one by one would result in unacceptably slow performance.
        /// 2 overloads: 1) First parameter is a comma-separated string; 2) First parameter is a List of strings
        /// Parameters below are for overload #2
        /// </summary>
        /// <param name="targetCoinSymbolList"></param>
        /// <param name="userAgent"></param>
        /// <returns>result set of coin records of type IEnumerable; null if cannot be obtained</returns>
        public IEnumerable<CoinInformation> GetCoinInformationWithSnapshot(List<string> targetCoinSymbolList,
                                        string userAgent = "")
        {
            List<CoinInformation> result = new List<CoinInformation>();

            // Clear out member variable that will store the result set from any previous call to this API
            if (_coinInfoResultSet.Count > 0)
                _coinInfoResultSet.RemoveRange(0, _coinInfoResultSet.Count - 1);

            ApiWebClient client = new ApiWebClient();
            if (!string.IsNullOrEmpty(userAgent))
                client.Headers.Add("user-agent", userAgent);

            // Call special no-parameter overload of GetApiUrl method to build CryptoCompare.com API's
            // coinlist call URL
            string apiUrl = GetApiUrl();

            // Invoke CryptoCompare.com API's coinlist call URL, then deserialize result
            string json = client.DownloadAsString(apiUrl);
            var coinlist = JsonConvert.DeserializeObject<RootObjectCoinList>(json);

            string apiUrlInputParams = "";

            // Process each coin in result set to obtain both the elements provided by coinlist API call and
            // the additional elements provided by the CoinSnapshotFullById API call.
            // Additionally, build parameter string of coin names for the separate pricemulti API call.
            foreach (CoinInfo coin in coinlist.Data.Values)
            {
                CoinInformation coinInformation = new CoinInformation();

                // Obtain basic elements provided by coinlist API call, i.e. numeric coin id, symbol, name,
                // total coin supply, etc. for the coin being processed by the current iteration of the for loop
                coinInformation.PopulateFromJson(coin);

                // Select the coin being processed by current iteration of the for loop for further processsing
                // only if this coin is in the targetCoinSymbolList
                if (targetCoinSymbolList.Exists(x => x.Equals(coinInformation.Symbol)))
                {
                    // Invoke GetCoinSnapshotByID to obtain the additional elements provided by the
                    // CoinSnapshotFullById API call (i.e. current blocks, block reward, total coins mined, etc.)
                    GetCoinSnapshotByID(client, coinInformation);

                    // Add current coin's symbol to the parameter string for the pricemulti API call.
                    apiUrlInputParams += coinInformation.Symbol;
                    apiUrlInputParams += ",";
                    _coinInfoResultSet.Add(coinInformation);
                }
            }

            // Obtain coin price and market cap for each coin in the result set by making a pricemulti API call 
            // for the list of coins in the comma-separated input parameter
            GetCoinPriceMulti(client, apiUrlInputParams);

            result = _coinInfoResultSet;
            return result;
        }

        /// <summary>
        /// Utility method: BuildApiUrlWithBasicParams - builds an API call URL string of the most common format
        /// used by the CryptoCompare.com API: "https://[method_url]?fsym(s)=[input_coin(s)]&tsym(s)=USD"
        /// Boolean parameter multipleFrom passed from the calling method determines fsym vs. fsyms on the URL
        /// string
        ///     a. If an API call allows multiple "from symbols," then the URL parameter name is fsyms not fsym
        ///     b. One coin symbol is still accepted as the URL argument; multiple symbols must be comma-separated
        /// Boolean parameter multipleTo passed from the calling method determines tsym vs. tsyms, same as above
        /// </summary>
        /// <param name="apiUrlInputParams"></param>
        /// <param name="apiMethodName"></param>
        /// <param name="multipleFrom"></param>
        /// <param name="multipleTo"></param>
        /// <returns>API call URL string with parameters</returns>
        private string BuildApiUrlWithBasicParams (string apiUrlInputParams,
                                string apiMethodName, bool multipleFrom, bool multipleTo)
        {
            string apiUrl = "";

            // Get the part of the URL string that is just the method call URL, without the URL parameters
            apiUrl = GetApiUrl(apiMethodName);

            // The first parameter for this common CryptoCompare.com API URL format is the fsym parameter,
            // or fsyms if the given method allows multiple "from symbols"
            apiUrl += "?fsym";
            if (multipleFrom)
                apiUrl += "s";
            apiUrl += "=";

            // Append the argument(s) for fsym(s) URL parameter, which is a string of either a single coin symbol
            // or a comma-separated list of coin symbols; if the list was built with a comma after the last
            // symbol, it must be stripped off
            apiUrl += apiUrlInputParams;
            int lastCommaIndex = apiUrlInputParams.LastIndexOf(',') + 1;
            if (lastCommaIndex == apiUrlInputParams.Length)
                apiUrl = apiUrl.Remove(apiUrl.Length - 1, 1);

            // The second parameter for this common CryptoCompare.com API URL format is the tsym parameter,
            // or tsyms if the given method allows multiple "to symbols"
            apiUrl += "&tsym";
            if (multipleTo)
                apiUrl += "s";

            // For the purposes of this API, the "to symbol" will always be the US Dollar
            apiUrl += "=USD";

            return apiUrl;
        }

        /// <summary>
        /// Utility method: BuildApiUrlByID - builds a CryptoCompare.com API call URL string of the less common 
        /// format that takes the numeric ID of a coin as a parameter: "https://[method_url]?id=[input_coin_id]"
        /// </summary>
        /// <param name="apiUrlInputParam"></param>
        /// <param name="apiMethodName"></param>
        /// <returns>API call URL string with parameter</returns>
        private string BuildApiUrlByID(string apiUrlInputParam, string apiMethodName)
        {
            string apiUrl = "";

            // Get the part of the URL string that is just the method call URL, without the URL parameter
            apiUrl = GetApiUrl(apiMethodName);

            // Append URL parameter name and input argument string
            apiUrl += "?id=";
            apiUrl += apiUrlInputParam;

            return apiUrl;
        }

        /// <summary>
        /// Utility method: GetCoinPriceMulti - populates Price and Market Cap fields for result set of coin
        /// records; the coin symbols in the result set are passed in as parameters
        /// Note: if GetCoinPriceMulti method is being invoked from GetCoinInformation API method, Market Cap
        /// will always be 0 - see comment in GetCoinInformation method; only when GetCoinPriceMulti method is
        /// invoked from GetCoinInformationWithSnapshot, can the Market Cap be calculated
        /// </summary>
        /// <param name="client"></param>
        /// <param name="apiUrlInputParams"></param>
        /// <returns>void</returns>
        private void GetCoinPriceMulti(ApiWebClient client, string apiUrlInputParams)
        {
            // Build URL string for the Pricemulti CryptoCompare.com API call
            string apiUrl = BuildApiUrlWithBasicParams(apiUrlInputParams, "Pricemulti", true, true);

            // Invoke CryptoCompare.com API's pricemulti call URL, then deserialize result
            // JSON string will be in the following format: {"ETH":{"USD":226.63},"DASH":{"USD":187.87}}
            string json = client.DownloadAsString(apiUrl);

            // Reformat returned JSON string into format that can be deserialized into RootObjectPriceMulti object
            // Also make a copy of the returned JSON string, strip off leading "{" &  final "}", and split it into
            // an array of Price results per coin
            string remainingJson = json.Remove(0, 1);
            remainingJson = remainingJson.Remove(remainingJson.Length-1, 1);
            json = "{\"Data\":" + json;
            json += "}";
            var coinpricelist = JsonConvert.DeserializeObject<RootObjectPriceMulti>(json);
            string[] splitJson = remainingJson.Split(',');

            int splitIndex = 0;

            // Loop through the Price results array, incrementing splitIndex as the loop iteration counter
            foreach (CoinPrice coinPrice in coinpricelist.Data.Values)
            {
                CoinInformation coinInformation = new CoinInformation();

                // For each array element (i.e. each coin's Price result), the coin symbol is the portion before
                // the first ":", minus the leading & final "\" that appear in the string as escape characters
                string fromCoin = splitJson[splitIndex].Split(':')[0];
                fromCoin = fromCoin.Trim('\"');

                // Select the coin being processed by current iteration of the for loop in the original coin
                // information result set and populate the Price and Market Cap fields in this coin's record
                coinInformation = _coinInfoResultSet.Find(x => x.Symbol.Equals(fromCoin));
                coinInformation.PopulateFromJson(coinPrice);

                splitIndex += 1;
            }
        }

        /// <summary>
        /// Utility method: GetCoinSnapshotByID - Invoke CryptoCompare.com API's CoinSnapshotFullById call to
        /// obtain the additional elements (i.e. current blocks, block reward, total coins mined, etc.) that
        /// are not provided by CryptoCompare.com API's coinlist call, given the numeric id of a coin
        /// </summary>
        /// <param name="client"></param>
        /// <param name="coinInformation"></param>
        /// <returns>void</returns>
        private void GetCoinSnapshotByID(ApiWebClient client, CoinInformation coinInformation)
        {
            string coinSnapshotIDParam = "";

            // Obtain numeric id of the coin whose full record is passed in as coinInformation parameter
            coinSnapshotIDParam = coinInformation.Id;

            // Build URL string for the CoinSnapshotFullById CryptoCompare.com API call
            string apiUrl = BuildApiUrlByID(coinSnapshotIDParam, "CoinSnapshotByID");

            // Invoke CryptoCompare.com API's CoinSnapshotFullById call URL, then deserialize result and populate
            // the additional fields provided by this API call into the coinInformation coin record
            string json = client.DownloadAsString(apiUrl);
            try
            {
                RootObjectCoinSnapshot coinsnapshotset = JsonConvert.DeserializeObject<RootObjectCoinSnapshot>(json);
                GeneralCoinSnapshotData coinSnapshot = new GeneralCoinSnapshotData();
                coinSnapshot = coinsnapshotset.Data.General;
                coinInformation.PopulateFromJson(coinSnapshot);
            }
            catch (Exception e)
            {
                string errorMsg = e.Message;
            }
        }

        /// <summary>
        /// API method: GetApiUrl - returns URL string for a given CryptoCompare.com API call
        /// 2 overloads: 1) No parameters - defaults to coinlist call URL; 2) Parameter is an API method name
        /// for which to return the URL
        /// This header is for overload #1
        /// </summary>
        /// <returns>URL string for coinlist API call from CryptoCompare.com API</returns>
        public string GetApiUrl()
        {
            string apiUrl = "https://www.cryptocompare.com/api/data/coinlist/";
            return apiUrl;
        }

        /// <summary>
        /// API method: GetApiUrl - returns URL string for a given CryptoCompare.com API call
        /// 2 overloads: 1) No parameters - defaults to coinlist call URL; 2) Parameter is an API method name
        /// for which to return the URL
        /// This header is for overload #2
        /// </summary>
        /// <param name="apiMethodName"></param>
        /// <returns>URL string for requested API call from CryptoCompare.com API</returns>
        public string GetApiUrl(string apiMethodName)
        {
            string apiUrl = "";
            // The URLs are hardcoded per documentation on CryptoCompare.com website
            switch (apiMethodName)
            {
                case "Price":
                    apiUrl = "https://min-api.cryptocompare.com/data/price";
                    break;
                case "Pricemulti":
                    apiUrl = "https://min-api.cryptocompare.com/data/pricemulti";
                    break;
                case "CoinList":
                    apiUrl = "https://www.cryptocompare.com/api/data/coinlist/";
                    break;
                case "HistoDay":
                    apiUrl = "https://min-api.cryptocompare.com/data/histoday";
                    break;
                case "CoinSnapshotByID":
                    apiUrl = "https://www.cryptocompare.com/api/data/coinsnapshotfullbyid/";
                    break;
                // If API method name is not recognized, defaulting to the same URL as the no-parameter overload
                default:
                    apiUrl = "https://www.cryptocompare.com/api/data/coinlist/";
                    break;
            }
            return apiUrl;
        }

        /// <summary>
        /// API method: GetInfoUrl - returns URL string for CryptoCompare.com's documentation website
        /// </summary>
        /// <returns>URL string for CryptoCompare.com's documentation website</returns>
        public string GetInfoUrl()
        {
            return "https://www.cryptocompare.com/";
        }

        /// <summary>
        /// API method: GetApiName - returns hard-coded string with CryptoCompare.com's API name
        /// </summary>
        /// <returns>CryptoCompare.com API name as string</returns>
        public string GetApiName()
        {
            return "CryptoCompare.com";
        }
    }
}
