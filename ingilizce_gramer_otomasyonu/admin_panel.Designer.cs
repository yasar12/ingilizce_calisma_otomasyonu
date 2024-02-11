namespace ingilizce_gramer_otomasyonu
{
    partial class admin_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_panel));
            this.kelime_ekle = new System.Windows.Forms.Button();
            this.kelime = new System.Windows.Forms.TextBox();
            this.anlami = new System.Windows.Forms.TextBox();
            this.ikinciAnlami = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soru = new System.Windows.Forms.TextBox();
            this.cevapA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cevapB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cevapC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cevapD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dogruCevap = new System.Windows.Forms.TextBox();
            this.soru_ekle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.soruSeviyesi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.seviyesi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.kullaniciadi = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // kelime_ekle
            // 
            this.kelime_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelime_ekle.Location = new System.Drawing.Point(90, 213);
            this.kelime_ekle.Name = "kelime_ekle";
            this.kelime_ekle.Size = new System.Drawing.Size(126, 36);
            this.kelime_ekle.TabIndex = 0;
            this.kelime_ekle.Text = "Kelimeyi ekle";
            this.kelime_ekle.UseVisualStyleBackColor = true;
            this.kelime_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // kelime
            // 
            this.kelime.Location = new System.Drawing.Point(103, 56);
            this.kelime.Name = "kelime";
            this.kelime.Size = new System.Drawing.Size(100, 20);
            this.kelime.TabIndex = 1;
            // 
            // anlami
            // 
            this.anlami.Location = new System.Drawing.Point(103, 92);
            this.anlami.Name = "anlami";
            this.anlami.Size = new System.Drawing.Size(100, 20);
            this.anlami.TabIndex = 2;
            // 
            // ikinciAnlami
            // 
            this.ikinciAnlami.Location = new System.Drawing.Point(103, 134);
            this.ikinciAnlami.Name = "ikinciAnlami";
            this.ikinciAnlami.Size = new System.Drawing.Size(100, 20);
            this.ikinciAnlami.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kelime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anlamı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ikinci anlamı";
            // 
            // soru
            // 
            this.soru.Location = new System.Drawing.Point(86, 56);
            this.soru.Multiline = true;
            this.soru.Name = "soru";
            this.soru.Size = new System.Drawing.Size(293, 171);
            this.soru.TabIndex = 7;
            // 
            // cevapA
            // 
            this.cevapA.Location = new System.Drawing.Point(189, 245);
            this.cevapA.Name = "cevapA";
            this.cevapA.Size = new System.Drawing.Size(100, 20);
            this.cevapA.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Soru";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cevap A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cevap B:";
            // 
            // cevapB
            // 
            this.cevapB.Location = new System.Drawing.Point(189, 281);
            this.cevapB.Name = "cevapB";
            this.cevapB.Size = new System.Drawing.Size(100, 20);
            this.cevapB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cevap C:";
            // 
            // cevapC
            // 
            this.cevapC.Location = new System.Drawing.Point(189, 318);
            this.cevapC.Name = "cevapC";
            this.cevapC.Size = new System.Drawing.Size(100, 20);
            this.cevapC.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cevap D:";
            // 
            // cevapD
            // 
            this.cevapD.Location = new System.Drawing.Point(189, 356);
            this.cevapD.Name = "cevapD";
            this.cevapD.Size = new System.Drawing.Size(100, 20);
            this.cevapD.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Dogru Cevap :";
            // 
            // dogruCevap
            // 
            this.dogruCevap.Location = new System.Drawing.Point(189, 400);
            this.dogruCevap.Name = "dogruCevap";
            this.dogruCevap.Size = new System.Drawing.Size(100, 20);
            this.dogruCevap.TabIndex = 17;
            // 
            // soru_ekle
            // 
            this.soru_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soru_ekle.Location = new System.Drawing.Point(189, 484);
            this.soru_ekle.Name = "soru_ekle";
            this.soru_ekle.Size = new System.Drawing.Size(109, 41);
            this.soru_ekle.TabIndex = 19;
            this.soru_ekle.Text = "Soruyu ekle";
            this.soru_ekle.UseVisualStyleBackColor = true;
            this.soru_ekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Soru Seviyesi :";
            // 
            // soruSeviyesi
            // 
            this.soruSeviyesi.Location = new System.Drawing.Point(189, 436);
            this.soruSeviyesi.Name = "soruSeviyesi";
            this.soruSeviyesi.Size = new System.Drawing.Size(100, 20);
            this.soruSeviyesi.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.seviyesi);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.kelime);
            this.panel1.Controls.Add(this.kelime_ekle);
            this.panel1.Controls.Add(this.anlami);
            this.panel1.Controls.Add(this.ikinciAnlami);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(439, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 278);
            this.panel1.TabIndex = 22;
            // 
            // seviyesi
            // 
            this.seviyesi.Location = new System.Drawing.Point(103, 170);
            this.seviyesi.Name = "seviyesi";
            this.seviyesi.Size = new System.Drawing.Size(100, 20);
            this.seviyesi.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Seviyesi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(56, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 31);
            this.label12.TabIndex = 23;
            this.label12.Text = "kelime ekle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.soru);
            this.panel2.Controls.Add(this.cevapA);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.soruSeviyesi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.soru_ekle);
            this.panel2.Controls.Add(this.cevapB);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dogruCevap);
            this.panel2.Controls.Add(this.cevapC);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cevapD);
            this.panel2.Location = new System.Drawing.Point(15, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 622);
            this.panel2.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(158, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 31);
            this.label11.TabIndex = 22;
            this.label11.Text = "Soru Ekle";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 34);
            this.panel3.TabIndex = 24;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1008, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 29);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 714);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uygulama İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kullanıcı İşlemleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.kullaniciadi);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.sifre);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(29, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 572);
            this.panel4.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(260, 31);
            this.label15.TabIndex = 23;
            this.label15.Text = "Kullanıcı oluşturma";
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.Location = new System.Drawing.Point(140, 75);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.kullaniciadi.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(140, 111);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(100, 20);
            this.sifre.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 24);
            this.label16.TabIndex = 4;
            this.label16.Text = "Kullanıcı Adı :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(87, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 24);
            this.label17.TabIndex = 5;
            this.label17.Text = "Şifre";
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 766);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "admin_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kelime_ekle;
        private System.Windows.Forms.TextBox kelime;
        private System.Windows.Forms.TextBox anlami;
        private System.Windows.Forms.TextBox ikinciAnlami;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soru;
        private System.Windows.Forms.TextBox cevapA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cevapB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cevapC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cevapD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dogruCevap;
        private System.Windows.Forms.Button soru_ekle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox soruSeviyesi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox seviyesi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox kullaniciadi;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}