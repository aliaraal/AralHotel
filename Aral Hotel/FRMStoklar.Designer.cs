namespace Aral_Hotel
{
    partial class FRMStoklar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTGıdalar = new System.Windows.Forms.TextBox();
            this.TXTIcecekler = new System.Windows.Forms.TextBox();
            this.TXTAtıstırmalıklar = new System.Windows.Forms.TextBox();
            this.BTNKaydet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.GIDALAR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICECEKLER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ATISTIRMALIKLAR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TXTSu = new System.Windows.Forms.TextBox();
            this.TXTElektirik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTInternet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(51, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIDA TUTARI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(32, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ICECEK TUTARI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(4, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ATISTIRMALIKLAR:";
            // 
            // TXTGıdalar
            // 
            this.TXTGıdalar.Location = new System.Drawing.Point(194, 75);
            this.TXTGıdalar.Name = "TXTGıdalar";
            this.TXTGıdalar.Size = new System.Drawing.Size(175, 20);
            this.TXTGıdalar.TabIndex = 3;
            // 
            // TXTIcecekler
            // 
            this.TXTIcecekler.Location = new System.Drawing.Point(194, 114);
            this.TXTIcecekler.Name = "TXTIcecekler";
            this.TXTIcecekler.Size = new System.Drawing.Size(175, 20);
            this.TXTIcecekler.TabIndex = 4;
            // 
            // TXTAtıstırmalıklar
            // 
            this.TXTAtıstırmalıklar.Location = new System.Drawing.Point(194, 156);
            this.TXTAtıstırmalıklar.Name = "TXTAtıstırmalıklar";
            this.TXTAtıstırmalıklar.Size = new System.Drawing.Size(175, 20);
            this.TXTAtıstırmalıklar.TabIndex = 5;
            // 
            // BTNKaydet
            // 
            this.BTNKaydet.BackColor = System.Drawing.Color.Yellow;
            this.BTNKaydet.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNKaydet.Location = new System.Drawing.Point(219, 222);
            this.BTNKaydet.Name = "BTNKaydet";
            this.BTNKaydet.Size = new System.Drawing.Size(130, 25);
            this.BTNKaydet.TabIndex = 13;
            this.BTNKaydet.Text = "KAYDET";
            this.BTNKaydet.UseVisualStyleBackColor = false;
            this.BTNKaydet.Click += new System.EventHandler(this.BTNKaydet_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GIDALAR,
            this.ICECEKLER,
            this.ATISTIRMALIKLAR});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 310);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(377, 128);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // GIDALAR
            // 
            this.GIDALAR.Text = "GIDALAR";
            this.GIDALAR.Width = 256;
            // 
            // ICECEKLER
            // 
            this.ICECEKLER.Text = "ICECEKLER";
            this.ICECEKLER.Width = 303;
            // 
            // ATISTIRMALIKLAR
            // 
            this.ATISTIRMALIKLAR.Text = "ATISTIRMALIKLAR";
            this.ATISTIRMALIKLAR.Width = 269;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(430, 310);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(358, 128);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ELEKTIRIK";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SU";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "INTERNET";
            this.columnHeader3.Width = 269;
            // 
            // TXTSu
            // 
            this.TXTSu.Location = new System.Drawing.Point(593, 114);
            this.TXTSu.Name = "TXTSu";
            this.TXTSu.Size = new System.Drawing.Size(175, 20);
            this.TXTSu.TabIndex = 19;
            // 
            // TXTElektirik
            // 
            this.TXTElektirik.Location = new System.Drawing.Point(593, 75);
            this.TXTElektirik.Name = "TXTElektirik";
            this.TXTElektirik.Size = new System.Drawing.Size(175, 20);
            this.TXTElektirik.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(538, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "SU:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(461, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "ELEKTIRIK:";
            // 
            // TXTInternet
            // 
            this.TXTInternet.Location = new System.Drawing.Point(593, 156);
            this.TXTInternet.Name = "TXTInternet";
            this.TXTInternet.Size = new System.Drawing.Size(175, 20);
            this.TXTInternet.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(469, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "INTERNET:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(615, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 25);
            this.button1.TabIndex = 25;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXTInternet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.TXTSu);
            this.Controls.Add(this.TXTElektirik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BTNKaydet);
            this.Controls.Add(this.TXTAtıstırmalıklar);
            this.Controls.Add(this.TXTIcecekler);
            this.Controls.Add(this.TXTGıdalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMStoklar";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.FRMStoklar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTGıdalar;
        private System.Windows.Forms.TextBox TXTIcecekler;
        private System.Windows.Forms.TextBox TXTAtıstırmalıklar;
        private System.Windows.Forms.Button BTNKaydet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader GIDALAR;
        private System.Windows.Forms.ColumnHeader ICECEKLER;
        private System.Windows.Forms.ColumnHeader ATISTIRMALIKLAR;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox TXTSu;
        private System.Windows.Forms.TextBox TXTElektirik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTInternet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}