using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashofClansPatcher
{ 
    public static class Extensions
    {
        /// <summary>
        /// Convert a hex string to a byte array like 0xAA
        /// </summary>
        /// <param name="hex">The hex string</param>
        /// <returns></returns>
        public static byte[] ToByteArray(this string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        public static IEnumerable<int> FindPattern(this byte[] fileBytes, byte[] searchPattern)
        {
            if ((searchPattern != null) && (fileBytes.Length >= searchPattern.Length))
                for (int i = 0; i < fileBytes.Length - searchPattern.Length + 1; i++)
                    if (!searchPattern.Where((data, index) => !fileBytes[i + index].Equals(data)).Any())
                        yield return i;
        }
    }
}
