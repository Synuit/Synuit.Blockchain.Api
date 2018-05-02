//
//  Synuit.Blockchain.Api - Blockchain/Cryptocurrency Api's for .NET
//  Copyright © 2017-2018 Synuit Software. All Rights Reserved.
//
using System;
//
namespace Synuit.Blockchain.Api.Coin.Exceptions
{
    [Serializable]
    public class CoinApiException : Exception
    {
        public CoinApiException(string message) : base(message) { }
    }
}
