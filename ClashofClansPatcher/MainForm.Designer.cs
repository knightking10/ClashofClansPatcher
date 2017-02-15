namespace ClashofClansPatcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPatch = new System.Windows.Forms.Button();
            this.txtOffset = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboVersion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dev_Patch = new System.Windows.Forms.Button();
            this.dev_offset = new System.Windows.Forms.Label();
            this.dev_key = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dev_filename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dev_Browser = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.oldhosttxt = new System.Windows.Forms.TextBox();
            this.Editbtn = new System.Windows.Forms.Button();
            this.newhost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.old_host = new System.Windows.Forms.Label();
            this.pathtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPatch);
            this.tabPage1.Controls.Add(this.txtOffset);
            this.tabPage1.Controls.Add(this.txtKey);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboVersion);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patcher";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPatch
            // 
            this.btnPatch.Location = new System.Drawing.Point(211, 204);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(75, 23);
            this.btnPatch.TabIndex = 8;
            this.btnPatch.Text = "Patch";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // txtOffset
            // 
            this.txtOffset.AutoSize = true;
            this.txtOffset.Location = new System.Drawing.Point(78, 181);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(60, 13);
            this.txtOffset.TabIndex = 7;
            this.txtOffset.Text = "Key offset :";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(81, 127);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(345, 20);
            this.txtKey.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Key";
            // 
            // comboVersion
            // 
            this.comboVersion.FormattingEnabled = true;
            this.comboVersion.Items.AddRange(new object[] {
            "8.709.2",
            "8.551.24",
            "8.551.4",
            "8.332.16",
            "8.212.12",
            "8.212.9",
            "8.212.3",
            "8.116.11",
            "8.116.2",
            "8.67.8"});
            this.comboVersion.Location = new System.Drawing.Point(81, 86);
            this.comboVersion.Name = "comboVersion";
            this.comboVersion.Size = new System.Drawing.Size(345, 21);
            this.comboVersion.TabIndex = 4;
            this.comboVersion.Text = "8.709.2";
            this.comboVersion.SelectedIndexChanged += new System.EventHandler(this.comboVersion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(81, 43);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(345, 20);
            this.txtPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(432, 41);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dev_Patch);
            this.tabPage2.Controls.Add(this.dev_offset);
            this.tabPage2.Controls.Add(this.dev_key);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dev_filename);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dev_Browser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(536, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Developer patcher";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dev_Patch
            // 
            this.dev_Patch.Location = new System.Drawing.Point(203, 152);
            this.dev_Patch.Name = "dev_Patch";
            this.dev_Patch.Size = new System.Drawing.Size(75, 23);
            this.dev_Patch.TabIndex = 15;
            this.dev_Patch.Text = "Patch";
            this.dev_Patch.UseVisualStyleBackColor = true;
            this.dev_Patch.Click += new System.EventHandler(this.dev_Patch_Click);
            // 
            // dev_offset
            // 
            this.dev_offset.AutoSize = true;
            this.dev_offset.Location = new System.Drawing.Point(70, 129);
            this.dev_offset.Name = "dev_offset";
            this.dev_offset.Size = new System.Drawing.Size(63, 13);
            this.dev_offset.TabIndex = 14;
            this.dev_offset.Text = "Key offset : ";
            // 
            // dev_key
            // 
            this.dev_key.Location = new System.Drawing.Point(73, 75);
            this.dev_key.Name = "dev_key";
            this.dev_key.Size = new System.Drawing.Size(345, 20);
            this.dev_key.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Key";
            // 
            // dev_filename
            // 
            this.dev_filename.Location = new System.Drawing.Point(73, 39);
            this.dev_filename.Name = "dev_filename";
            this.dev_filename.Size = new System.Drawing.Size(345, 20);
            this.dev_filename.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Path";
            // 
            // dev_Browser
            // 
            this.dev_Browser.Location = new System.Drawing.Point(424, 37);
            this.dev_Browser.Name = "dev_Browser";
            this.dev_Browser.Size = new System.Drawing.Size(75, 23);
            this.dev_Browser.TabIndex = 9;
            this.dev_Browser.Text = "...";
            this.dev_Browser.UseVisualStyleBackColor = true;
            this.dev_Browser.Click += new System.EventHandler(this.dev_Browser_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.oldhosttxt);
            this.tabPage3.Controls.Add(this.Editbtn);
            this.tabPage3.Controls.Add(this.newhost);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.old_host);
            this.tabPage3.Controls.Add(this.pathtxt);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(536, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "IP Editor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(47, 201);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(249, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Use default hostname( game.clashofclans.com)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // oldhosttxt
            // 
            this.oldhosttxt.Location = new System.Drawing.Point(96, 106);
            this.oldhosttxt.Name = "oldhosttxt";
            this.oldhosttxt.ReadOnly = true;
            this.oldhosttxt.Size = new System.Drawing.Size(345, 20);
            this.oldhosttxt.TabIndex = 17;
            this.oldhosttxt.Text = "game.clashofclans.com";
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(209, 224);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(75, 23);
            this.Editbtn.TabIndex = 16;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // newhost
            // 
            this.newhost.Location = new System.Drawing.Point(96, 147);
            this.newhost.Name = "newhost";
            this.newhost.Size = new System.Drawing.Size(345, 20);
            this.newhost.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "New hostname";
            // 
            // old_host
            // 
            this.old_host.AutoSize = true;
            this.old_host.Location = new System.Drawing.Point(6, 109);
            this.old_host.Name = "old_host";
            this.old_host.Size = new System.Drawing.Size(72, 13);
            this.old_host.TabIndex = 12;
            this.old_host.Text = "Old hostname";
            // 
            // pathtxt
            // 
            this.pathtxt.Location = new System.Drawing.Point(96, 61);
            this.pathtxt.Name = "pathtxt";
            this.pathtxt.Size = new System.Drawing.Size(345, 20);
            this.pathtxt.TabIndex = 11;
            this.pathtxt.TextChanged += new System.EventHandler(this.pathtxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Path";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 335);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Clash of Clans Patcher v1.4";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.ComboBox comboVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtOffset;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.Button dev_Patch;
        private System.Windows.Forms.Label dev_offset;
        private System.Windows.Forms.TextBox dev_key;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dev_filename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dev_Browser;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox oldhosttxt;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.TextBox newhost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label old_host;
        private System.Windows.Forms.TextBox pathtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

