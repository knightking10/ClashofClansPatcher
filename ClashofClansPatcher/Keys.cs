using System.Collections.Generic;

namespace ClashofClansPatcher
{
    public class Keys
    {
        /// <summary>
        /// Get a clash of clans key from version
        /// </summary>
        /// <param name="version">Clash of Clans version</param>
        /// <returns>The key we found</returns>
        public static string GetKey(string version)
        {
            string key = "";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("8.709.2", "78df4df6f0e6db0261e87dd38e74bb29557dfe5b9bce91f92e1c98355d7e7139");
            dic.Add("8.551.24", "1315d5ba8e41d40d2ad1480aa621ad864cf2557569d184fa00fc11471dd31f4b");
            dic.Add("8.332.16", "bb9ca4c6b52ecdb40267c3bcca03679201a403ef6230b9e488db949b58bc7479");
            dic.Add("8.551.4", "349ce78b78a06a4e94645435acba1dfffc40cc2276558ed2d118f1343a197876");
            dic.Add("8.212.12", "9b39b440ff6c13ad07b506fc55e37f69856895c3fd5ab35978cdf5e34eb37471");
            dic.Add("8.212.9", "469b704e7f6009ba8fc72e9b5c864c8e9285a755c5190f03f5c74852f6d9f419");
            dic.Add("8.212.3", "150c52db12ba1c9dd809b8934a535f428a91b7b61e15ab469e42b9614c76a325");
            dic.Add("8.67.8", "47d1416f3cf982d2b510cab32ecc4f1a04971345446cb1af326f304f63da6264");
            dic.Add("8.116.11", "5684d6fad4d638b1c9354feb0350f90f3ef40ccd565955489b1f61d7676e412a");
            dic.Add("8.116.2", "01c98c143a840d92ee656996dad5af41de5d1b8ebb289081368b5cfda9bd4a30");
            
            dic.TryGetValue(version, out key);
            return key;

        }
    }
}
