// https://www.cryptocompare.com/api/data/coinlist/

using System.Collections.Generic;

public class RootObject
{
   public string Response { get; set; }
   public string Message { get; set; }
   public string BaseImageUrl { get; set; }
   public string BaseLinkUrl { get; set; }
   public Data Data { get; set; }
   public int Type { get; set; }
}

public class Data : Dictionary<string, CoinInfo> { }

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
