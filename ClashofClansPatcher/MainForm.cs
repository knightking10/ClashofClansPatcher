using System;
using System.Windows.Forms;

namespace ClashofClansPatcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtKey.Text = Keys.GetKey(comboVersion.Text);
        }

        private void comboVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKey.Text = Keys.GetKey(comboVersion.Text);
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files(*.*)| *.*", Multiselect = false, ValidateNames = true })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = ofd.FileName;
                    if (ofd.SafeFileName != "Clash of Clans" || ofd.SafeFileName != "libg.so")
                    {
                        MessageBox.Show("This is not a file to patch", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPath.Text = "";
                    }
                   
                }
            }
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(txtPath.Text))
                {
                    Patcher.Patch(comboVersion.Text, txtPath.Text, txtOffset);
                }
                else
                    MessageBox.Show("Patched failed \nDetail : You havenn't entered filename", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dev_Browser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files(*.*)| *.*", Multiselect = false, ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    dev_filename.Text = ofd.FileName;
                    if (ofd.SafeFileName != "Clash of Clans" || ofd.SafeFileName != "libg.so")
                    {
                        MessageBox.Show("This is not a file to patch", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dev_filename.Text = "";
                    }
                }
            }
        }

        private void dev_Patch_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(dev_filename.Text) || !string.IsNullOrEmpty(dev_key.Text))
                {
                    Patcher.DeveloperPatch(dev_key.Text, dev_filename.Text, dev_offset);
                }
                else
                    MessageBox.Show("Patched failed \nDetail : You haven't entered enough information", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                oldhosttxt.ReadOnly = true;
                if (pathtxt.Text.EndsWith("libg.so"))
                    oldhosttxt.Text = "gamea.clashofclans.com";
                else
                    oldhosttxt.Text = "game.clashofclans.com";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                oldhosttxt.ReadOnly = false;
                oldhosttxt.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files(*.*)| *.*", Multiselect = false, ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pathtxt.Text = ofd.FileName;
                    if (ofd.SafeFileName != "Clash of Clans" || ofd.SafeFileName != "libg.so")
                    {
                        MessageBox.Show("This is not a file to patch", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pathtxt.Text = "";
                    }
                   
                }
            }
        }

        private void pathtxt_TextChanged(object sender, EventArgs e)
        {
            if (pathtxt.Text.EndsWith("Clash of Clans"))
            {
                checkBox1.Text = "Use default hostname (game.clashofclans.com)";
                
            }
            else if (pathtxt.Text.EndsWith("libg.so"))
            {
                checkBox1.Text = "Use default hostname (gamea.clashofclans.com)";
            }
            checkBox1_CheckedChanged(this, new EventArgs());
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(pathtxt.Text != null && oldhosttxt.Text!=null &&newhost.Text!=null)
                {
                    if(pathtxt.Text.EndsWith("libg.so"))
                    {
                        if(newhost.Text.Length != 22)
                        {
                            MessageBox.Show($"Ip must be 22 characters.Your ip was {newhost.Text.Length} characters", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            IPEditor.EditIP(pathtxt.Text, oldhosttxt.Text, newhost.Text);
                        }
                    }
                    else
                    {
                        if (newhost.Text.Length != 21)
                        {
                            MessageBox.Show($"Ip must be 21 characters.Your ip was {newhost.Text.Length} characters", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            IPEditor.EditIP(pathtxt.Text, oldhosttxt.Text, newhost.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Edited failed \nDetail : You haven't entered enough information", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if(ex is ArgumentException)
                {
                    MessageBox.Show("Edited failed \nDetail : You haven't entered enough information", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Edited failed \nDetail : " + ex.ToString());
                }
                
            }
        }
    }
}
