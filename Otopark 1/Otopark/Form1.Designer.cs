namespace Otopark
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtArabaSayisi = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmSıraNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmArabaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCıkısSüresi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIslemTamam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.clm2SıraNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm2ArabaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm2CikisSuresi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm2IslemTamam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.clmArabno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmKazanc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFifoIslemSureleriOrt = new System.Windows.Forms.Label();
            this.lblOncelikliIslemSureleriOrt = new System.Windows.Forms.Label();
            this.lblOncelikliToplam = new System.Windows.Forms.Label();
            this.lblFifoToplam = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOrtFark = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblYuzde = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araba Sayısı Giriniz:";
            // 
            // txtArabaSayisi
            // 
            this.txtArabaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArabaSayisi.Location = new System.Drawing.Point(229, 55);
            this.txtArabaSayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArabaSayisi.Name = "txtArabaSayisi";
            this.txtArabaSayisi.Size = new System.Drawing.Size(132, 26);
            this.txtArabaSayisi.TabIndex = 1;
            this.txtArabaSayisi.Text = "0";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(229, 102);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(133, 57);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSıraNo,
            this.clmArabaNo,
            this.clmCıkısSüresi,
            this.clmIslemTamam});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(385, 102);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(720, 323);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmSıraNo
            // 
            this.clmSıraNo.Text = "Sıra No";
            this.clmSıraNo.Width = 69;
            // 
            // clmArabaNo
            // 
            this.clmArabaNo.Text = "Araba Numarası";
            this.clmArabaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmArabaNo.Width = 150;
            // 
            // clmCıkısSüresi
            // 
            this.clmCıkısSüresi.Text = "Çıkış Süresi";
            this.clmCıkısSüresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCıkısSüresi.Width = 129;
            // 
            // clmIslemTamam
            // 
            this.clmIslemTamam.Text = "İşlem Tamamlanma Süresi";
            this.clmIslemTamam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmIslemTamam.Width = 181;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm2SıraNo,
            this.clm2ArabaNo,
            this.clm2CikisSuresi,
            this.clm2IslemTamam});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(1115, 102);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(692, 323);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // clm2SıraNo
            // 
            this.clm2SıraNo.Text = "Sıra No";
            // 
            // clm2ArabaNo
            // 
            this.clm2ArabaNo.Text = "Araba Numarası";
            this.clm2ArabaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm2ArabaNo.Width = 182;
            // 
            // clm2CikisSuresi
            // 
            this.clm2CikisSuresi.Text = "Çıkış Süresi";
            this.clm2CikisSuresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm2CikisSuresi.Width = 131;
            // 
            // clm2IslemTamam
            // 
            this.clm2IslemTamam.Text = "İşlem Tamamlanma Süresi";
            this.clm2IslemTamam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm2IslemTamam.Width = 140;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmArabno,
            this.clmKazanc});
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(861, 497);
            this.listView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(384, 142);
            this.listView3.TabIndex = 5;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // clmArabno
            // 
            this.clmArabno.Text = "Araba Numarası";
            this.clmArabno.Width = 146;
            // 
            // clmKazanc
            // 
            this.clmKazanc.Text = "Kazanç";
            this.clmKazanc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmKazanc.Width = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1352, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Öncelikli Araç Kuyruğu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Turquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(600, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "FİFO Araç Kuyruğu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Turquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(931, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kazançlı Araçlar Listesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Turquoise;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 527);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fifo İşlem Süreleri Ortalaması:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Turquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 567);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Oncelikli İşlem Süreleri Ortalaması:";
            // 
            // lblFifoIslemSureleriOrt
            // 
            this.lblFifoIslemSureleriOrt.AutoSize = true;
            this.lblFifoIslemSureleriOrt.BackColor = System.Drawing.Color.Turquoise;
            this.lblFifoIslemSureleriOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFifoIslemSureleriOrt.Location = new System.Drawing.Point(339, 527);
            this.lblFifoIslemSureleriOrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFifoIslemSureleriOrt.Name = "lblFifoIslemSureleriOrt";
            this.lblFifoIslemSureleriOrt.Size = new System.Drawing.Size(18, 20);
            this.lblFifoIslemSureleriOrt.TabIndex = 11;
            this.lblFifoIslemSureleriOrt.Text = "0";
            // 
            // lblOncelikliIslemSureleriOrt
            // 
            this.lblOncelikliIslemSureleriOrt.AutoSize = true;
            this.lblOncelikliIslemSureleriOrt.BackColor = System.Drawing.Color.Turquoise;
            this.lblOncelikliIslemSureleriOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOncelikliIslemSureleriOrt.Location = new System.Drawing.Point(339, 567);
            this.lblOncelikliIslemSureleriOrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOncelikliIslemSureleriOrt.Name = "lblOncelikliIslemSureleriOrt";
            this.lblOncelikliIslemSureleriOrt.Size = new System.Drawing.Size(18, 20);
            this.lblOncelikliIslemSureleriOrt.TabIndex = 12;
            this.lblOncelikliIslemSureleriOrt.Text = "0";
            // 
            // lblOncelikliToplam
            // 
            this.lblOncelikliToplam.AutoSize = true;
            this.lblOncelikliToplam.BackColor = System.Drawing.Color.Turquoise;
            this.lblOncelikliToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOncelikliToplam.Location = new System.Drawing.Point(339, 486);
            this.lblOncelikliToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOncelikliToplam.Name = "lblOncelikliToplam";
            this.lblOncelikliToplam.Size = new System.Drawing.Size(18, 20);
            this.lblOncelikliToplam.TabIndex = 16;
            this.lblOncelikliToplam.Text = "0";
            // 
            // lblFifoToplam
            // 
            this.lblFifoToplam.AutoSize = true;
            this.lblFifoToplam.BackColor = System.Drawing.Color.Turquoise;
            this.lblFifoToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFifoToplam.Location = new System.Drawing.Point(339, 446);
            this.lblFifoToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFifoToplam.Name = "lblFifoToplam";
            this.lblFifoToplam.Size = new System.Drawing.Size(18, 20);
            this.lblFifoToplam.TabIndex = 15;
            this.lblFifoToplam.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Turquoise;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(41, 486);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Oncelikli İşlem Süreleri Toplamı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Turquoise;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(41, 446);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fifo İşlem Süreleri Toplamı:";
            // 
            // lblOrtFark
            // 
            this.lblOrtFark.AutoSize = true;
            this.lblOrtFark.BackColor = System.Drawing.Color.Turquoise;
            this.lblOrtFark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtFark.Location = new System.Drawing.Point(406, 602);
            this.lblOrtFark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrtFark.Name = "lblOrtFark";
            this.lblOrtFark.Size = new System.Drawing.Size(18, 20);
            this.lblOrtFark.TabIndex = 19;
            this.lblOrtFark.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Turquoise;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(41, 602);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(290, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "İşlem Sürelerinin Ortalamasının Farkı:";
            // 
            // lblYuzde
            // 
            this.lblYuzde.AutoSize = true;
            this.lblYuzde.BackColor = System.Drawing.Color.Turquoise;
            this.lblYuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuzde.Location = new System.Drawing.Point(449, 635);
            this.lblYuzde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(18, 20);
            this.lblYuzde.TabIndex = 21;
            this.lblYuzde.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Turquoise;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(41, 635);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(357, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "İşlem Sürelerinin Ortalamasının Yüzdelik Farkı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1833, 789);
            this.Controls.Add(this.lblYuzde);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblOrtFark);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblOncelikliToplam);
            this.Controls.Add(this.lblFifoToplam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblOncelikliIslemSureleriOrt);
            this.Controls.Add(this.lblFifoIslemSureleriOrt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtArabaSayisi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "HSM Otopark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArabaSayisi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader clmSıraNo;
        private System.Windows.Forms.ColumnHeader clmArabaNo;
        private System.Windows.Forms.ColumnHeader clmCıkısSüresi;
        private System.Windows.Forms.ColumnHeader clm2SıraNo;
        private System.Windows.Forms.ColumnHeader clm2ArabaNo;
        private System.Windows.Forms.ColumnHeader clm2CikisSuresi;
        private System.Windows.Forms.ColumnHeader clmIslemTamam;
        private System.Windows.Forms.ColumnHeader clm2IslemTamam;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader clmArabno;
        private System.Windows.Forms.ColumnHeader clmKazanc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFifoIslemSureleriOrt;
        private System.Windows.Forms.Label lblOncelikliIslemSureleriOrt;
        private System.Windows.Forms.Label lblOncelikliToplam;
        private System.Windows.Forms.Label lblFifoToplam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblOrtFark;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblYuzde;
        private System.Windows.Forms.Label label8;
    }
}

