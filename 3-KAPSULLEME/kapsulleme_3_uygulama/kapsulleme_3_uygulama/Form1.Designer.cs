namespace kapsulleme_3_uygulama
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCocukYardimUcreti = new System.Windows.Forms.Button();
            this.btnParcaUcreti = new System.Windows.Forms.Button();
            this.btnMaasGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(203, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(203, 203);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(203, 236);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Maaş Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Çocuk Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parça Sayısı:";
            // 
            // btnCocukYardimUcreti
            // 
            this.btnCocukYardimUcreti.Location = new System.Drawing.Point(64, 172);
            this.btnCocukYardimUcreti.Name = "btnCocukYardimUcreti";
            this.btnCocukYardimUcreti.Size = new System.Drawing.Size(118, 27);
            this.btnCocukYardimUcreti.TabIndex = 9;
            this.btnCocukYardimUcreti.Text = "Çocuk Yardım Ücreti";
            this.btnCocukYardimUcreti.UseVisualStyleBackColor = true;
            this.btnCocukYardimUcreti.Click += new System.EventHandler(this.btnCocukYardimUcreti_Click);
            // 
            // btnParcaUcreti
            // 
            this.btnParcaUcreti.Location = new System.Drawing.Point(64, 203);
            this.btnParcaUcreti.Name = "btnParcaUcreti";
            this.btnParcaUcreti.Size = new System.Drawing.Size(118, 27);
            this.btnParcaUcreti.TabIndex = 10;
            this.btnParcaUcreti.Text = "Parça Ücreti";
            this.btnParcaUcreti.UseVisualStyleBackColor = true;
            this.btnParcaUcreti.Click += new System.EventHandler(this.btnParcaUcreti_Click);
            // 
            // btnMaasGoster
            // 
            this.btnMaasGoster.Location = new System.Drawing.Point(64, 236);
            this.btnMaasGoster.Name = "btnMaasGoster";
            this.btnMaasGoster.Size = new System.Drawing.Size(118, 27);
            this.btnMaasGoster.TabIndex = 11;
            this.btnMaasGoster.Text = "Toplam Maaş";
            this.btnMaasGoster.UseVisualStyleBackColor = true;
            this.btnMaasGoster.Click += new System.EventHandler(this.btnMaasGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 318);
            this.Controls.Add(this.btnMaasGoster);
            this.Controls.Add(this.btnParcaUcreti);
            this.Controls.Add(this.btnCocukYardimUcreti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCocukYardimUcreti;
        private System.Windows.Forms.Button btnParcaUcreti;
        private System.Windows.Forms.Button btnMaasGoster;
    }
}

