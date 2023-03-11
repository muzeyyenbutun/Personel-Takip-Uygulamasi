namespace Personel_Takip
{
    partial class txtHarekettıpıAdı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtHarekettıpıAdı));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgeç = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersHarId = new System.Windows.Forms.TextBox();
            this.txtBorc = new System.Windows.Forms.TextBox();
            this.txtAlacak = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tarih = new System.Windows.Forms.DateTimePicker();
            this.cmbHareketAdı = new System.Windows.Forms.ComboBox();
            this.cmbPersonelId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnVazgeç);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 486);
            this.panel1.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(12, 251);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(126, 76);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnVazgeç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgeç.Location = new System.Drawing.Point(12, 176);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(126, 69);
            this.btnVazgeç.TabIndex = 4;
            this.btnVazgeç.Text = "VAZGEÇ";
            this.btnVazgeç.UseVisualStyleBackColor = false;
            this.btnVazgeç.Click += new System.EventHandler(this.BtnVazgeç_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(12, 89);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(126, 81);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Location = new System.Drawing.Point(12, 12);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(126, 71);
            this.btnYeni.TabIndex = 2;
            this.btnYeni.Text = "YENİ";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.BtnYeni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Hareket Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Personel Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Borç:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alacak:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hareket Adı:";
            // 
            // txtPersHarId
            // 
            this.txtPersHarId.Location = new System.Drawing.Point(261, 23);
            this.txtPersHarId.Name = "txtPersHarId";
            this.txtPersHarId.ReadOnly = true;
            this.txtPersHarId.Size = new System.Drawing.Size(317, 20);
            this.txtPersHarId.TabIndex = 11;
            // 
            // txtBorc
            // 
            this.txtBorc.Location = new System.Drawing.Point(261, 106);
            this.txtBorc.Name = "txtBorc";
            this.txtBorc.Size = new System.Drawing.Size(317, 20);
            this.txtBorc.TabIndex = 14;
            // 
            // txtAlacak
            // 
            this.txtAlacak.Location = new System.Drawing.Point(261, 135);
            this.txtAlacak.Name = "txtAlacak";
            this.txtAlacak.Size = new System.Drawing.Size(317, 20);
            this.txtAlacak.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 213);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // Tarih
            // 
            this.Tarih.Location = new System.Drawing.Point(261, 164);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(317, 20);
            this.Tarih.TabIndex = 18;
            // 
            // cmbHareketAdı
            // 
            this.cmbHareketAdı.FormattingEnabled = true;
            this.cmbHareketAdı.Location = new System.Drawing.Point(261, 52);
            this.cmbHareketAdı.Name = "cmbHareketAdı";
            this.cmbHareketAdı.Size = new System.Drawing.Size(317, 21);
            this.cmbHareketAdı.TabIndex = 19;
            // 
            // cmbPersonelId
            // 
            this.cmbPersonelId.FormattingEnabled = true;
            this.cmbPersonelId.Location = new System.Drawing.Point(261, 79);
            this.cmbPersonelId.Name = "cmbPersonelId";
            this.cmbPersonelId.Size = new System.Drawing.Size(317, 21);
            this.cmbPersonelId.TabIndex = 20;
            // 
            // txtHarekettıpıAdı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(617, 486);
            this.Controls.Add(this.cmbPersonelId);
            this.Controls.Add(this.cmbHareketAdı);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAlacak);
            this.Controls.Add(this.txtBorc);
            this.Controls.Add(this.txtPersHarId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "txtHarekettıpıAdı";
            this.Text = "Personel Hareket";
            this.Load += new System.EventHandler(this.FrmPersonelHareket_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgeç;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersHarId;
        private System.Windows.Forms.TextBox txtBorc;
        private System.Windows.Forms.TextBox txtAlacak;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker Tarih;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbHareketAdı;
        private System.Windows.Forms.ComboBox cmbPersonelId;
    }
}