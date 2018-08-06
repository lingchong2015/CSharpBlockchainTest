using System;
using NBitcoin;

namespace CSharpBlockchainTest {
    class BitcoinAddress {
        
        /// <summary>
        /// 公钥和私钥生成测试.
        /// </summary>
        public static void KeyTest() {
            RandomUtils.Random = new UnsecureRandom();
            var privateKey = new Key();
            var pubKey = privateKey.PubKey;
            Console.WriteLine("Public Key: " + pubKey.ToString());
        }
    }
}