//
//  Synuit.Blockchain.Api - Blockchain/Cryptocurrency Api's for .NET
//  Copyright © 2017-2018 Synuit Software. All Rights Reserved.
//
using System;
using Newtonsoft.Json.Linq;
using Synuit.Blockchain.Api.Coin.Models;
using Synuit.Blockchain.Api.CryptoCompare.Models;
//
namespace Synuit.Blockchain.Api.CryptoCompare.Extensions
{
    public static class CoinInformationExtensions
    {
        // This overload of PopulateFromJson populates the basic elements of a single CoinInformation object,
        // as deserialized from CryptoCompare.com API's coinlist call
        public static void PopulateFromJson(this CoinInformation coinInformation, CoinInfo coin)
        {
            coinInformation.Id = coin.Id;
            coinInformation.Symbol = coin.Name;
            coinInformation.Algorithm = coin.Algorithm;
            coinInformation.CoinName = coin.CoinName;
            coinInformation.FullName =  coin.FullName;
            coinInformation.FullyPremined = coin.FullyPremined;
            coinInformation.ImageUrl = coin.ImageUrl;
            coinInformation.PreMinedValue = coin.PreMinedValue;
            coinInformation.ProofType = coin.ProofType;
            coinInformation.SortOrder = coin.SortOrder;
            coinInformation.TotalCoinsFreeFloat = coin.TotalCoinsFreeFloat;
            coinInformation.TotalCoinSupply = coin.TotalCoinSupply;
            coinInformation.Url = coin.Url;
        }

        // This overload of PopulateFromJson populates the additional elements of a single CoinInformation object,
        // as deserialized from CryptoCompare.com API's CoinSnapshotFullById call
        public static void PopulateFromJson(this CoinInformation coinInformation, GeneralCoinSnapshotData snapshot)
        {
            coinInformation.CurrentBlocks = Convert.ToInt32(snapshot.BlockNumber);
            coinInformation.Reward = Convert.ToDouble(snapshot.BlockReward);
            coinInformation.TotalCoinsMined = snapshot.TotalCoinsMined;
            coinInformation.RewardReduction = snapshot.BlockRewardReduction;
            coinInformation.EstimatedBlockTime = Convert.ToDouble(snapshot.BlockTime);
            coinInformation.NetworkHashRate = Convert.ToDouble(snapshot.NetHashesPerSecond);
        }

        // This overload of PopulateFromJson populates the Price and Market Cap elements of a single
        // CoinInformation object, as deserialized from CryptoCompare.com API's pricemulti call
        public static void PopulateFromJson(this CoinInformation coinInformation, CoinPrice priceRec)
        {
            try
            {
                coinInformation.Price = priceRec.USD;
                coinInformation.MarketCap = Convert.ToDouble(coinInformation.TotalCoinsMined) * coinInformation.Price;
            }
            catch (FormatException e)
            {
                coinInformation.Price = 0.0;
                coinInformation.MarketCap = 0.0;
            }
            catch (OverflowException e)
            {
                coinInformation.Price = 0.0;
                coinInformation.MarketCap = 0.0;
            }
        }

        // This overload of PopulateFromJson populates the Price element of a single
        // CoinInformation object, as deserialized from CryptoCompare.com API's pricemulti call
        // This overload is not currently used
        public static void PopulateFromJson(this CoinInformation coinInformation, string priceStr)
        {
            try
            {
                coinInformation.Price = Convert.ToDouble(priceStr);
            }
            catch (FormatException e)
            {
                coinInformation.Price = 0.0;
            }
            catch (OverflowException e)
            {
                coinInformation.Price = 0.0;
            }
        }

    }
}
