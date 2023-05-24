using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Aral_Hotel
{
    public partial class FRMYeniMusteri : Form
    {
        public FRMYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AralHotel;Integrated Security=True");



        private void FRMYeniMusteri_Load(object sender, EventArgs e)
        {
            //101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BTNOda101.Text = oku1["Adi"].ToString() + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BTNOda101.Text != "101")
            {
                BTNOda101.BackColor = Color.Red;
                BTNOda101.Enabled = false;
            }

            //102


            //103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BTNOda103.Text = oku3["Adi"].ToString() + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BTNOda103.Text != "103")
            {
                BTNOda103.BackColor = Color.Red;
                BTNOda103.Enabled = false;
            }

            //104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BTNOda104.Text = oku4["Adi"].ToString() + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BTNOda104.Text != "104")
            {
                BTNOda104.BackColor = Color.Red;
                BTNOda104.Enabled = false;
            }


            //105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BTNOda105.Text = oku5["Adi"].ToString() + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BTNOda105.Text != "105")
            {
                BTNOda105.BackColor = Color.Red;
                BTNOda105.Enabled = false;
            }


            //106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BTNOda106.Text = oku6["Adi"].ToString() + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BTNOda106.Text != "106")
            {
                BTNOda106.BackColor = Color.Red;
                BTNOda106.Enabled = false;
            }


            //107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BTNOda107.Text = oku7["Adi"].ToString() + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BTNOda107.Text != "107")
            {
                BTNOda107.BackColor = Color.Red;
                BTNOda107.Enabled = false;
            }


            //108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BTNOda108.Text = oku8["Adi"].ToString() + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BTNOda108.Text != "108")
            {
                BTNOda108.BackColor = Color.Red;
                BTNOda108.Enabled = false;
            }


            //109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BTNOda109.Text = oku9["Adi"].ToString() + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BTNOda109.Text != "109")
            {
                BTNOda109.BackColor = Color.Red;
                BTNOda109.Enabled = false;
            }
        }

        private void BTNOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTNOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTNOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTNOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTNOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTNOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTNOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTNOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTNOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTNDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir!");
        }

        private void BTNBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir!");
        }

        private void DTPCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DTPGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DTPCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label11.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label11.Text) * 50;
            TXTUcret.Text = Ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('"+TxtAdi.Text+"','"+TxtSoyadi.Text+"','"+comboBox1.Text+"','"+MskTxtTelefon.Text+"','"+TxtMail.Text+"','"+TxtTCNo.Text+"','"+TxtOdaNo.Text+"','"+TXTUcret.Text+"','"+DTPGirisTarihi.Value.ToString("yyyy-MM-dd")+"','"+DTPCikisTarihi.Value.ToString("yyyy-MM-dd") + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı!");
        }

    }
    }
//Data Source = localhost\SQLEXPRESS; Initial Catalog = AralHotel; Integrated Security = True