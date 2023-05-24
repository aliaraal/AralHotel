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

namespace Aral_Hotel
{
    public partial class FRMAdminGiris : Form
    {
        public FRMAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AralHotel;Integrated Security=True");

        private void BTNGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici=@Kullanici AND Sifre=@Sifre";
                SqlParameter prm1 = new SqlParameter("Kullanici", TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifre", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FRMAnaForm fr = new FRMAnaForm();
                    fr.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş!");
            }
        }

        private void FRMAdminGiris_Load(object sender, EventArgs e)
        {
            
        }
    }
}

//Data Source=localhost\SQLEXPRESS;Initial Catalog=AralHotel;Integrated Security=True