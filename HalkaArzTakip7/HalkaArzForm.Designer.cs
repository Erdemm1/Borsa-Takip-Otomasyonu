namespace HalkaArzTakip7
{
    partial class HalkaArzForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.BtnVeriGoster = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.TxtSembol = new System.Windows.Forms.TextBox();
            this.TxtLot = new System.Windows.Forms.TextBox();
            this.TxtTarih = new System.Windows.Forms.TextBox();
            this.TxtAlisFiyati = new System.Windows.Forms.TextBox();
            this.TxtSatisFiyati = new System.Windows.Forms.TextBox();
            this.BtnBorsa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(299, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lot:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(262, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sembol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(281, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(244, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "AlisFiyati:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(235, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "SatisFiyati:";
            // 
            // BtnKayit
            // 
            this.BtnKayit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKayit.Location = new System.Drawing.Point(351, 243);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(305, 45);
            this.BtnKayit.TabIndex = 33;
            this.BtnKayit.Text = "KayitEt";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // BtnVeriGoster
            // 
            this.BtnVeriGoster.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVeriGoster.Location = new System.Drawing.Point(351, 294);
            this.BtnVeriGoster.Name = "BtnVeriGoster";
            this.BtnVeriGoster.Size = new System.Drawing.Size(305, 52);
            this.BtnVeriGoster.TabIndex = 34;
            this.BtnVeriGoster.Text = "Verileri Göster";
            this.BtnVeriGoster.UseVisualStyleBackColor = true;
            this.BtnVeriGoster.Click += new System.EventHandler(this.BtnVeriGoster_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(351, 411);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(305, 50);
            this.BtnCikis.TabIndex = 35;
            this.BtnCikis.Text = "Çıkış Yap";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // TxtSembol
            // 
            this.TxtSembol.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSembol.Location = new System.Drawing.Point(351, 55);
            this.TxtSembol.Name = "TxtSembol";
            this.TxtSembol.Size = new System.Drawing.Size(305, 28);
            this.TxtSembol.TabIndex = 36;
            this.TxtSembol.TextChanged += new System.EventHandler(this.TxtSembol_TextChanged);
            // 
            // TxtLot
            // 
            this.TxtLot.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtLot.Location = new System.Drawing.Point(351, 93);
            this.TxtLot.Name = "TxtLot";
            this.TxtLot.Size = new System.Drawing.Size(305, 28);
            this.TxtLot.TabIndex = 37;
            // 
            // TxtTarih
            // 
            this.TxtTarih.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Location = new System.Drawing.Point(351, 133);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(305, 28);
            this.TxtTarih.TabIndex = 38;
            // 
            // TxtAlisFiyati
            // 
            this.TxtAlisFiyati.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAlisFiyati.Location = new System.Drawing.Point(351, 174);
            this.TxtAlisFiyati.Name = "TxtAlisFiyati";
            this.TxtAlisFiyati.Size = new System.Drawing.Size(305, 28);
            this.TxtAlisFiyati.TabIndex = 39;
            // 
            // TxtSatisFiyati
            // 
            this.TxtSatisFiyati.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatisFiyati.Location = new System.Drawing.Point(351, 212);
            this.TxtSatisFiyati.Name = "TxtSatisFiyati";
            this.TxtSatisFiyati.Size = new System.Drawing.Size(305, 28);
            this.TxtSatisFiyati.TabIndex = 40;
            // 
            // BtnBorsa
            // 
            this.BtnBorsa.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBorsa.Location = new System.Drawing.Point(351, 353);
            this.BtnBorsa.Name = "BtnBorsa";
            this.BtnBorsa.Size = new System.Drawing.Size(305, 52);
            this.BtnBorsa.TabIndex = 41;
            this.BtnBorsa.Text = "Borsa";
            this.BtnBorsa.UseVisualStyleBackColor = true;
            this.BtnBorsa.Click += new System.EventHandler(this.BtnBorsa_Click);
            // 
            // HalkaArzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(992, 586);
            this.Controls.Add(this.BtnBorsa);
            this.Controls.Add(this.TxtSatisFiyati);
            this.Controls.Add(this.TxtAlisFiyati);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.TxtLot);
            this.Controls.Add(this.TxtSembol);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnVeriGoster);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "HalkaArzForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veriler";
            this.Load += new System.EventHandler(this.HalkaArzForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.Button BtnVeriGoster;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.TextBox TxtSembol;
        private System.Windows.Forms.TextBox TxtLot;
        private System.Windows.Forms.TextBox TxtTarih;
        private System.Windows.Forms.TextBox TxtAlisFiyati;
        private System.Windows.Forms.TextBox TxtSatisFiyati;
        private System.Windows.Forms.Button BtnBorsa;
    }
}