namespace MarketOtomasyonu
{
    partial class UrunAyarları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunAyarları));
            this.dgv_urunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ekleU = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btn_araU = new System.Windows.Forms.Button();
            this.txt_ıdAraU = new System.Windows.Forms.TextBox();
            this.txt_ıdU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_barkodkodU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_isimU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kiloU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ciroU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_silU = new System.Windows.Forms.Button();
            this.btn_guncelleU = new System.Windows.Forms.Button();
            this.btn_geriU = new System.Windows.Forms.Button();
            this.txt_fiyatU = new System.Windows.Forms.TextBox();
            this.btn_temizleU = new System.Windows.Forms.Button();
            this.dtp_otU = new System.Windows.Forms.DateTimePicker();
            this.dtp_gtU = new System.Windows.Forms.DateTimePicker();
            this.btn_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_urunler
            // 
            this.dgv_urunler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunler.Location = new System.Drawing.Point(0, 0);
            this.dgv_urunler.Name = "dgv_urunler";
            this.dgv_urunler.Size = new System.Drawing.Size(1162, 394);
            this.dgv_urunler.TabIndex = 0;
            this.dgv_urunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_urunler_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // btn_ekleU
            // 
            this.btn_ekleU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekleU.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekleU.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ekleU.ImageKey = "Custom-Icon-Design-Flatastic-1-Add-1.512.png";
            this.btn_ekleU.ImageList = this.ımageList1;
            this.btn_ekleU.Location = new System.Drawing.Point(815, 613);
            this.btn_ekleU.Name = "btn_ekleU";
            this.btn_ekleU.Size = new System.Drawing.Size(122, 35);
            this.btn_ekleU.TabIndex = 2;
            this.btn_ekleU.Text = "Ekle";
            this.btn_ekleU.UseVisualStyleBackColor = true;
            this.btn_ekleU.Click += new System.EventHandler(this.btn_ekleU_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Awicons-Vista-Artistic-Add.256.png");
            this.ımageList1.Images.SetKeyName(1, "Awicons-Vista-Artistic-Delete.256.png");
            this.ımageList1.Images.SetKeyName(2, "Custom-Icon-Design-Flatastic-1-Add-1.512.png");
            this.ımageList1.Images.SetKeyName(3, "Hopstarter-Sleek-Xp-Basic-Delete.256.png");
            this.ımageList1.Images.SetKeyName(4, "Microsoft-Fluentui-Emoji-Flat-Repeat-Button-Flat.512.png");
            this.ımageList1.Images.SetKeyName(5, "Saki-Snowish-Actions-edit-clear.128.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(854, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // btn_araU
            // 
            this.btn_araU.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_araU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_araU.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_araU.Location = new System.Drawing.Point(993, 401);
            this.btn_araU.Name = "btn_araU";
            this.btn_araU.Size = new System.Drawing.Size(75, 23);
            this.btn_araU.TabIndex = 2;
            this.btn_araU.Text = "Ara";
            this.btn_araU.UseVisualStyleBackColor = false;
            this.btn_araU.Click += new System.EventHandler(this.btn_araU_Click);
            // 
            // txt_ıdAraU
            // 
            this.txt_ıdAraU.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ıdAraU.Location = new System.Drawing.Point(887, 401);
            this.txt_ıdAraU.Name = "txt_ıdAraU";
            this.txt_ıdAraU.Size = new System.Drawing.Size(100, 22);
            this.txt_ıdAraU.TabIndex = 3;
            // 
            // txt_ıdU
            // 
            this.txt_ıdU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ıdU.Location = new System.Drawing.Point(83, 471);
            this.txt_ıdU.Name = "txt_ıdU";
            this.txt_ıdU.Size = new System.Drawing.Size(206, 26);
            this.txt_ıdU.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Barkod Kod:";
            // 
            // txt_barkodkodU
            // 
            this.txt_barkodkodU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_barkodkodU.Location = new System.Drawing.Point(525, 475);
            this.txt_barkodkodU.Name = "txt_barkodkodU";
            this.txt_barkodkodU.Size = new System.Drawing.Size(206, 26);
            this.txt_barkodkodU.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(777, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürün İsmi:";
            // 
            // txt_isimU
            // 
            this.txt_isimU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isimU.Location = new System.Drawing.Point(874, 475);
            this.txt_isimU.Name = "txt_isimU";
            this.txt_isimU.Size = new System.Drawing.Size(206, 26);
            this.txt_isimU.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kilo:";
            // 
            // txt_kiloU
            // 
            this.txt_kiloU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kiloU.Location = new System.Drawing.Point(83, 552);
            this.txt_kiloU.Name = "txt_kiloU";
            this.txt_kiloU.Size = new System.Drawing.Size(206, 26);
            this.txt_kiloU.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(822, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ciro:";
            // 
            // txt_ciroU
            // 
            this.txt_ciroU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ciroU.Location = new System.Drawing.Point(874, 552);
            this.txt_ciroU.Name = "txt_ciroU";
            this.txt_ciroU.Size = new System.Drawing.Size(206, 26);
            this.txt_ciroU.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(363, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Oluşturulma Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(358, 634);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Güncellenme Tarihi:";
            // 
            // btn_silU
            // 
            this.btn_silU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_silU.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_silU.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_silU.ImageKey = "Hopstarter-Sleek-Xp-Basic-Delete.256.png";
            this.btn_silU.ImageList = this.ımageList1;
            this.btn_silU.Location = new System.Drawing.Point(958, 613);
            this.btn_silU.Name = "btn_silU";
            this.btn_silU.Size = new System.Drawing.Size(122, 35);
            this.btn_silU.TabIndex = 2;
            this.btn_silU.Text = "Sil";
            this.btn_silU.UseVisualStyleBackColor = true;
            this.btn_silU.Click += new System.EventHandler(this.btn_silU_Click);
            // 
            // btn_guncelleU
            // 
            this.btn_guncelleU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guncelleU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelleU.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guncelleU.ImageKey = "Microsoft-Fluentui-Emoji-Flat-Repeat-Button-Flat.512.png";
            this.btn_guncelleU.ImageList = this.ımageList1;
            this.btn_guncelleU.Location = new System.Drawing.Point(815, 654);
            this.btn_guncelleU.Name = "btn_guncelleU";
            this.btn_guncelleU.Size = new System.Drawing.Size(122, 35);
            this.btn_guncelleU.TabIndex = 2;
            this.btn_guncelleU.Text = "Güncelle";
            this.btn_guncelleU.UseVisualStyleBackColor = true;
            this.btn_guncelleU.Click += new System.EventHandler(this.btn_guncelleU_Click);
            // 
            // btn_geriU
            // 
            this.btn_geriU.BackColor = System.Drawing.Color.Indigo;
            this.btn_geriU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geriU.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geriU.Location = new System.Drawing.Point(2, 400);
            this.btn_geriU.Name = "btn_geriU";
            this.btn_geriU.Size = new System.Drawing.Size(70, 42);
            this.btn_geriU.TabIndex = 2;
            this.btn_geriU.Text = "<";
            this.btn_geriU.UseVisualStyleBackColor = false;
            this.btn_geriU.Click += new System.EventHandler(this.btn_geriU_Click);
            // 
            // txt_fiyatU
            // 
            this.txt_fiyatU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_fiyatU.Location = new System.Drawing.Point(83, 634);
            this.txt_fiyatU.Name = "txt_fiyatU";
            this.txt_fiyatU.Size = new System.Drawing.Size(206, 26);
            this.txt_fiyatU.TabIndex = 3;
            // 
            // btn_temizleU
            // 
            this.btn_temizleU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_temizleU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizleU.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_temizleU.ImageKey = "Saki-Snowish-Actions-edit-clear.128.png";
            this.btn_temizleU.ImageList = this.ımageList1;
            this.btn_temizleU.Location = new System.Drawing.Point(958, 654);
            this.btn_temizleU.Name = "btn_temizleU";
            this.btn_temizleU.Size = new System.Drawing.Size(122, 35);
            this.btn_temizleU.TabIndex = 2;
            this.btn_temizleU.Text = "Temizle";
            this.btn_temizleU.UseVisualStyleBackColor = true;
            this.btn_temizleU.Click += new System.EventHandler(this.btn_temizleU_Click);
            // 
            // dtp_otU
            // 
            this.dtp_otU.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_otU.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_otU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_otU.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_otU.Location = new System.Drawing.Point(525, 552);
            this.dtp_otU.Name = "dtp_otU";
            this.dtp_otU.Size = new System.Drawing.Size(206, 26);
            this.dtp_otU.TabIndex = 4;
            // 
            // dtp_gtU
            // 
            this.dtp_gtU.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_gtU.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_gtU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_gtU.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_gtU.Location = new System.Drawing.Point(525, 632);
            this.dtp_gtU.Name = "dtp_gtU";
            this.dtp_gtU.Size = new System.Drawing.Size(206, 26);
            this.dtp_gtU.TabIndex = 4;
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_temizle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(1074, 401);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 5;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // UrunAyarları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 704);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.dtp_gtU);
            this.Controls.Add(this.dtp_otU);
            this.Controls.Add(this.txt_ciroU);
            this.Controls.Add(this.txt_isimU);
            this.Controls.Add(this.txt_barkodkodU);
            this.Controls.Add(this.txt_fiyatU);
            this.Controls.Add(this.txt_kiloU);
            this.Controls.Add(this.txt_ıdU);
            this.Controls.Add(this.txt_ıdAraU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_geriU);
            this.Controls.Add(this.btn_araU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_temizleU);
            this.Controls.Add(this.btn_silU);
            this.Controls.Add(this.btn_guncelleU);
            this.Controls.Add(this.btn_ekleU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_urunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UrunAyarları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunAyarları";
            this.Load += new System.EventHandler(this.UrunAyarları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_urunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ekleU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_araU;
        private System.Windows.Forms.TextBox txt_ıdAraU;
        private System.Windows.Forms.TextBox txt_ıdU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_barkodkodU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_isimU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kiloU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ciroU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_silU;
        private System.Windows.Forms.Button btn_guncelleU;
        private System.Windows.Forms.Button btn_geriU;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txt_fiyatU;
        private System.Windows.Forms.Button btn_temizleU;
        private System.Windows.Forms.DateTimePicker dtp_otU;
        private System.Windows.Forms.DateTimePicker dtp_gtU;
        private System.Windows.Forms.Button btn_temizle;
    }
}