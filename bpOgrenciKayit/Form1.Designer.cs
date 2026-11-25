namespace bpOgrenciKayit
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Button butEkle;
        private System.Windows.Forms.Button butSil;
        private System.Windows.Forms.Button butGuncelle;
        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private System.Windows.Forms.GroupBox grpOgrenciBilgileri;

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
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblBolum = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.butEkle = new System.Windows.Forms.Button();
            this.butSil = new System.Windows.Forms.Button();
            this.butGuncelle = new System.Windows.Forms.Button();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.grpOgrenciBilgileri = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.grpOgrenciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgrenciBilgileri
            // 
            this.grpOgrenciBilgileri.Controls.Add(this.lblAdi);
            this.grpOgrenciBilgileri.Controls.Add(this.txtAdi);
            this.grpOgrenciBilgileri.Controls.Add(this.lblSoyadi);
            this.grpOgrenciBilgileri.Controls.Add(this.txtSoyadi);
            this.grpOgrenciBilgileri.Controls.Add(this.lblBolum);
            this.grpOgrenciBilgileri.Controls.Add(this.cmbBolum);
            this.grpOgrenciBilgileri.Controls.Add(this.butEkle);
            this.grpOgrenciBilgileri.Controls.Add(this.butGuncelle);
            this.grpOgrenciBilgileri.Controls.Add(this.butSil);
            this.grpOgrenciBilgileri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpOgrenciBilgileri.Location = new System.Drawing.Point(20, 15);
            this.grpOgrenciBilgileri.Name = "grpOgrenciBilgileri";
            this.grpOgrenciBilgileri.Size = new System.Drawing.Size(560, 185);
            this.grpOgrenciBilgileri.TabIndex = 0;
            this.grpOgrenciBilgileri.TabStop = false;
            this.grpOgrenciBilgileri.Text = "Öğrenci Kayıt Bilgileri";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(25, 38);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(34, 19);
            this.lblAdi.TabIndex = 0;
            this.lblAdi.Text = "Adı:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(110, 35);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(260, 25);
            this.txtAdi.TabIndex = 1;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(25, 83);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(54, 19);
            this.lblSoyadi.TabIndex = 2;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(110, 80);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(260, 25);
            this.txtSoyadi.TabIndex = 3;
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(25, 128);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(53, 19);
            this.lblBolum.TabIndex = 4;
            this.lblBolum.Text = "Bölüm:";
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Items.AddRange(new object[] {
            "Bilgisayar Programcılığı",
            "Bilgisayar Mühendisliği",
            "Yönetim Bilişim Sistemleri",
            "Elektrik-Elektronik Mühendisliği",
            "Makine Mühendisliği",
            "İnşaat Mühendisliği"});
            this.cmbBolum.Location = new System.Drawing.Point(110, 125);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(260, 25);
            this.cmbBolum.TabIndex = 5;
            // 
            // butEkle
            // 
            this.butEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.butEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEkle.ForeColor = System.Drawing.Color.White;
            this.butEkle.Location = new System.Drawing.Point(400, 33);
            this.butEkle.Name = "butEkle";
            this.butEkle.Size = new System.Drawing.Size(135, 34);
            this.butEkle.TabIndex = 6;
            this.butEkle.Text = "Ekle";
            this.butEkle.UseVisualStyleBackColor = false;
            this.butEkle.Click += new System.EventHandler(this.butEkle_Click);
            // 
            // butGuncelle
            // 
            this.butGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.butGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGuncelle.ForeColor = System.Drawing.Color.White;
            this.butGuncelle.Location = new System.Drawing.Point(400, 77);
            this.butGuncelle.Name = "butGuncelle";
            this.butGuncelle.Size = new System.Drawing.Size(135, 34);
            this.butGuncelle.TabIndex = 7;
            this.butGuncelle.Text = "Güncelle";
            this.butGuncelle.UseVisualStyleBackColor = false;
            this.butGuncelle.Click += new System.EventHandler(this.butGuncelle_Click);
            // 
            // butSil
            // 
            this.butSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.butSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSil.ForeColor = System.Drawing.Color.White;
            this.butSil.Location = new System.Drawing.Point(400, 121);
            this.butSil.Name = "butSil";
            this.butSil.Size = new System.Drawing.Size(135, 34);
            this.butSil.TabIndex = 8;
            this.butSil.Text = "Sil";
            this.butSil.UseVisualStyleBackColor = false;
            this.butSil.Click += new System.EventHandler(this.butSil_Click);
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.AllowUserToAddRows = false;
            this.dgvOgrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Location = new System.Drawing.Point(20, 215);
            this.dgvOgrenciler.MultiSelect = false;
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.ReadOnly = true;
            this.dgvOgrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgrenciler.Size = new System.Drawing.Size(560, 235);
            this.dgvOgrenciler.TabIndex = 1;
            this.dgvOgrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciler_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.grpOgrenciBilgileri);
            this.Controls.Add(this.dgvOgrenciler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt Otomasyonu (bpOgrenciKayit)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.grpOgrenciBilgileri.ResumeLayout(false);
            this.grpOgrenciBilgileri.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
