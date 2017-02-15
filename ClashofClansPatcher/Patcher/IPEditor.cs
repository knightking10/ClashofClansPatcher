using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClashofClansPatcher
{
    public class IPEditor
    {
        public static void EditIP(string path, string oldhostname, string newhostname)
        {
            byte[] searchbyte = GetBytes(oldhostname);
            byte[] filebyte = File.ReadAllBytes(path);
            IEnumerable<int> positions = filebyte.FindPattern(searchbyte);
            if (positions.Count() == 0)
            {
                MessageBox.Show("We weren't able to find the ip.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (int p in positions)
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Open, FileAccess.Write)))
                {
                    bw.BaseStream.Seek(p, SeekOrigin.Begin);
                    bw.Write(GetBytes(newhostname));
                }
                MessageBox.Show("IP Edited successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
        
        static byte[] GetBytes(string ip)
        {
            return Encoding.UTF8.GetBytes(ip);
        }
    }

}
