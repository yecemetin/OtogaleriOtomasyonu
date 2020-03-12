namespace OtogaleriOtomasyonu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ruhsatNo = new System.Windows.Forms.TextBox();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.cb_marka = new System.Windows.Forms.ComboBox();
            this.cb_model = new System.Windows.Forms.ComboBox();
            this.cb_yakit = new System.Windows.Forms.ComboBox();
            this.cb_kasa = new System.Windows.Forms.ComboBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruhsat No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yakıt Tipi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kasa Tipi : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kilometre : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fiyat : ";
            // 
            // txt_ruhsatNo
            // 
            this.txt_ruhsatNo.Location = new System.Drawing.Point(364, 28);
            this.txt_ruhsatNo.Name = "txt_ruhsatNo";
            this.txt_ruhsatNo.Size = new System.Drawing.Size(163, 20);
            this.txt_ruhsatNo.TabIndex = 7;
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(364, 184);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(121, 20);
            this.txt_km.TabIndex = 8;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(364, 210);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(121, 20);
            this.txt_fiyat.TabIndex = 9;
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(533, 20);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 34);
            this.btn_ara.TabIndex = 10;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // cb_marka
            // 
            this.cb_marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_marka.FormattingEnabled = true;
            this.cb_marka.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Opel",
            "Renault",
            "Audi",
            "Mercedes",
            "BMW",
            "Ford",
            "Fiat"});
            this.cb_marka.Location = new System.Drawing.Point(364, 74);
            this.cb_marka.Name = "cb_marka";
            this.cb_marka.Size = new System.Drawing.Size(121, 21);
            this.cb_marka.TabIndex = 11;
            this.cb_marka.SelectedIndexChanged += new System.EventHandler(this.cb_marka_SelectedIndexChanged);
            // 
            // cb_model
            // 
            this.cb_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_model.FormattingEnabled = true;
            this.cb_model.Location = new System.Drawing.Point(364, 101);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(121, 21);
            this.cb_model.TabIndex = 12;
            // 
            // cb_yakit
            // 
            this.cb_yakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_yakit.FormattingEnabled = true;
            this.cb_yakit.Items.AddRange(new object[] {
            "Benzinli",
            "Dizel",
            "Benzinli-Tüplü"});
            this.cb_yakit.Location = new System.Drawing.Point(364, 129);
            this.cb_yakit.Name = "cb_yakit";
            this.cb_yakit.Size = new System.Drawing.Size(121, 21);
            this.cb_yakit.TabIndex = 13;
            // 
            // cb_kasa
            // 
            this.cb_kasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kasa.FormattingEnabled = true;
            this.cb_kasa.Items.AddRange(new object[] {
            "Sedan",
            "Hatcback"});
            this.cb_kasa.Location = new System.Drawing.Point(364, 157);
            this.cb_kasa.Name = "cb_kasa";
            this.cb_kasa.Size = new System.Drawing.Size(121, 21);
            this.cb_kasa.TabIndex = 14;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(509, 81);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(117, 43);
            this.btn_kaydet.TabIndex = 15;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(509, 179);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(117, 43);
            this.btn_guncelle.TabIndex = 16;
            this.btn_guncelle.Text = "FİYAT GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(509, 130);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(117, 43);
            this.btn_sil.TabIndex = 17;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 166);
            this.dataGridView1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(34, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "OTOGALERİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 453);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.cb_kasa);
            this.Controls.Add(this.cb_yakit);
            this.Controls.Add(this.cb_model);
            this.Controls.Add(this.cb_marka);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.txt_ruhsatNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ruhsatNo;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.ComboBox cb_marka;
        private System.Windows.Forms.ComboBox cb_model;
        private System.Windows.Forms.ComboBox cb_yakit;
        private System.Windows.Forms.ComboBox cb_kasa;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
    }
}

