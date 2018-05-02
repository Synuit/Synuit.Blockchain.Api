using Synuit.Blockchain.Api.CryptoCompare;
using System;
using System.Collections.Generic;
using Xunit;

namespace Synuit.Blockchain.Api.Tests
{
   public class CryptoCompareApiTestFixture
   {
    
      //  GetCoinInformation Tests

      //  Test that GetCoinInformation call returns a result set
      [Fact]
      public void CreateGetCoinInformationInstTest()
      {
         Assert.True(new ApiContext().GetCoinInformation() != null);
      }

      //  Test that GetCoinInformation call returns a result set of a plausible size
      [Fact]
      public void CreateGetCoinInformationCountTest()
      {
         IEnumerable<Api.Coin.Models.CoinInformation> _coins;
         ICollection<Api.Coin.Models.CoinInformation> _coinsColl;
         _coins = new ApiContext().GetCoinInformation();
         _coinsColl = (ICollection<Api.Coin.Models.CoinInformation>)_coins;
         Assert.True(_coinsColl.Count > 100);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  GetCoinInformationWithSnapshot Tests

      //  Test that GetCoinInformationWithSnapshot w/ 5 coin types in single string param returns a result set
      [Fact]
      public void CreateGetCoinInformationWithSnapshotInstStrTest()
      {
         String targetCoinSysmbolList = "BTC,UIS,NXS,ETH,LTC";
         Assert.True(new ApiContext().GetCoinInformationWithSnapshot(targetCoinSysmbolList) != null);
      }

      //  Test that GetCoinInformationWithSnapshot w/ 5 coin types in List of strings as param returns a result set
      [Fact]
      public void CreateGetCoinInformationWithSnapshotInstListTest()
      {
         List<string> targetCoinSysmbolList = new List<string>(new string[] { "BTC", "UIS", "NXS", "ETH", "LTC" });
         Assert.True(new ApiContext().GetCoinInformationWithSnapshot(targetCoinSysmbolList) != null);
      }

      //  Test that GetCoinInformationWithSnapshot w/ 5 coin types in single string param returns 5 records
      [Fact]
      public void CreateGetCoinInformationWithSnapshotStrTest()
      {
         IEnumerable<Api.Coin.Models.CoinInformation> _coins;
         ICollection<Api.Coin.Models.CoinInformation> _coinsColl;
         String targetCoinSysmbolList = "BTC,UIS,NXS,ETH,LTC";
         _coins = new ApiContext().GetCoinInformationWithSnapshot(targetCoinSysmbolList);
         _coinsColl = (ICollection<Api.Coin.Models.CoinInformation>)_coins;
         Assert.True(_coinsColl.Count == 5);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetCoinInformationWithSnapshot w/ 5 coin types in List of strings as param returns 5 records
      [Fact]
      public void CreateGetCoinInformationWithSnapshotListTest()
      {
         IEnumerable<Api.Coin.Models.CoinInformation> _coins;
         ICollection<Api.Coin.Models.CoinInformation> _coinsColl;
         List<string> targetCoinSysmbolList = new List<string>(new string[] { "BTC", "UIS", "NXS", "ETH", "LTC" });
         _coins = new ApiContext().GetCoinInformationWithSnapshot(targetCoinSysmbolList);
         _coinsColl = (ICollection<Api.Coin.Models.CoinInformation>)_coins;
         Assert.True(_coinsColl.Count == 5);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  GetClosingPriceForDate Tests

      //  Test that GetClosingPriceForDate with Bitcoin and DateTime object as params returns valid value
      [Fact]
      public void CreateGetClosingPriceForDateBtcDTTest()
      {
         String coinNameSymbol = "BTC";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double closingPrice = new ApiContext().GetClosingPriceForDate(coinNameSymbol, targetDate);
         Assert.True(closingPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetClosingPriceForDate with Unitus and DateTime object as params returns valid value
      [Fact]
      public void CreateGetClosingPriceForDateUisDTTest()
      {
         String coinNameSymbol = "UIS";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double closingPrice = new ApiContext().GetClosingPriceForDate(coinNameSymbol, targetDate);
         Assert.True(closingPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetClosingPriceForDate with non-existent coin and DateTime object as params returns 0
      [Fact]
      public void CreateGetClosingPriceForDateBlahDTTest()
      {
         String coinNameSymbol = "BLAH";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double closingPrice = new ApiContext().GetClosingPriceForDate(coinNameSymbol, targetDate);
         Assert.True(closingPrice == 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetClosingPriceForDate with Bitcoin and Unix Date as params returns valid value
      [Fact]
      public void CreateGetClosingPriceForDateBtcUnixDtTest()
      {
         String coinNameSymbol = "BTC";
         Int32 targetUnixDate = 1508040539;
         double closingPrice = new ApiContext().GetClosingPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(closingPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetClosingPriceForDate with Unitus and Unix Date object as params returns valid value
      [Fact]
      public void CreateGetClosingPriceForDateUisUnixDtTest()
      {
         String coinNameSymbol = "UIS";
         Int32 targetUnixDate = 1508040539;
         double closingPrice = new ApiContext().GetClosingPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(closingPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetClosingPriceForDate with non-existent coin and Unix Date object as params returns 0
      [Fact]
      public void CreateGetClosingPriceForDateBlahUnixDtTest()
      {
         String coinNameSymbol = "BLAH";
         Int32 targetUnixDate = 1508040539;
         double closingPrice = new ApiContext().GetClosingPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(closingPrice == 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetClosingPriceForDate for Etherium with DateTime object as param returns same value
      //  as GetClosingPriceForDate for Etherium with equivalent Unix Date as param
      [Fact]
      public void CreateGetClosingPriceForDateBtcCompareTest()
      {
         String coinNameSymbol = "ETH";
         DateTime targetDate = new DateTime(2017, 9, 15);
         Int32 targetUnixDate = 1505433600;
         double closingPriceDT = new ApiContext().GetClosingPriceForDate(coinNameSymbol, targetDate);
         double closingPriceUnixDt = new ApiContext().GetClosingPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(closingPriceDT == closingPriceUnixDt);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetClosingPriceForDate for Nexus with DateTime object as param returns same value
      //  as GetClosingPriceForDate for Nexus with equivalent Unix Date as param
      [Fact]
      public void CreateGetClosingPriceForDateUisCompareTest()
      {
         String coinNameSymbol = "NXS";
         DateTime targetDate = new DateTime(2017, 10, 15);
         Int32 targetUnixDate = 1508025600;
         double closingPriceDT = new ApiContext().GetClosingPriceForDate(coinNameSymbol, targetDate);
         double closingPriceUnixDt = new ApiContext().GetClosingPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(closingPriceDT == closingPriceUnixDt);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  GetOpeningPriceForDate Tests

      //  Test that GeOpeningPriceForDate with Bitcoin and DateTime object as params returns valid value
      [Fact]
      public void CreateGetOpeningPriceForDateBtcDTTest()
      {
         String coinNameSymbol = "BTC";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double openingPrice = new ApiContext().GetOpeningPriceForDate(coinNameSymbol, targetDate);
         Assert.True(openingPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetOpeningPriceForDate with Unitus and DateTime object as params returns valid value
      [Fact]
      public void CreateGetOpeningPriceForDateUisDTTest()
      {
         String coinNameSymbol = "UIS";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double openingPrice = new ApiContext().GetOpeningPriceForDate(coinNameSymbol, targetDate);
         Assert.True(openingPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetOpeningPriceForDate with non-existent coin and DateTime object as params returns 0
      [Fact]
      public void CreateGetOpeningPriceForDateBlahDTTest()
      {
         String coinNameSymbol = "BLAH";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double openingPrice = new ApiContext().GetOpeningPriceForDate(coinNameSymbol, targetDate);
         Assert.True(openingPrice == 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GeOpeningPriceForDate with Bitcoin and Unix Date object as params returns valid value
      [Fact]
      public void CreateGetOpeningPriceForDateBtcUnixDtTest()
      {
         String coinNameSymbol = "BTC";
         Int32 targetUnixDate = 1508040539;
         double openingPrice = new ApiContext().GetOpeningPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(openingPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetOpeningPriceForDate with Unitus and Unix Date object as params returns valid value
      [Fact]
      public void CreateGetOpeningPriceForDateUisUnixDtTest()
      {
         String coinNameSymbol = "UIS";
         Int32 targetUnixDate = 1508040539;
         double openingPrice = new ApiContext().GetOpeningPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(openingPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetOpeningPriceForDate with non-existent coin and Unix Date object as params returns 0
      [Fact]
      public void CreateGetOpeningPriceForDateBlahUnixDtTest()
      {
         String coinNameSymbol = "BLAH";
         Int32 targetUnixDate = 1508040539;
         double openingPrice = new ApiContext().GetOpeningPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(openingPrice == 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetOpeningPriceForDate for Etherium with DateTime object as param returns same value
      //  as GetOpeningPriceForDate for Etherium with equivalent Unix Date as param
      [Fact]
      public void CreateGetOpeningPriceForDateBtcCompareTest()
      {
         String coinNameSymbol = "ETH";
         DateTime targetDate = new DateTime(2017, 9, 15);
         Int32 targetUnixDate = 1505433600;
         double openingPriceDT = new ApiContext().GetOpeningPriceForDate(coinNameSymbol, targetDate);
         double openingPriceUnixDt = new ApiContext().GetOpeningPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(openingPriceDT == openingPriceUnixDt);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetOpeningPriceForDate for Nexus with DateTime object as param returns same value
      //  as GetOpeningPriceForDate for Nexus with equivalent Unix Date as param
      [Fact]
      public void CreateGetOpeningPriceForDateUisCompareTest()
      {
         String coinNameSymbol = "NXS";
         DateTime targetDate = new DateTime(2017, 10, 15);
         Int32 targetUnixDate = 1508025600;
         double openingPriceDT = new ApiContext().GetOpeningPriceForDate(coinNameSymbol, targetDate);
         double openingPriceUnixDt = new ApiContext().GetOpeningPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(openingPriceDT == openingPriceUnixDt);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  GetHighPriceForDate Tests

      //  Test that GetHighPriceForDate with Bitcoin and DateTime object as params returns valid value
      [Fact]
      public void CreateGetHighPriceForDateBtcDTTest()
      {
         String coinNameSymbol = "BTC";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double highPrice = new ApiContext().GetHighPriceForDate(coinNameSymbol, targetDate);
         Assert.True(highPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetHighPriceForDate with Unitus and DateTime object as params returns valid value
      [Fact]
      public void CreateGetHighPriceForDateUisDTTest()
      {
         String coinNameSymbol = "UIS";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double highPrice = new ApiContext().GetHighPriceForDate(coinNameSymbol, targetDate);
         Assert.True(highPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetHighPriceForDate with non-existent coin and DateTime object as params returns 0
      [Fact]
      public void CreateGetHighPriceForDateBlahDTTest()
      {
         String coinNameSymbol = "BLAH";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double highPrice = new ApiContext().GetHighPriceForDate(coinNameSymbol, targetDate);
         Assert.True(highPrice == 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetHighPriceForDate with Bitcoin and Unix Date object as params returns valid value
      [Fact]
      public void CreateGetHighPriceForDateBtcUnixDtTest()
      {
         String coinNameSymbol = "BTC";
         Int32 targetUnixDate = 1508040539;
         double highPrice = new ApiContext().GetHighPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(highPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetHighPriceForDate with Unitus and Unix Date object as params returns valid value
      [Fact]
      public void CreateGetHighPriceForDateUisUnixDtTest()
      {
         String coinNameSymbol = "UIS";
         Int32 targetUnixDate = 1508040539;
         double highPrice = new ApiContext().GetHighPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(highPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetHighPriceForDate with non-existent coin and Unix Date object as params returns 0
      [Fact]
      public void CreateGetHighPriceForDateBlahUnixDtTest()
      {
         String coinNameSymbol = "BLAH";
         Int32 targetUnixDate = 1508040539;
         double highPrice = new ApiContext().GetHighPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(highPrice == 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetHighPriceForDate for Etherium with DateTime object as param returns same value
      //  as GetHighPriceForDate for Etherium with equivalent Unix Date as param
      [Fact]
      public void CreateGetHighPriceForDateBtcCompareTest()
      {
         String coinNameSymbol = "ETH";
         DateTime targetDate = new DateTime(2017, 9, 15);
         Int32 targetUnixDate = 1505433600;
         double highPriceDT = new ApiContext().GetHighPriceForDate(coinNameSymbol, targetDate);
         double highPriceUnixDt = new ApiContext().GetHighPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(highPriceDT == highPriceUnixDt);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetHighPriceForDate for Nexus with DateTime object as param returns same value
      //  as GetHighPriceForDate for Nexus with equivalent Unix Date as param
      [Fact]
      public void CreateGetHighPriceForDateUisCompareTest()
      {
         String coinNameSymbol = "NXS";
         DateTime targetDate = new DateTime(2017, 10, 15);
         Int32 targetUnixDate = 1508025600;
         double highPriceDT = new ApiContext().GetHighPriceForDate(coinNameSymbol, targetDate);
         double highPriceUnixDt = new ApiContext().GetHighPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(highPriceDT == highPriceUnixDt);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  GetLowPriceForDate Tests

      //  Test that GetLowPriceForDate with Bitcoin and DateTime object as params returns valid value
      [Fact]
      public void CreateGetLowPriceForDateBtcDTTest()
      {
         String coinNameSymbol = "BTC";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double lowPrice = new ApiContext().GetLowPriceForDate(coinNameSymbol, targetDate);
         Assert.True(lowPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetLowPriceForDate with Unitus and DateTime object as params returns valid value
      [Fact]
      public void CreateGetLowPriceForDateUisDTTest()
      {
         String coinNameSymbol = "UIS";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double lowPrice = new ApiContext().GetLowPriceForDate(coinNameSymbol, targetDate);
         Assert.True(lowPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetLowPriceForDate with non-existent coin and DateTime object as params returns 0
      [Fact]
      public void CreateGetLowPriceForDateBlahDTTest()
      {
         String coinNameSymbol = "BLAH";
         DateTime targetDate = new DateTime(2017, 9, 30);
         double lowPrice = new ApiContext().GetLowPriceForDate(coinNameSymbol, targetDate);
         Assert.True(lowPrice == 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetLowPriceForDate with Bitcoin and Unix Date object as params returns valid value
      [Fact]
      public void CreateGetLowPriceForDateBtcUnixDtTest()
      {
         String coinNameSymbol = "BTC";
         Int32 targetUnixDate = 1508040539;
         double lowPrice = new ApiContext().GetLowPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(lowPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetLowPriceForDate with Unitus and Unix Date object as params returns valid value
      [Fact]
      public void CreateGetLowPriceForDateUisUnixDtTest()
      {
         String coinNameSymbol = "UIS";
         Int32 targetUnixDate = 1508040539;
         double lowPrice = new ApiContext().GetLowPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(lowPrice > 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetLowPriceForDate with non-existent coin and Unix Date object as params returns 0
      [Fact]
      public void CreateGetLowPriceForDateBlahUnixDtTest()
      {
         String coinNameSymbol = "BLAH";
         Int32 targetUnixDate = 1508040539;
         double lowPrice = new ApiContext().GetLowPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(lowPrice == 0);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetLowPriceForDate for Etherium with DateTime object as param returns same value
      //  as GetLowPriceForDate for Etherium with equivalent Unix Date as param
      [Fact]
      public void CreateGetLowPriceForDateBtcCompareTest()
      {
         String coinNameSymbol = "ETH";
         DateTime targetDate = new DateTime(2017, 9, 15);
         Int32 targetUnixDate = 1505433600;
         double highPriceDT = new ApiContext().GetLowPriceForDate(coinNameSymbol, targetDate);
         double highPriceUnixDt = new ApiContext().GetLowPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(highPriceDT == highPriceUnixDt);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetLowPriceForDate for Nexus with DateTime object as param returns same value
      //  as GetLowPriceForDate for Nexus with equivalent Unix Date as param
      [Fact]
      public void CreateGetLowPriceForDateUisCompareTest()
      {
         String coinNameSymbol = "NXS";
         DateTime targetDate = new DateTime(2017, 10, 15);
         Int32 targetUnixDate = 1508025600;
         double lowPriceDT = new ApiContext().GetLowPriceForDate(coinNameSymbol, targetDate);
         double lowPriceUnixDt = new ApiContext().GetLowPriceForDate(coinNameSymbol, targetUnixDate);
         Assert.True(lowPriceDT == lowPriceUnixDt);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      // CryptoCompare API misc method tests

      //  Test that GetApiUrl with no params returns valid URL string (i.e. contains "https://")
      [Fact]
      public void CreateGetApiUrlHttpsTest()
      {
         string apiUrl = new ApiContext().GetApiUrl();
         Assert.Contains("https://", apiUrl);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetApiUrl with param returns valid URL string (i.e. contains "https://")
      [Fact]
      public void CreateGetApiUrlWithParamHttpsTest()
      {
         string apiUrl = new ApiContext().GetApiUrl("Pricemulti");
         Assert.Contains("https://", apiUrl);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetInfoUrl returns valid URL string (i.e. contains "https://")
      [Fact]
      public void CreateGetInfoUrlHttpsTest()
      {
         string infoUrl = new ApiContext().GetInfoUrl();
         Assert.Contains("https://", infoUrl);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetApiName returns "CryptoCompare.com"
      [Fact]
      public void CreateGetApiNameHttpsTest()
      {
         string apiName = new ApiContext().GetApiName();
         Assert.True(apiName == "CryptoCompare.com");
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetApiUrl with "Pricemulti" param does not drop down to default return value
      [Fact]
      public void CreateGetApiUrlPricemultiNonDefaultTest()
      {
         string apiUrl = new ApiContext().GetApiUrl("Pricemulti");
         Assert.DoesNotContain("coinlist", apiUrl);
         System.Threading.Thread.Sleep(2 * 1000);
      }

      //  Test that GetApiUrl with "HistoDay" param does not drop down to default return value
      [Fact]
      public void CreateGetApiUrlHistoDayNonDefaultTest()
      {
         string apiUrl = new ApiContext().GetApiUrl("HistoDay");
         Assert.DoesNotContain("coinlist", apiUrl);
         System.Threading.Thread.Sleep(2 * 1000);
      }
   }
}
