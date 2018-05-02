//
//  Synuit.Blockchain.Api - Blockchain/Cryptocurrency Api's for .NET
//  Copyright © 2017-2018 Synuit Software. All Rights Reserved.
//
namespace Synuit.Blockchain.Api.Coin.Models
{
   /// <summary>
   /// Coin information.
   ///
   /// This is the class that defines the structure of each coin record, based on the elements provided by the
   /// various CryptoCompare.com API call
   /// </summary>
   public class CoinInformation
   {
     public string Id { get; set; }
     public string Symbol { get; set; }
     public string Algorithm { get; set; }
     public long CurrentBlocks { get; set; }
     public double Difficulty { get; set; }
     public double Reward { get; set; }
     public double EstimatedBlockTime { get; set; }
     public double NetworkHashRate { get; set; }
     public double Price { get; set; }
     public double MarketCap { get; set; }
     public double Income { get; set; }
     public string Exchange { get; set; }
     public double Profitability { get; set; }
     public double AdjustedProfitability { get; set; }
     public double AverageProfitability { get; set; }
     public double AverageHashRate { get; set; }
     public bool IsMultiCoin { get; set; }
     public string Url { get; set; }
     public string ImageUrl { get; set; }
     public string CoinName { get; set; }
     public string FullName { get; set; }
     public string ProofType { get; set; }
     public string FullyPremined { get; set; }
     public string TotalCoinSupply { get; set; }
     public string TotalCoinsMined { get; set; }
     public string RewardReduction { get; set; }
     public string PreMinedValue { get; set; }
     public string TotalCoinsFreeFloat { get; set; }
     public string SortOrder { get; set; }
   }
}
