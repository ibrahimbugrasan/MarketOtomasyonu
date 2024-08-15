namespace MarketOtomasyonu
{
    partial class CashierPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierPanel));
            this.btn_baklaUrunleri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_sebzeUrunleri = new System.Windows.Forms.Button();
            this.btn_EtUrunleri = new System.Windows.Forms.Button();
            this.btn_sutUrunleri = new System.Windows.Forms.Button();
            this.btn_CıkısYap = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_baklaUrunleri
            // 
            this.btn_baklaUrunleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_baklaUrunleri.ImageKey = "Thesquid.ink-Free-Flat-Sample-Jar.512.png";
            this.btn_baklaUrunleri.ImageList = this.ımageList1;
            this.btn_baklaUrunleri.Location = new System.Drawing.Point(39, 192);
            this.btn_baklaUrunleri.Name = "btn_baklaUrunleri";
            this.btn_baklaUrunleri.Size = new System.Drawing.Size(140, 124);
            this.btn_baklaUrunleri.TabIndex = 0;
            this.btn_baklaUrunleri.UseVisualStyleBackColor = true;
            this.btn_baklaUrunleri.Click += new System.EventHandler(this.btn_baklaUrunleri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "baklagil.ico");
            this.ımageList1.Images.SetKeyName(1, "et.ico");
            this.ımageList1.Images.SetKeyName(2, "meyveAndsebze.ico");
            this.ımageList1.Images.SetKeyName(3, "süt.ico");
            this.ımageList1.Images.SetKeyName(4, "Fixicon-Market-Cutlet.ico");
            this.ımageList1.Images.SetKeyName(5, "Google-Noto-Emoji-Food-Drink-32380-cut-of-meat.512.png");
            this.ımageList1.Images.SetKeyName(6, "Iconshow-Agriculture-Fruits-Vegetables.256.png");
            this.ımageList1.Images.SetKeyName(7, "Iconsmind-Outline-Cow.512.png");
            this.ımageList1.Images.SetKeyName(8, "Thesquid.ink-Free-Flat-Sample-Jar.512.png");
            // 
            // btn_sebzeUrunleri
            // 
            this.btn_sebzeUrunleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sebzeUrunleri.ImageKey = "Iconshow-Agriculture-Fruits-Vegetables.256.png";
            this.btn_sebzeUrunleri.ImageList = this.ımageList1;
            this.btn_sebzeUrunleri.Location = new System.Drawing.Point(206, 192);
            this.btn_sebzeUrunleri.Name = "btn_sebzeUrunleri";
            this.btn_sebzeUrunleri.Size = new System.Drawing.Size(140, 124);
            this.btn_sebzeUrunleri.TabIndex = 0;
            this.btn_sebzeUrunleri.UseVisualStyleBackColor = true;
            this.btn_sebzeUrunleri.Click += new System.EventHandler(this.btn_sebzeUrunleri_Click);
            // 
            // btn_EtUrunleri
            // 
            this.btn_EtUrunleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EtUrunleri.ImageKey = "Google-Noto-Emoji-Food-Drink-32380-cut-of-meat.512.png";
            this.btn_EtUrunleri.ImageList = this.ımageList1;
            this.btn_EtUrunleri.Location = new System.Drawing.Point(39, 39);
            this.btn_EtUrunleri.Name = "btn_EtUrunleri";
            this.btn_EtUrunleri.Size = new System.Drawing.Size(140, 124);
            this.btn_EtUrunleri.TabIndex = 0;
            this.btn_EtUrunleri.UseVisualStyleBackColor = true;
            this.btn_EtUrunleri.Click += new System.EventHandler(this.btn_EtUrunleri_Click);
            // 
            // btn_sutUrunleri
            // 
            this.btn_sutUrunleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sutUrunleri.ImageIndex = 7;
            this.btn_sutUrunleri.ImageList = this.ımageList1;
            this.btn_sutUrunleri.Location = new System.Drawing.Point(206, 39);
            this.btn_sutUrunleri.Name = "btn_sutUrunleri";
            this.btn_sutUrunleri.Size = new System.Drawing.Size(140, 124);
            this.btn_sutUrunleri.TabIndex = 0;
            this.btn_sutUrunleri.UseVisualStyleBackColor = true;
            this.btn_sutUrunleri.Click += new System.EventHandler(this.btn_sutUrunleri_Click);
            // 
            // btn_CıkısYap
            // 
            this.btn_CıkısYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CıkısYap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CıkısYap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CıkısYap.ImageKey = "cikis.ico";
            this.btn_CıkısYap.ImageList = this.ımageList2;
            this.btn_CıkısYap.Location = new System.Drawing.Point(39, 337);
            this.btn_CıkısYap.Name = "btn_CıkısYap";
            this.btn_CıkısYap.Size = new System.Drawing.Size(140, 32);
            this.btn_CıkısYap.TabIndex = 1;
            this.btn_CıkısYap.Text = "Çıkış Yap";
            this.btn_CıkısYap.UseVisualStyleBackColor = true;
            this.btn_CıkısYap.Click += new System.EventHandler(this.btn_CıkısYap_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "cikis.ico");
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(277, 9);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(19, 13);
            this.lbl_saat.TabIndex = 2;
            this.lbl_saat.Text = "00";
            this.lbl_saat.Click += new System.EventHandler(this.lbl_saat_Click);
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Location = new System.Drawing.Point(302, 9);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(19, 13);
            this.lbl_dakika.TabIndex = 2;
            this.lbl_dakika.Text = "00";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Location = new System.Drawing.Point(327, 9);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(19, 13);
            this.lbl_saniye.TabIndex = 2;
            this.lbl_saniye.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CashierPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 383);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.btn_CıkısYap);
            this.Controls.Add(this.btn_sutUrunleri);
            this.Controls.Add(this.btn_sebzeUrunleri);
            this.Controls.Add(this.btn_EtUrunleri);
            this.Controls.Add(this.btn_baklaUrunleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashierPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasiyer Paneli";
            this.Load += new System.EventHandler(this.CashierPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_baklaUrunleri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_sebzeUrunleri;
        private System.Windows.Forms.Button btn_EtUrunleri;
        private System.Windows.Forms.Button btn_sutUrunleri;
        private System.Windows.Forms.Button btn_CıkısYap;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Timer timer1;
    }
}