using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ClashofClansPatcher
{
    public class Patcher
    {
        public static void Patch(string Version,string fileName, Label offsetTxt)
        {
            if (fileName == null)
                MessageBox.Show("You haven't chosen your file to patch", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (offsetTxt == null)
                MessageBox.Show("offset label cannot be null", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string pk = Keys.GetKey(Version);
            DeveloperPatch(pk, fileName, offsetTxt);
        }
        public static void DeveloperPatch(string key,string filename,Label offsettxt)
        {
            if (filename == null)
                MessageBox.Show("filename cannot be null", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (key == null)
                MessageBox.Show("Key cannot be null", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (offsettxt == null)
                MessageBox.Show("offset textbox cannot be nulled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            byte[] fileBytes = File.ReadAllBytes(filename);
            byte[] searchPattern = key.ToByteArray();
            byte[] replacePattern = "72f1a4a4c48e44da0c42310f800e96624e6dc6a641a9d41c3b5039d8dfadc27e".ToByteArray();
            IEnumerable<int> positions = fileBytes.FindPattern(searchPattern);
            if (positions.Count() == 0)
            {
                MessageBox.Show("Patched failed \nDetail : Key wasn't found in file.Make sure you chose right version.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (int pos in positions)
            {
                offsettxt.Text = "Key offset: 0x" + pos.ToString("X8");
                using (BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Open, FileAccess.Write)))
                {
                    bw.BaseStream.Seek(pos, SeekOrigin.Begin);
                    bw.Write(replacePattern);
                }
                MessageBox.Show("Patched successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        
    }
}
