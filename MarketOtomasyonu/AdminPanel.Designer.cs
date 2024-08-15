namespace MarketOtomasyonu
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.btn_usersAP = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_productsAP = new System.Windows.Forms.Button();
            this.btn_exitAP = new System.Windows.Forms.Button();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_usersAP
            // 
            this.btn_usersAP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_usersAP.ImageIndex = 0;
            this.btn_usersAP.ImageList = this.ımageList1;
            this.btn_usersAP.Location = new System.Drawing.Point(17, 25);
            this.btn_usersAP.Name = "btn_usersAP";
            this.btn_usersAP.Size = new System.Drawing.Size(142, 127);
            this.btn_usersAP.TabIndex = 0;
            this.btn_usersAP.UseVisualStyleBackColor = true;
            this.btn_usersAP.Click += new System.EventHandler(this.btn_usersAP_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Hopstarter-Sleek-Xp-Basic-User-Group.ico");
            this.ımageList1.Images.SetKeyName(1, "iconfinder_Shipping8_62597.ico");
            this.ımageList1.Images.SetKeyName(2, "cikis.ico");
            // 
            // btn_productsAP
            // 
            this.btn_productsAP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_productsAP.ImageKey = "iconfinder_Shipping8_62597.ico";
            this.btn_productsAP.ImageList = this.ımageList1;
            this.btn_productsAP.Location = new System.Drawing.Point(200, 25);
            this.btn_productsAP.Name = "btn_productsAP";
            this.btn_productsAP.Size = new System.Drawing.Size(142, 127);
            this.btn_productsAP.TabIndex = 0;
            this.btn_productsAP.UseVisualStyleBackColor = true;
            this.btn_productsAP.Click += new System.EventHandler(this.btn_productsAP_Click);
            // 
            // btn_exitAP
            // 
            this.btn_exitAP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exitAP.ImageKey = "cikis.ico";
            this.btn_exitAP.ImageList = this.ımageList1;
            this.btn_exitAP.Location = new System.Drawing.Point(109, 176);
            this.btn_exitAP.Name = "btn_exitAP";
            this.btn_exitAP.Size = new System.Drawing.Size(142, 127);
            this.btn_exitAP.TabIndex = 0;
            this.btn_exitAP.UseVisualStyleBackColor = true;
            this.btn_exitAP.Click += new System.EventHandler(this.btn_exitAP_Click_1);
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Location = new System.Drawing.Point(335, 9);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(19, 13);
            this.lbl_saniye.TabIndex = 3;
            this.lbl_saniye.Text = "00";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Location = new System.Drawing.Point(310, 9);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(19, 13);
            this.lbl_dakika.TabIndex = 4;
            this.lbl_dakika.Text = "00";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(285, 9);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(19, 13);
            this.lbl_saat.TabIndex = 5;
            this.lbl_saat.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 325);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.btn_exitAP);
            this.Controls.Add(this.btn_productsAP);
            this.Controls.Add(this.btn_usersAP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_usersAP;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_productsAP;
        private System.Windows.Forms.Button btn_exitAP;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Timer timer1;
    }
}