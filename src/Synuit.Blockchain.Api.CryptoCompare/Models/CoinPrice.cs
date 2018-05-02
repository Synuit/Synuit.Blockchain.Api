//
//  Synuit.Blockchain.Api - Blockchain/Cryptocurrency Api's for .NET
//  Copyright © 2017-2018 Synuit Software. All Rights Reserved.
//
// --> apiUrl = https://min-api.cryptocompare.com/data/pricemulti
using System;
using System.Collections.Generic;
using System.Text;

namespace Synuit.Blockchain.Api.CryptoCompare.Models
{
   public class CoinPrice
   {
      public double USD { get; set; }
   }
   //
   public class DataPriceMulti : Dictionary<string, CoinPrice> { }
   //
   public class RootObjectPriceMulti
   {
      public DataPriceMulti Data { get; set; }
   }
   //
}
