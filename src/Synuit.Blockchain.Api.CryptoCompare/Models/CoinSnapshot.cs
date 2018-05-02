//
//  Synuit.Blockchain.Api - Blockchain/Cryptocurrency Api's for .NET
//  Copyright © 2017-2018 Synuit Software. All Rights Reserved.
//
// --> https://www.cryptocompare.com/api/data/coinsnapshotfullbyid/
using System;
using System.Collections.Generic;
//
namespace Synuit.Blockchain.Api.CryptoCompare.Models
{
   // The classes below parallel the structures of the result sets returned by CryptoCompare.com API calls,
   // so that the returned JSON strings can be deserialized into objects of these classes
   public class DataCoinSnapshot
   {
      public SEOCoinSnapshotData SEO { get; set; }
      public GeneralCoinSnapshotData General { get; set; }
      public ICOCoinSnapshotData ICO { get; set; }
      public List<string> Subs { get; set; }
      public List<string> StreamerDataRaw { get; set; }
   }
   //
   public class RootObjectCoinSnapshot
    {
        public string Response { get; set; }
        public string Message { get; set; }
        public DataCoinSnapshot Data { get; set; }
        public int Type { get; set; }
    }
   //
   public class SEOCoinSnapshotData
    {
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string BaseUrl { get; set; }
        public string BaseImageUrl { get; set; }
        public string OgImageUrl { get; set; }
        public string OgImageWidth { get; set; }
        public string OgImageHeight { get; set; }
    }
   //
   public class ICOCoinSnapshotData
   {
      public string Status { get; set; }
      public string WhitePaper { get; set; }
   }
   //
    public class SponsorData
    {
        public string TextTop { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }
    }

    public class GeneralCoinSnapshotData
    {
        public string ID { get; set; }
        public string DocumentType { get; set; }
        public string H1Text { get; set; }
        public string DangerTop { get; set; }
        public string WarningTop { get; set; }
        public string InfoTop { get; set; }
        public string Symbol { get; set; }
        public string Url { get; set; }
        public string BaseAngularUrl { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Features { get; set; }
        public string Technology { get; set; }
        public string TotalCoinSupply { get; set; }
        public string Algorithm { get; set; }
        public string ProofType { get; set; }
        public string StartDate { get; set; }
        public string Twitter { get; set; }
        public string AffiliateUrl { get; set; }
        public string Website { get; set; }
        public SponsorData Sponsor { get; set; }
        public string LastBlockExplorerUpdateTS { get; set; }
        public string DifficultyAdjustment { get; set; }
        public string BlockRewardReduction { get; set; }
        public string BlockNumber { get; set; }
        public string BlockTime { get; set; }
        public string NetHashesPerSecond { get; set; }
        public string TotalCoinsMined { get; set; }
        public string PreviousTotalCoinsMined { get; set; }
        public string BlockReward { get; set; }
    }

  
}