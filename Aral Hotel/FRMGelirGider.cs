﻿using System;
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

namespace Aral_Hotel
{
    public partial class FRMGelirGider : Form
    {
        public FRMGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AralHotel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            LBLPersonelMaasları.Text = (personel * 1500).ToString();

            int sonuc;
            sonuc= Convert.ToInt32(LBLKasaToplamTutar.Text)-(Convert.ToInt16(LBLPersonelMaasları.Text)+Convert.ToInt16(LBLAlınanUrunlerTutarı1.Text) + Convert.ToInt16(LBLAlınanUrunlerTutarı2.Text) + Convert.ToInt16(LBLAlınanUrunlerTutarı3.Text) + Convert.ToInt16(LBLFaturalar.Text) + Convert.ToInt16(LBLFaturalar2.Text) + Convert.ToInt16(LBLFaturalar3.Text));
          LBLSonuc.Text= sonuc.ToString();
        }

        private void FRMGelirGider_Load(object sender, EventArgs e)
        {

            //KASADAKİ GOPLAM TUTAR

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LBLKasaToplamTutar.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //GIDA GİDERLERİ

            
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LBLAlınanUrunlerTutarı1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            //İÇECEK GİDERLERİ


            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(Icecek) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LBLAlınanUrunlerTutarı2.Text = oku3["toplam3"].ToString();
            }
            baglanti.Close();

            //ÇEREZ GİDERLERİ


            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Cerezler) as toplam4 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LBLAlınanUrunlerTutarı3.Text = oku4["toplam4"].ToString();
            }
            baglanti.Close();

            //ELEKTİRİK FATURASI

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LBLFaturalar.Text = oku5["toplam5"].ToString();
            }
            baglanti.Close();

            //SU FATURASI 

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LBLFaturalar2.Text = oku6["toplam6"].ToString();
            }
            baglanti.Close();

            //İNTERNET FATURASI

            baglanti.Open();
            SqlCommand komut7= new SqlCommand("Select sum(Internet) as toplam7 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LBLFaturalar3.Text = oku7["toplam7"].ToString();
            }
            baglanti.Close();

        }

        private void LBLFaturalar_Click(object sender, EventArgs e)
        {

        }
    }
    }
 
