namespace PersonelEntities
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTxtid = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtAd = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtSoyad = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtSehir = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtYas = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtDurum = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtMaas = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialBtnGuncel = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(28, 147);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(18, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Id";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(28, 220);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(25, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Ad";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(28, 297);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Soyad";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.White;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(28, 383);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(52, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Şehir ";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(386, 368);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(34, 24);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Yaş";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(386, 258);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(54, 24);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Görev";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(386, 147);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(51, 24);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Maaş";
            // 
            // materialTxtid
            // 
            this.materialTxtid.AnimateReadOnly = false;
            this.materialTxtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialTxtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtid.Depth = 0;
            this.materialTxtid.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtid.LeadingIcon = null;
            this.materialTxtid.Location = new System.Drawing.Point(106, 131);
            this.materialTxtid.MaxLength = 50;
            this.materialTxtid.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtid.Multiline = false;
            this.materialTxtid.Name = "materialTxtid";
            this.materialTxtid.Size = new System.Drawing.Size(191, 50);
            this.materialTxtid.TabIndex = 7;
            this.materialTxtid.Text = "";
            this.materialTxtid.TrailingIcon = null;
            // 
            // materialTxtAd
            // 
            this.materialTxtAd.AnimateReadOnly = false;
            this.materialTxtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialTxtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtAd.Depth = 0;
            this.materialTxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtAd.LeadingIcon = null;
            this.materialTxtAd.Location = new System.Drawing.Point(106, 201);
            this.materialTxtAd.MaxLength = 50;
            this.materialTxtAd.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtAd.Multiline = false;
            this.materialTxtAd.Name = "materialTxtAd";
            this.materialTxtAd.Size = new System.Drawing.Size(191, 50);
            this.materialTxtAd.TabIndex = 8;
            this.materialTxtAd.Text = "";
            this.materialTxtAd.TrailingIcon = null;
            // 
            // materialTxtSoyad
            // 
            this.materialTxtSoyad.AnimateReadOnly = false;
            this.materialTxtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialTxtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtSoyad.Depth = 0;
            this.materialTxtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtSoyad.LeadingIcon = null;
            this.materialTxtSoyad.Location = new System.Drawing.Point(106, 284);
            this.materialTxtSoyad.MaxLength = 50;
            this.materialTxtSoyad.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtSoyad.Multiline = false;
            this.materialTxtSoyad.Name = "materialTxtSoyad";
            this.materialTxtSoyad.Size = new System.Drawing.Size(191, 50);
            this.materialTxtSoyad.TabIndex = 9;
            this.materialTxtSoyad.Text = "";
            this.materialTxtSoyad.TrailingIcon = null;
            // 
            // materialTxtSehir
            // 
            this.materialTxtSehir.AnimateReadOnly = false;
            this.materialTxtSehir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialTxtSehir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtSehir.Depth = 0;
            this.materialTxtSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtSehir.LeadingIcon = null;
            this.materialTxtSehir.Location = new System.Drawing.Point(106, 368);
            this.materialTxtSehir.MaxLength = 50;
            this.materialTxtSehir.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtSehir.Multiline = false;
            this.materialTxtSehir.Name = "materialTxtSehir";
            this.materialTxtSehir.Size = new System.Drawing.Size(191, 50);
            this.materialTxtSehir.TabIndex = 10;
            this.materialTxtSehir.Text = "";
            this.materialTxtSehir.TrailingIcon = null;
            // 
            // materialTxtYas
            // 
            this.materialTxtYas.AnimateReadOnly = false;
            this.materialTxtYas.BackColor = System.Drawing.SystemColors.Window;
            this.materialTxtYas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtYas.Depth = 0;
            this.materialTxtYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtYas.LeadingIcon = null;
            this.materialTxtYas.Location = new System.Drawing.Point(482, 352);
            this.materialTxtYas.MaxLength = 50;
            this.materialTxtYas.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtYas.Multiline = false;
            this.materialTxtYas.Name = "materialTxtYas";
            this.materialTxtYas.Size = new System.Drawing.Size(191, 50);
            this.materialTxtYas.TabIndex = 11;
            this.materialTxtYas.Text = "";
            this.materialTxtYas.TrailingIcon = null;
            // 
            // materialTxtDurum
            // 
            this.materialTxtDurum.AnimateReadOnly = false;
            this.materialTxtDurum.BackColor = System.Drawing.SystemColors.Window;
            this.materialTxtDurum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtDurum.Depth = 0;
            this.materialTxtDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtDurum.LeadingIcon = null;
            this.materialTxtDurum.Location = new System.Drawing.Point(482, 237);
            this.materialTxtDurum.MaxLength = 50;
            this.materialTxtDurum.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtDurum.Multiline = false;
            this.materialTxtDurum.Name = "materialTxtDurum";
            this.materialTxtDurum.Size = new System.Drawing.Size(191, 50);
            this.materialTxtDurum.TabIndex = 12;
            this.materialTxtDurum.Text = "";
            this.materialTxtDurum.TrailingIcon = null;
            // 
            // materialTxtMaas
            // 
            this.materialTxtMaas.AnimateReadOnly = false;
            this.materialTxtMaas.BackColor = System.Drawing.SystemColors.Window;
            this.materialTxtMaas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtMaas.Depth = 0;
            this.materialTxtMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtMaas.LeadingIcon = null;
            this.materialTxtMaas.Location = new System.Drawing.Point(482, 130);
            this.materialTxtMaas.MaxLength = 50;
            this.materialTxtMaas.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtMaas.Multiline = false;
            this.materialTxtMaas.Name = "materialTxtMaas";
            this.materialTxtMaas.Size = new System.Drawing.Size(191, 50);
            this.materialTxtMaas.TabIndex = 13;
            this.materialTxtMaas.Text = "";
            this.materialTxtMaas.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(779, 306);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 57);
            this.materialButton1.TabIndex = 14;
            this.materialButton1.Text = "Görüntüle";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 473);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 196);
            this.dataGridView1.TabIndex = 15;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(779, 220);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(158, 57);
            this.materialButton2.TabIndex = 16;
            this.materialButton2.Text = " Ekle";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(779, 405);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(158, 59);
            this.materialButton3.TabIndex = 17;
            this.materialButton3.Text = "Sil";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialBtnGuncel
            // 
            this.materialBtnGuncel.AutoSize = false;
            this.materialBtnGuncel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnGuncel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnGuncel.Depth = 0;
            this.materialBtnGuncel.HighEmphasis = true;
            this.materialBtnGuncel.Icon = null;
            this.materialBtnGuncel.Location = new System.Drawing.Point(779, 121);
            this.materialBtnGuncel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnGuncel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnGuncel.Name = "materialBtnGuncel";
            this.materialBtnGuncel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnGuncel.Size = new System.Drawing.Size(158, 59);
            this.materialBtnGuncel.TabIndex = 18;
            this.materialBtnGuncel.Text = "Güncelle";
            this.materialBtnGuncel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnGuncel.UseAccentColor = false;
            this.materialBtnGuncel.UseVisualStyleBackColor = false;
            this.materialBtnGuncel.Click += new System.EventHandler(this.materialBtnGuncel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(770, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(636, 80);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 20);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Githup\'a Git";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(591, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialBtnGuncel);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialTxtMaas);
            this.Controls.Add(this.materialTxtDurum);
            this.Controls.Add(this.materialTxtYas);
            this.Controls.Add(this.materialTxtSehir);
            this.Controls.Add(this.materialTxtSoyad);
            this.Controls.Add(this.materialTxtAd);
            this.Controls.Add(this.materialTxtid);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.Text = "Personel Bilgi Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox materialTxtid;
        private MaterialSkin.Controls.MaterialTextBox materialTxtAd;
        private MaterialSkin.Controls.MaterialTextBox materialTxtSoyad;
        private MaterialSkin.Controls.MaterialTextBox materialTxtSehir;
        private MaterialSkin.Controls.MaterialTextBox materialTxtYas;
        private MaterialSkin.Controls.MaterialTextBox materialTxtDurum;
        private MaterialSkin.Controls.MaterialTextBox materialTxtMaas;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialBtnGuncel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

