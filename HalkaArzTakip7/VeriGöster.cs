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
using System.Globalization;

namespace HalkaArzTakip7
{
    public partial class VeriGöster : Form
    {
        public VeriGöster()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-48R5JDT\SQLEXPRESS01;Initial Catalog=DBBorsa;Integrated Security=True");
        double alisfiyati;
        private void VeriGöster_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Sembol from TBLBorsa", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLBorsa where Sembol=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            { 
                LblLot.Text = dr[2].ToString() + " adet";
                DateTime tarih = Convert.ToDateTime(dr["Tarih"]);
                LblTarih.Text = tarih.ToString("MM-dd-yyyy");
                LblAlisFiyati.Text = dr[4].ToString() + " TL";
                alisfiyati = Convert.ToDouble(dr[4]);
                LblSermaye.Text = (Convert.ToDouble(dr[2]) * Convert.ToDouble(dr[4])).ToString() + "TL" ;
            }
            baglanti.Close();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLBorsa where Sembol=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            int tavan = Convert.ToInt32(TxtTavan.Text);
            double kar,sermaye;
            
            while (dr.Read())
            {
                double alisfiyati = Convert.ToDouble(dr[4]);
                double yeniAlisFiyati = alisfiyati;
                int lot = Convert.ToInt32(dr[2]);
                for (int i = 0; i < tavan; i++)
                {
                    yeniAlisFiyati = yeniAlisFiyati + (yeniAlisFiyati * 10) / 100;
                }
                sermaye = alisfiyati * lot;
                kar = ((yeniAlisFiyati * lot) - sermaye);
                if(kar > 0)
                {
                    LblKar.ForeColor = Color.Green;
                    LblKar.Text = (Convert.ToInt32(kar)).ToString() + " TL";

                }
                //LblKar.Text = (Convert.ToInt32(kar)).ToString() + " TL";
                LblToplamPara.Text = (Convert.ToInt32((sermaye + kar))).ToString() + " TL";
            }
            
            baglanti.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
            HalkaArzForm form = new HalkaArzForm();
            this.Hide();
            form.Show();
        }
    }
}

