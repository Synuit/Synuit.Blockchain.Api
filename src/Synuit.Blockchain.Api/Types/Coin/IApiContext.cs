//
//  Synuit.Blockchain.Api - Blockchain/Cryptocurrency Api's for .NET
//  Copyright © 2017-2018 Synuit Software. All Rights Reserved.
//
using System;
using System.Collections.Generic;
//
using Synuit.Blockchain.Api.Coin.Models;
//
namespace Synuit.Blockchain.Api.Types.Coin
{
   public interface IApiContext
   {
      /// <summary>
      /// API method: GetCoinInformation - returns result set of all coin records with fields including:
      /// numeric coin id, symbol, name, algorithm, proof type, total coin supply, and price (note: whenever
      /// any of these fields are unavailable for a certain coin, they are returned as 0 or blank, depending
      /// on data type)
      /// </summary>
      /// <param name="userAgent"></param>
      /// <returns>result set of coin records of type IEnumerable; null if cannot be obtained</returns>
      IEnumerable<CoinInformation> GetCoinInformation(string userAgent = "");

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
      IEnumerable<CoinInformation> GetCoinInformationWithSnapshot(string targetCoinSymbolListCommaSep, string userAgent = "");

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
      IEnumerable<CoinInformation> GetCoinInformationWithSnapshot(List<string> targetCoinSymbolList, string userAgent = "");

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
      double GetClosingPriceForDate(string coinNameSymbol, DateTime targetDate, string userAgent = "");

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
      double GetClosingPriceForDate(string coinNameSymbol, Int32 targetUnixDate, string userAgent = "");

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
      double GetOpeningPriceForDate(string coinNameSymbol, DateTime targetDate, string userAgent = "");

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
      double GetOpeningPriceForDate(string coinNameSymbol, Int32 targetUnixDate, string userAgent = "");

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
      double GetHighPriceForDate(string coinNameSymbol, DateTime targetDate, string userAgent = "");

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
      double GetHighPriceForDate(string coinNameSymbol, Int32 targetUnixDate, string userAgent = "");

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
      double GetLowPriceForDate(string coinNameSymbol, DateTime targetDate, string userAgent = "");

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
      double GetLowPriceForDate(string coinNameSymbol, Int32 targetUnixDate, string userAgent = "");

      /// <summary>
      /// API method: GetApiUrl - returns URL string for a given CryptoCompare.com API call
      /// 2 overloads: 1) No parameters - defaults to coinlist call URL; 2) Parameter is an API method name
      /// for which to return the URL
      /// This header is for overload #1
      /// </summary>
      /// <returns>URL string for coinlist API call from CryptoCompare.com API</returns>
      string GetApiUrl();

      /// <summary>
      /// API method: GetApiUrl - returns URL string for a given CryptoCompare.com API call
      /// 2 overloads: 1) No parameters - defaults to coinlist call URL; 2) Parameter is an API method name
      /// for which to return the URL
      /// This header is for overload #2
      /// </summary>
      /// <param name="apiMethodName"></param>
      /// <returns>URL string for requested API call from CryptoCompare.com API</returns>
      string GetApiUrl(string apiMethodName);

      /// <summary>
      /// API method: GetInfoUrl - returns URL string for CryptoCompare.com's documentation website
      /// </summary>
      /// <returns>URL string for CryptoCompare.com's documentation website</returns>
      string GetInfoUrl();

      /// <summary>
      /// API method: GetApiName - returns hard-coded string with CryptoCompare.com's API name
      /// </summary>
      /// <returns>CryptoCompare.com API name as string</returns>
      string GetApiName();
   }
}