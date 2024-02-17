using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HalkaArzTakip7
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if(TxtKullaniciAdi.Text == "" && TxtSifre.Text == "")
            {
                Form form = new HalkaArzForm();
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı !!!!");
            }
        }

        private void TxtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
