//
//  Synuit.Blockchain.Api - Blockchain/Cryptocurrency Api's for .NET
//  Copyright © 2017-2018 Synuit Software. All Rights Reserved.
//
// --> https://www.cryptocompare.com/api/data/coinlist/
using System.Collections.Generic;
//
namespace Synuit.Blockchain.Api.CryptoCompare.Models
{
   public class CoinInfo
   {
      public string Id { get; set; }
      public string Url { get; set; }
      public string ImageUrl { get; set; }
      public string Name { get; set; }
      public string CoinName { get; set; }
      public string FullName { get; set; }
      public string Algorithm { get; set; }
      public string ProofType { get; set; }
      public string FullyPremined { get; set; }
      public string TotalCoinSupply { get; set; }
      public string PreMinedValue { get; set; }
      public string TotalCoinsFreeFloat { get; set; }
      public string SortOrder { get; set; }
   }
   //
   public class DataCoinList : Dictionary<string, CoinInfo> { }
   //
   public class RootObjectCoinList
   {
      public string Response { get; set; }
      public string Message { get; set; }
      public string BaseImageUrl { get; set; }
      public string BaseLinkUrl { get; set; }
      public DataCoinList Data { get; set; }
      public int Type { get; set; }
   }
   //
}
