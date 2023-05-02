using RestSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TronNet;
using TronNet.Crypto;
using TronNet.Protocol;
using Newtonsoft.Json.Linq;

public static class AddressGenerator
{
    public static readonly byte bytePrefix = 0x41;
    public static Tuple<string, string> GenerateAddressAndKey()
    {
        var key = TronECKey.GenerateKey(TronNetwork.TestNet);
        var address = Base58Encoder.EncodeFromHex(key.GetPublicAddress(), bytePrefix);
        var privatKey = key.GetPrivateKey();
        return Tuple.Create(address, privatKey);
    }
}
