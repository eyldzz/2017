namespace kutuphane
{
    partial class AnaMenu
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
            this.btnUyeIslemleri = new System.Windows.Forms.Button();
            this.btnKitapIslemleri = new System.Windows.Forms.Button();
            this.btnOduncAl = new System.Windows.Forms.Button();
            this.btnKullaniciAyarlari = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUyeIslemleri
            // 
            this.btnUyeIslemleri.Location = new System.Drawing.Point(61, 40);
            this.btnUyeIslemleri.Name = "btnUyeIslemleri";
            this.btnUyeIslemleri.Size = new System.Drawing.Size(105, 23);
            this.btnUyeIslemleri.TabIndex = 0;
            this.btnUyeIslemleri.Text = "Üye İşlemleri";
            this.btnUyeIslemleri.UseVisualStyleBackColor = true;
            this.btnUyeIslemleri.Click += new System.EventHandler(this.btnUyeIslemleri_Click);
            // 
            // btnKitapIslemleri
            // 
            this.btnKitapIslemleri.Location = new System.Drawing.Point(61, 69);
            this.btnKitapIslemleri.Name = "btnKitapIslemleri";
            this.btnKitapIslemleri.Size = new System.Drawing.Size(105, 23);
            this.btnKitapIslemleri.TabIndex = 1;
            this.btnKitapIslemleri.Text = "Kitap İşlemleri";
            this.btnKitapIslemleri.UseVisualStyleBackColor = true;
            this.btnKitapIslemleri.Click += new System.EventHandler(this.btnKitapIslemleri_Click);
            // 
            // btnOduncAl
            // 
            this.btnOduncAl.Location = new System.Drawing.Point(61, 98);
            this.btnOduncAl.Name = "btnOduncAl";
            this.btnOduncAl.Size = new System.Drawing.Size(105, 23);
            this.btnOduncAl.TabIndex = 2;
            this.btnOduncAl.Text = "Ödünç Al - Ver";
            this.btnOduncAl.UseVisualStyleBackColor = true;
            this.btnOduncAl.Click += new System.EventHandler(this.btnOduncAl_Click);
            // 
            // btnKullaniciAyarlari
            // 
            this.btnKullaniciAyarlari.Location = new System.Drawing.Point(61, 127);
            this.btnKullaniciAyarlari.Name = "btnKullaniciAyarlari";
            this.btnKullaniciAyarlari.Size = new System.Drawing.Size(105, 23);
            this.btnKullaniciAyarlari.TabIndex = 3;
            this.btnKullaniciAyarlari.Text = "Kullanıcı Ayarları";
            this.btnKullaniciAyarlari.UseVisualStyleBackColor = true;
            this.btnKullaniciAyarlari.Click += new System.EventHandler(this.btnKullaniciAyarlari_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(61, 156);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(105, 21);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKullaniciAyarlari);
            this.Controls.Add(this.btnOduncAl);
            this.Controls.Add(this.btnKitapIslemleri);
            this.Controls.Add(this.btnUyeIslemleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaMenu";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUyeIslemleri;
        private System.Windows.Forms.Button btnKitapIslemleri;
        private System.Windows.Forms.Button btnOduncAl;
        private System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Button btnKullaniciAyarlari;
    }
}