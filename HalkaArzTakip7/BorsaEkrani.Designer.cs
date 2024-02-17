namespace HalkaArzTakip7
{
    partial class Borsa
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
            this.components = new System.ComponentModel.Container();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.BtnVeriCek = new System.Windows.Forms.Button();
            this.TxtUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ListNews = new System.Windows.Forms.ListBox();
            this.ListNews2 = new System.Windows.Forms.ListBox();
            this.BtnAnaMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(493, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 25);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Arama";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(596, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(322, 22);
            this.txtSearch.TabIndex = 11;
            // 
            // BtnVeriCek
            // 
            this.BtnVeriCek.Location = new System.Drawing.Point(296, 12);
            this.BtnVeriCek.Name = "BtnVeriCek";
            this.BtnVeriCek.Size = new System.Drawing.Size(151, 29);
            this.BtnVeriCek.TabIndex = 9;
            this.BtnVeriCek.Text = "Hisseyi göster";
            this.BtnVeriCek.UseVisualStyleBackColor = true;
            this.BtnVeriCek.Click += new System.EventHandler(this.BtnVeriCek_Click);
            // 
            // TxtUri
            // 
            this.TxtUri.Location = new System.Drawing.Point(85, 12);
            this.TxtUri.Name = "TxtUri";
            this.TxtUri.Size = new System.Drawing.Size(205, 22);
            this.TxtUri.TabIndex = 8;
            this.TxtUri.Text = "https://uzmanpara.milliyet.com.tr/borsa/hisse-fiyatlari/";
            this.TxtUri.TextChanged += new System.EventHandler(this.TxtUri_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-81, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "SiteAdresi:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "SiteAdresi:";
            // 
            // ListNews
            // 
            this.ListNews.FormattingEnabled = true;
            this.ListNews.ItemHeight = 16;
            this.ListNews.Location = new System.Drawing.Point(12, 47);
            this.ListNews.Name = "ListNews";
            this.ListNews.Size = new System.Drawing.Size(435, 324);
            this.ListNews.TabIndex = 15;
            // 
            // ListNews2
            // 
            this.ListNews2.FormattingEnabled = true;
            this.ListNews2.ItemHeight = 16;
            this.ListNews2.Location = new System.Drawing.Point(493, 47);
            this.ListNews2.Name = "ListNews2";
            this.ListNews2.Size = new System.Drawing.Size(425, 324);
            this.ListNews2.TabIndex = 16;
            // 
            // BtnAnaMenu
            // 
            this.BtnAnaMenu.Location = new System.Drawing.Point(12, 378);
            this.BtnAnaMenu.Name = "BtnAnaMenu";
            this.BtnAnaMenu.Size = new System.Drawing.Size(906, 50);
            this.BtnAnaMenu.TabIndex = 17;
            this.BtnAnaMenu.Text = "Ana Menü";
            this.BtnAnaMenu.UseVisualStyleBackColor = true;
            this.BtnAnaMenu.Click += new System.EventHandler(this.BtnAnaMenu_Click);
            // 
            // Borsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(941, 440);
            this.Controls.Add(this.BtnAnaMenu);
            this.Controls.Add(this.ListNews2);
            this.Controls.Add(this.ListNews);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.BtnVeriCek);
            this.Controls.Add(this.TxtUri);
            this.Controls.Add(this.label1);
            this.Name = "Borsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borsa Takip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button BtnVeriCek;
        private System.Windows.Forms.TextBox TxtUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListNews;
        private System.Windows.Forms.ListBox ListNews2;
        private System.Windows.Forms.Button BtnAnaMenu;
    }
}