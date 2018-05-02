//
//  Synuit.Blockchain.Api - Blockchain/Cryptocurrency Api's for .NET
//  Copyright © 2017-2018 Synuit Software. All Rights Reserved.
//
// --> https://min-api.cryptocompare.com/data/histoday
using System;
using System.Collections.Generic;
//
namespace Synuit.Blockchain.Api.CryptoCompare.Models
{
   public class ConversionType
   {
      public string type { get; set; }
      public string conversionSymbol { get; set; }
   }
   //
   public class HistoDayInfo
   {
      public double time { get; set; }
      public double close { get; set; }
      public double high { get; set; }
      public double low { get; set; }
      public double open { get; set; }
      public double volumefrom { get; set; }
      public double volumeto { get; set; }
   }
   //
   public class RootObjectHistoDay
   {
      public string Response { get; set; }
      public int Type { get; set; }
      public bool Aggregated { get; set; }
      public List<HistoDayInfo> Data { get; set; }
      public Int32 TimeTo { get; set; }
      public Int32 TimeFrom { get; set; }
      public bool FirstValueInArray { get; set; }
      public ConversionType convType { get; set; }
   }
   //
}
