using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aral_Hotel
{
    public partial class FRMAnaForm : Form
    {
        public FRMAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMAdminGiris fr = new FRMAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRMYeniMusteri fr = new FRMYeniMusteri();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRMMusteriler fr = new FRMMusteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ARAL HOTEL KAYIT UYGULAMASI / 2023");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMOdalar fr = new FRMOdalar();
            fr.Show();
        }

        private void FRMAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text= DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRMGelirGider fr = new FRMGelirGider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FRMStoklar fr = new FRMStoklar();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FRMRadyoDinle fr = new FRMRadyoDinle();
            fr.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FRMGazeteler fr = new FRMGazeteler();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FRMMesajlar fr = new FRMMesajlar();
            fr.Show();
        }
    }
}
