namespace Personel_Takip
{
    partial class frmPersonel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.btnYeni = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnVazgeç = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPERSONELID = new System.Windows.Forms.TextBox();
            this.txtADRES = new System.Windows.Forms.TextBox();
            this.txtTELEFON = new System.Windows.Forms.TextBox();
            this.txtEPOSTA = new System.Windows.Forms.TextBox();
            this.txtADISOYADI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAyrılısTarıhı = new System.Windows.Forms.TextBox();
            this.cmbGorevId = new System.Windows.Forms.ComboBox();
            this.chkDurumu = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDepartmanId = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GİRİŞTARİHİ = new System.Windows.Forms.DateTimePicker();
            this.txtMAAŞ = new System.Windows.Forms.TextBox();
            this.txtŞEHİR = new System.Windows.Forms.TextBox();
            this.txtİLÇE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.ImageIndex = 0;
            this.btnYeni.ImageList = this.ımageList1;
            this.btnYeni.Location = new System.Drawing.Point(9, 335);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(179, 80);
            this.btnYeni.TabIndex = 27;
            this.btnYeni.Text = "YENİ";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "yeni.png");
            this.ımageList1.Images.SetKeyName(1, "kaydet.png");
            this.ımageList1.Images.SetKeyName(2, "vazgeç.png");
            this.ımageList1.Images.SetKeyName(3, "sil.png");
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.ImageIndex = 1;
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(194, 335);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(165, 80);
            this.btnKaydet.TabIndex = 28;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVazgeç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgeç.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgeç.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVazgeç.ImageIndex = 2;
            this.btnVazgeç.ImageList = this.ımageList1;
            this.btnVazgeç.Location = new System.Drawing.Point(365, 335);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(152, 80);
            this.btnVazgeç.TabIndex = 29;
            this.btnVazgeç.Text = "VAZGEÇ";
            this.btnVazgeç.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVazgeç.UseVisualStyleBackColor = false;
            this.btnVazgeç.Click += new System.EventHandler(this.btnVazgeç_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 3;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(523, 335);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 80);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(9, 421);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 173);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.txtPERSONELID);
            this.groupBox1.Controls.Add(this.txtADRES);
            this.groupBox1.Controls.Add(this.txtTELEFON);
            this.groupBox1.Controls.Add(this.txtEPOSTA);
            this.groupBox1.Controls.Add(this.txtADISOYADI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 294);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // txtPERSONELID
            // 
            this.txtPERSONELID.Location = new System.Drawing.Point(97, 14);
            this.txtPERSONELID.Name = "txtPERSONELID";
            this.txtPERSONELID.ReadOnly = true;
            this.txtPERSONELID.Size = new System.Drawing.Size(195, 20);
            this.txtPERSONELID.TabIndex = 34;
            // 
            // txtADRES
            // 
            this.txtADRES.Location = new System.Drawing.Point(97, 155);
            this.txtADRES.Multiline = true;
            this.txtADRES.Name = "txtADRES";
            this.txtADRES.Size = new System.Drawing.Size(195, 126);
            this.txtADRES.TabIndex = 38;
            // 
            // txtTELEFON
            // 
            this.txtTELEFON.Location = new System.Drawing.Point(97, 111);
            this.txtTELEFON.Name = "txtTELEFON";
            this.txtTELEFON.Size = new System.Drawing.Size(195, 20);
            this.txtTELEFON.TabIndex = 37;
            // 
            // txtEPOSTA
            // 
            this.txtEPOSTA.Location = new System.Drawing.Point(97, 75);
            this.txtEPOSTA.Name = "txtEPOSTA";
            this.txtEPOSTA.Size = new System.Drawing.Size(195, 20);
            this.txtEPOSTA.TabIndex = 36;
            // 
            // txtADISOYADI
            // 
            this.txtADISOYADI.Location = new System.Drawing.Point(97, 44);
            this.txtADISOYADI.Name = "txtADISOYADI";
            this.txtADISOYADI.Size = new System.Drawing.Size(195, 20);
            this.txtADISOYADI.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(30, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "ADRES:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(24, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "TELEFON:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "EPOSTA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "ADI SOYADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "PERSONEL ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAyrılısTarıhı);
            this.groupBox2.Controls.Add(this.cmbGorevId);
            this.groupBox2.Controls.Add(this.chkDurumu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbDepartmanId);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.GİRİŞTARİHİ);
            this.groupBox2.Controls.Add(this.txtMAAŞ);
            this.groupBox2.Controls.Add(this.txtŞEHİR);
            this.groupBox2.Controls.Add(this.txtİLÇE);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(344, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 294);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Bilgileri";
            // 
            // txtAyrılısTarıhı
            // 
            this.txtAyrılısTarıhı.Location = new System.Drawing.Point(100, 221);
            this.txtAyrılısTarıhı.Name = "txtAyrılısTarıhı";
            this.txtAyrılısTarıhı.Size = new System.Drawing.Size(202, 20);
            this.txtAyrılısTarıhı.TabIndex = 49;
            // 
            // cmbGorevId
            // 
            this.cmbGorevId.FormattingEnabled = true;
            this.cmbGorevId.Location = new System.Drawing.Point(100, 146);
            this.cmbGorevId.Name = "cmbGorevId";
            this.cmbGorevId.Size = new System.Drawing.Size(202, 21);
            this.cmbGorevId.TabIndex = 48;
            // 
            // chkDurumu
            // 
            this.chkDurumu.AutoSize = true;
            this.chkDurumu.Location = new System.Drawing.Point(102, 263);
            this.chkDurumu.Name = "chkDurumu";
            this.chkDurumu.Size = new System.Drawing.Size(15, 14);
            this.chkDurumu.TabIndex = 47;
            this.chkDurumu.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Location = new System.Drawing.Point(37, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "DURUMU:";
            // 
            // cmbDepartmanId
            // 
            this.cmbDepartmanId.FormattingEnabled = true;
            this.cmbDepartmanId.Location = new System.Drawing.Point(102, 110);
            this.cmbDepartmanId.Name = "cmbDepartmanId";
            this.cmbDepartmanId.Size = new System.Drawing.Size(200, 21);
            this.cmbDepartmanId.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.Location = new System.Drawing.Point(4, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "AYRILIŞ TARİHİ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Location = new System.Drawing.Point(16, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "GİRİŞ TARİHİ:";
            // 
            // GİRİŞTARİHİ
            // 
            this.GİRİŞTARİHİ.Location = new System.Drawing.Point(102, 179);
            this.GİRİŞTARİHİ.Name = "GİRİŞTARİHİ";
            this.GİRİŞTARİHİ.Size = new System.Drawing.Size(200, 20);
            this.GİRİŞTARİHİ.TabIndex = 40;
            // 
            // txtMAAŞ
            // 
            this.txtMAAŞ.Location = new System.Drawing.Point(102, 81);
            this.txtMAAŞ.Name = "txtMAAŞ";
            this.txtMAAŞ.Size = new System.Drawing.Size(200, 20);
            this.txtMAAŞ.TabIndex = 35;
            // 
            // txtŞEHİR
            // 
            this.txtŞEHİR.Location = new System.Drawing.Point(102, 14);
            this.txtŞEHİR.Name = "txtŞEHİR";
            this.txtŞEHİR.Size = new System.Drawing.Size(200, 20);
            this.txtŞEHİR.TabIndex = 34;
            // 
            // txtİLÇE
            // 
            this.txtİLÇE.Location = new System.Drawing.Point(102, 47);
            this.txtİLÇE.Name = "txtİLÇE";
            this.txtİLÇE.Size = new System.Drawing.Size(200, 20);
            this.txtİLÇE.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Location = new System.Drawing.Point(32, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "GÖREV ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Location = new System.Drawing.Point(2, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "DEPARTMAN ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(54, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "MAAŞ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(61, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "İLÇE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(54, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "ŞEHİR:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgeç);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPersonel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVazgeç;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker GİRİŞTARİHİ;
        private System.Windows.Forms.TextBox txtMAAŞ;
        private System.Windows.Forms.TextBox txtŞEHİR;
        private System.Windows.Forms.TextBox txtİLÇE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPERSONELID;
        private System.Windows.Forms.TextBox txtADRES;
        private System.Windows.Forms.TextBox txtTELEFON;
        private System.Windows.Forms.TextBox txtEPOSTA;
        private System.Windows.Forms.TextBox txtADISOYADI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkDurumu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDepartmanId;
        private System.Windows.Forms.ComboBox cmbGorevId;
        private System.Windows.Forms.TextBox txtAyrılısTarıhı;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}