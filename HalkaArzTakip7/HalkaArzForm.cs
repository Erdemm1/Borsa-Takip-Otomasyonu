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
    public partial class HalkaArzForm : Form
    {
        public HalkaArzForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-48R5JDT\SQLEXPRESS01;Initial Catalog=DBBorsa;Integrated Security=True");

        private void HalkaArzForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLBorsa (Sembol,Lot,Tarih,AlisFiyati,SatisFiyati) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtSembol.Text);
            komut.Parameters.AddWithValue("@p2", TxtLot.Text);
            komut.Parameters.AddWithValue("@p3", TxtTarih.Text);
            komut.Parameters.AddWithValue("@p4", TxtAlisFiyati.Text);
            komut.Parameters.AddWithValue("@p5", TxtSatisFiyati.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayit Başarı İle Oluşturuldu.");
            baglanti.Close();
        }
        private void BtnVeriGoster_Click(object sender, EventArgs e)
        {
            VeriGöster veriForm = new VeriGöster();
            veriForm.Show();
            this.Hide();
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtSembol_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBorsa_Click(object sender, EventArgs e)
        {
            Borsa borsaform = new Borsa();
            borsaform.Show();
            this.Hide();
        }
    }
}
