namespace MarketOtomasyonu
{
    partial class KullanıcıSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıSil));
            this.dgv_kullaniciSilS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ıdS = new System.Windows.Forms.TextBox();
            this.btn_silS = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_temizleS = new System.Windows.Forms.Button();
            this.btn_geriS = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullaniciSilS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_kullaniciSilS
            // 
            this.dgv_kullaniciSilS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_kullaniciSilS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kullaniciSilS.Location = new System.Drawing.Point(0, 0);
            this.dgv_kullaniciSilS.Name = "dgv_kullaniciSilS";
            this.dgv_kullaniciSilS.Size = new System.Drawing.Size(1067, 496);
            this.dgv_kullaniciSilS.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // txt_ıdS
            // 
            this.txt_ıdS.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ıdS.Location = new System.Drawing.Point(83, 550);
            this.txt_ıdS.Name = "txt_ıdS";
            this.txt_ıdS.Size = new System.Drawing.Size(248, 40);
            this.txt_ıdS.TabIndex = 2;
            this.txt_ıdS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_silS
            // 
            this.btn_silS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_silS.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_silS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_silS.ImageKey = "Iconshock-Vista-General-Trash.256.png";
            this.btn_silS.ImageList = this.ımageList1;
            this.btn_silS.Location = new System.Drawing.Point(671, 549);
            this.btn_silS.Name = "btn_silS";
            this.btn_silS.Size = new System.Drawing.Size(221, 44);
            this.btn_silS.TabIndex = 3;
            this.btn_silS.Text = "Sil";
            this.btn_silS.UseVisualStyleBackColor = true;
            this.btn_silS.Click += new System.EventHandler(this.btn_silS_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Bootstrap-Bootstrap-Bootstrap-arrow-left-circle.512.png");
            this.ımageList1.Images.SetKeyName(1, "Oxygen-Icons.org-Oxygen-Actions-edit-clear-locationbar-ltr.256.png");
            this.ımageList1.Images.SetKeyName(2, "Iconshock-Vista-General-Trash.256.png");
            this.ımageList1.Images.SetKeyName(3, "Arturo-Wibawa-Akar-Arrow-back-thick.512.png");
            // 
            // btn_temizleS
            // 
            this.btn_temizleS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_temizleS.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizleS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizleS.ImageKey = "Oxygen-Icons.org-Oxygen-Actions-edit-clear-locationbar-ltr.256.png";
            this.btn_temizleS.ImageList = this.ımageList1;
            this.btn_temizleS.Location = new System.Drawing.Point(381, 549);
            this.btn_temizleS.Name = "btn_temizleS";
            this.btn_temizleS.Size = new System.Drawing.Size(221, 44);
            this.btn_temizleS.TabIndex = 3;
            this.btn_temizleS.Text = "Temizle";
            this.btn_temizleS.UseVisualStyleBackColor = true;
            this.btn_temizleS.Click += new System.EventHandler(this.btn_temizleS_Click);
            // 
            // btn_geriS
            // 
            this.btn_geriS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geriS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geriS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geriS.ImageKey = "Arturo-Wibawa-Akar-Arrow-back-thick.512.png";
            this.btn_geriS.ImageList = this.ımageList2;
            this.btn_geriS.Location = new System.Drawing.Point(951, 582);
            this.btn_geriS.Name = "btn_geriS";
            this.btn_geriS.Size = new System.Drawing.Size(103, 38);
            this.btn_geriS.TabIndex = 4;
            this.btn_geriS.Text = "Geri";
            this.btn_geriS.UseVisualStyleBackColor = true;
            this.btn_geriS.Click += new System.EventHandler(this.btn_geriS_Click_1);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "Arturo-Wibawa-Akar-Arrow-back-thick.512.png");
            // 
            // KullanıcıSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 632);
            this.Controls.Add(this.btn_geriS);
            this.Controls.Add(this.btn_temizleS);
            this.Controls.Add(this.btn_silS);
            this.Controls.Add(this.txt_ıdS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_kullaniciSilS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullanıcıSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Sil";
            this.Load += new System.EventHandler(this.KullanıcıSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullaniciSilS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kullaniciSilS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ıdS;
        private System.Windows.Forms.Button btn_silS;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_temizleS;
        private System.Windows.Forms.Button btn_geriS;
        private System.Windows.Forms.ImageList ımageList2;
    }
}