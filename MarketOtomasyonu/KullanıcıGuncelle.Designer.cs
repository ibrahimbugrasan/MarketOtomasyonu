namespace MarketOtomasyonu
{
    partial class KullanıcıGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıGuncelle));
            this.dgv_kullanıcıGuncelle = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_emailG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kullanıcıAdiG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_gcG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sifreG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_bolgeG = new System.Windows.Forms.TextBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_cıkısYap = new System.Windows.Forms.Button();
            this.cmb_yetkiG = new System.Windows.Forms.ComboBox();
            this.cmb_gsG = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullanıcıGuncelle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_kullanıcıGuncelle
            // 
            this.dgv_kullanıcıGuncelle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_kullanıcıGuncelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kullanıcıGuncelle.Location = new System.Drawing.Point(0, 0);
            this.dgv_kullanıcıGuncelle.Name = "dgv_kullanıcıGuncelle";
            this.dgv_kullanıcıGuncelle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kullanıcıGuncelle.Size = new System.Drawing.Size(1067, 359);
            this.dgv_kullanıcıGuncelle.TabIndex = 0;
            this.dgv_kullanıcıGuncelle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kullanıcıGuncelle_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // txt_idG
            // 
            this.txt_idG.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idG.Location = new System.Drawing.Point(121, 396);
            this.txt_idG.Name = "txt_idG";
            this.txt_idG.Size = new System.Drawing.Size(200, 26);
            this.txt_idG.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // txt_emailG
            // 
            this.txt_emailG.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailG.Location = new System.Drawing.Point(473, 396);
            this.txt_emailG.Name = "txt_emailG";
            this.txt_emailG.Size = new System.Drawing.Size(200, 26);
            this.txt_emailG.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(705, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Güvenlik Sorusu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // txt_kullanıcıAdiG
            // 
            this.txt_kullanıcıAdiG.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kullanıcıAdiG.Location = new System.Drawing.Point(121, 465);
            this.txt_kullanıcıAdiG.Name = "txt_kullanıcıAdiG";
            this.txt_kullanıcıAdiG.Size = new System.Drawing.Size(200, 26);
            this.txt_kullanıcıAdiG.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yetki:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(705, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Güvenlik Cevabı:";
            // 
            // txt_gcG
            // 
            this.txt_gcG.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gcG.Location = new System.Drawing.Point(851, 465);
            this.txt_gcG.Name = "txt_gcG";
            this.txt_gcG.Size = new System.Drawing.Size(200, 26);
            this.txt_gcG.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Şifre:";
            // 
            // txt_sifreG
            // 
            this.txt_sifreG.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sifreG.Location = new System.Drawing.Point(121, 540);
            this.txt_sifreG.Name = "txt_sifreG";
            this.txt_sifreG.Size = new System.Drawing.Size(200, 26);
            this.txt_sifreG.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bölge:";
            // 
            // txt_bolgeG
            // 
            this.txt_bolgeG.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bolgeG.Location = new System.Drawing.Point(473, 541);
            this.txt_bolgeG.Name = "txt_bolgeG";
            this.txt_bolgeG.Size = new System.Drawing.Size(200, 26);
            this.txt_bolgeG.TabIndex = 2;
            // 
            // btn_temizle
            // 
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_temizle.ImageKey = "Oxygen-Icons.org-Oxygen-Actions-edit-clear.256.png";
            this.btn_temizle.ImageList = this.ımageList1;
            this.btn_temizle.Location = new System.Drawing.Point(888, 510);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(166, 56);
            this.btn_temizle.TabIndex = 3;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Oxygen-Icons.org-Oxygen-Actions-edit-clear.256.png");
            this.ımageList1.Images.SetKeyName(1, "Oxygen-Icons.org-Oxygen-Actions-edit-redo.256.png");
            this.ımageList1.Images.SetKeyName(2, "Colebemis-Feather-Repeat.512.png");
            this.ımageList1.Images.SetKeyName(3, "Aha-Soft-Free-3d-Glossy-Interface-Renew.64.png");
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guncelle.ImageKey = "Aha-Soft-Free-3d-Glossy-Interface-Renew.64.png";
            this.btn_guncelle.ImageList = this.ımageList1;
            this.btn_guncelle.Location = new System.Drawing.Point(709, 511);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(166, 56);
            this.btn_guncelle.TabIndex = 3;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_cıkısYap
            // 
            this.btn_cıkısYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cıkısYap.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cıkısYap.Location = new System.Drawing.Point(12, 584);
            this.btn_cıkısYap.Name = "btn_cıkısYap";
            this.btn_cıkısYap.Size = new System.Drawing.Size(39, 36);
            this.btn_cıkısYap.TabIndex = 4;
            this.btn_cıkısYap.Text = "<";
            this.btn_cıkısYap.UseVisualStyleBackColor = true;
            this.btn_cıkısYap.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmb_yetkiG
            // 
            this.cmb_yetkiG.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_yetkiG.FormattingEnabled = true;
            this.cmb_yetkiG.Location = new System.Drawing.Point(473, 465);
            this.cmb_yetkiG.Name = "cmb_yetkiG";
            this.cmb_yetkiG.Size = new System.Drawing.Size(200, 26);
            this.cmb_yetkiG.TabIndex = 5;
            // 
            // cmb_gsG
            // 
            this.cmb_gsG.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_gsG.FormattingEnabled = true;
            this.cmb_gsG.Location = new System.Drawing.Point(851, 395);
            this.cmb_gsG.Name = "cmb_gsG";
            this.cmb_gsG.Size = new System.Drawing.Size(200, 26);
            this.cmb_gsG.TabIndex = 5;
            // 
            // KullanıcıGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 632);
            this.Controls.Add(this.cmb_gsG);
            this.Controls.Add(this.cmb_yetkiG);
            this.Controls.Add(this.btn_cıkısYap);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.txt_gcG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_bolgeG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sifreG);
            this.Controls.Add(this.txt_emailG);
            this.Controls.Add(this.txt_kullanıcıAdiG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_kullanıcıGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullanıcıGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Güncelle";
            this.Load += new System.EventHandler(this.KullanıcıGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullanıcıGuncelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kullanıcıGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_emailG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kullanıcıAdiG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_gcG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sifreG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_bolgeG;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_cıkısYap;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ComboBox cmb_yetkiG;
        private System.Windows.Forms.ComboBox cmb_gsG;
    }
}