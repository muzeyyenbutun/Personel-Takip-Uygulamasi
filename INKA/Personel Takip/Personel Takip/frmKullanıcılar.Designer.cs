namespace Personel_Takip
{
    partial class frmKullanıcılar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSIFRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKULLANICI_ID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKULLANICI_ADI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridKullanici = new System.Windows.Forms.DataGridView();
            this.btnYENİ = new System.Windows.Forms.Button();
            this.btnKAYDET = new System.Windows.Forms.Button();
            this.btnVazgeç = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSIFRE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKULLANICI_ID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtKULLANICI_ADI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 198);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // txtSIFRE
            // 
            this.txtSIFRE.Location = new System.Drawing.Point(128, 112);
            this.txtSIFRE.Name = "txtSIFRE";
            this.txtSIFRE.Size = new System.Drawing.Size(174, 20);
            this.txtSIFRE.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Şifre";
            // 
            // txtKULLANICI_ID
            // 
            this.txtKULLANICI_ID.Location = new System.Drawing.Point(128, 60);
            this.txtKULLANICI_ID.Name = "txtKULLANICI_ID";
            this.txtKULLANICI_ID.ReadOnly = true;
            this.txtKULLANICI_ID.Size = new System.Drawing.Size(172, 20);
            this.txtKULLANICI_ID.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Kullanıcı Id";
            // 
            // txtKULLANICI_ADI
            // 
            this.txtKULLANICI_ADI.Location = new System.Drawing.Point(128, 86);
            this.txtKULLANICI_ADI.Name = "txtKULLANICI_ADI";
            this.txtKULLANICI_ADI.Size = new System.Drawing.Size(174, 20);
            this.txtKULLANICI_ADI.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // gridKullanici
            // 
            this.gridKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKullanici.Location = new System.Drawing.Point(426, 12);
            this.gridKullanici.Name = "gridKullanici";
            this.gridKullanici.Size = new System.Drawing.Size(289, 287);
            this.gridKullanici.TabIndex = 23;
            this.gridKullanici.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridKullanici_RowEnter_1);
            // 
            // btnYENİ
            // 
            this.btnYENİ.Location = new System.Drawing.Point(41, 247);
            this.btnYENİ.Name = "btnYENİ";
            this.btnYENİ.Size = new System.Drawing.Size(87, 71);
            this.btnYENİ.TabIndex = 24;
            this.btnYENİ.Text = "Yeni";
            this.btnYENİ.UseVisualStyleBackColor = true;
            this.btnYENİ.Click += new System.EventHandler(this.BtnYENİ_Click);
            // 
            // btnKAYDET
            // 
            this.btnKAYDET.Location = new System.Drawing.Point(134, 247);
            this.btnKAYDET.Name = "btnKAYDET";
            this.btnKAYDET.Size = new System.Drawing.Size(88, 71);
            this.btnKAYDET.TabIndex = 25;
            this.btnKAYDET.Text = "Kaydet";
            this.btnKAYDET.UseVisualStyleBackColor = true;
            this.btnKAYDET.Click += new System.EventHandler(this.BtnKAYDET_Click_1);
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.Location = new System.Drawing.Point(228, 246);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(88, 72);
            this.btnVazgeç.TabIndex = 26;
            this.btnVazgeç.Text = "Vazgeç";
            this.btnVazgeç.UseVisualStyleBackColor = true;
            this.btnVazgeç.Click += new System.EventHandler(this.BtnVazgeç_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(322, 247);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 71);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click_1);
            // 
            // frmKullanıcılar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(727, 360);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgeç);
            this.Controls.Add(this.btnKAYDET);
            this.Controls.Add(this.btnYENİ);
            this.Controls.Add(this.gridKullanici);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKullanıcılar";
            this.Text = " Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.FrmKullanıcılar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSIFRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKULLANICI_ID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKULLANICI_ADI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridKullanici;
        private System.Windows.Forms.Button btnYENİ;
        private System.Windows.Forms.Button btnKAYDET;
        private System.Windows.Forms.Button btnVazgeç;
        private System.Windows.Forms.Button btnSil;
    }
}