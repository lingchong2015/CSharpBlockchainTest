﻿using System;
using NBitcoin;

namespace CSharpBlockchainTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomUtils.Random = new UnsecureRandom();
            var privateKey = new Key();
            var pubKey = privateKey.PubKey;
            Console.WriteLine("Public Key: " + pubKey.ToString());

            var addressForMain = pubKey.GetAddress(Network.Main);
            var addressForTest = pubKey.GetAddress(Network.TestNet);
            Console.WriteLine("Bitcoin Address of MainNet: " + addressForMain + ", Size: " + addressForMain.ToString().Length + " Bytes.");
            Console.WriteLine("Bitcoin Address of TestNet: " + addressForTest + ", Size: " + addressForTest.ToString().Length + " Bytes.");

            var pubKeyHash = pubKey.Hash;
            Console.WriteLine("Hash Value of Public Key: " + pubKeyHash);
            var addressForMainByHash = pubKeyHash.GetAddress(Network.Main);
            var addressForTestByHash = pubKeyHash.GetAddress(Network.TestNet);
            Console.WriteLine("Bitcoin Address of MainNet Generated by Hash: " + addressForMainByHash + 
            ", Size: " + addressForMainByHash.ToString().Length + " Bytes.");
            Console.WriteLine("Bitcoin Address of TestNet Generated by Hash: " + addressForTestByHash + 
            ", Size: " + addressForTestByHash.ToString().Length + " Bytes.");

            if ((addressForMain == addressForMainByHash) && (addressForTest == addressForTestByHash)) {
                Console.WriteLine("Bitcoin Address which generated by Public Key is equal to which generated by Public Key Hash.");
            }
        }
    }
}