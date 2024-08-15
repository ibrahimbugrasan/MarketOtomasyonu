namespace MarketOtomasyonu
{
    partial class KullanıcıSec
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
            this.dgv_select = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_permission = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_sq = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_sa = new System.Windows.Forms.Label();
            this.btn_cıkısyapS = new System.Windows.Forms.Button();
            this.txt_IdAra = new System.Windows.Forms.TextBox();
            this.btn_AraU = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_select
            // 
            this.dgv_select.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_select.Location = new System.Drawing.Point(0, 0);
            this.dgv_select.Name = "dgv_select";
            this.dgv_select.Size = new System.Drawing.Size(1065, 443);
            this.dgv_select.TabIndex = 0;
            this.dgv_select.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_select_CellClick);
            this.dgv_select.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_select_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ID.Location = new System.Drawing.Point(48, 504);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 18);
            this.lbl_ID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_username.Location = new System.Drawing.Point(115, 578);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(0, 18);
            this.lbl_username.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(462, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şifre:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password.Location = new System.Drawing.Point(500, 504);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(0, 18);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(488, 578);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Bölge:";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_area.Location = new System.Drawing.Point(538, 578);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(0, 18);
            this.lbl_area.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(224, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.Location = new System.Drawing.Point(271, 504);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(0, 18);
            this.lbl_email.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(298, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yetki:";
            // 
            // lbl_permission
            // 
            this.lbl_permission.AutoSize = true;
            this.lbl_permission.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_permission.Location = new System.Drawing.Point(339, 578);
            this.lbl_permission.Name = "lbl_permission";
            this.lbl_permission.Size = new System.Drawing.Size(0, 18);
            this.lbl_permission.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(680, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Güvenlik Sorusu:";
            // 
            // lbl_sq
            // 
            this.lbl_sq.AutoSize = true;
            this.lbl_sq.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sq.Location = new System.Drawing.Point(791, 504);
            this.lbl_sq.Name = "lbl_sq";
            this.lbl_sq.Size = new System.Drawing.Size(0, 18);
            this.lbl_sq.TabIndex = 1;
            this.lbl_sq.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(747, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Güvenlik Cevabı:";
            // 
            // lbl_sa
            // 
            this.lbl_sa.AutoSize = true;
            this.lbl_sa.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sa.Location = new System.Drawing.Point(872, 578);
            this.lbl_sa.Name = "lbl_sa";
            this.lbl_sa.Size = new System.Drawing.Size(0, 18);
            this.lbl_sa.TabIndex = 1;
            // 
            // btn_cıkısyapS
            // 
            this.btn_cıkısyapS.BackColor = System.Drawing.Color.Brown;
            this.btn_cıkısyapS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cıkısyapS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cıkısyapS.Location = new System.Drawing.Point(968, 586);
            this.btn_cıkısyapS.Name = "btn_cıkısyapS";
            this.btn_cıkısyapS.Size = new System.Drawing.Size(86, 34);
            this.btn_cıkısyapS.TabIndex = 2;
            this.btn_cıkısyapS.Text = "Çıkış Yap";
            this.btn_cıkısyapS.UseVisualStyleBackColor = false;
            this.btn_cıkısyapS.Click += new System.EventHandler(this.btn_cıkısyapS_Click);
            // 
            // txt_IdAra
            // 
            this.txt_IdAra.AccessibleName = "";
            this.txt_IdAra.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_IdAra.Location = new System.Drawing.Point(794, 447);
            this.txt_IdAra.Name = "txt_IdAra";
            this.txt_IdAra.Size = new System.Drawing.Size(90, 23);
            this.txt_IdAra.TabIndex = 3;
            this.txt_IdAra.Tag = "";
            this.txt_IdAra.Text = "ID";
            // 
            // btn_AraU
            // 
            this.btn_AraU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_AraU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AraU.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AraU.Location = new System.Drawing.Point(898, 447);
            this.btn_AraU.Name = "btn_AraU";
            this.btn_AraU.Size = new System.Drawing.Size(75, 23);
            this.btn_AraU.TabIndex = 4;
            this.btn_AraU.Text = "Ara";
            this.btn_AraU.UseVisualStyleBackColor = false;
            this.btn_AraU.Click += new System.EventHandler(this.btn_AraU_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_temizle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_temizle.ForeColor = System.Drawing.Color.Black;
            this.btn_temizle.Location = new System.Drawing.Point(979, 447);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 5;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // KullanıcıSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 632);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_AraU);
            this.Controls.Add(this.txt_IdAra);
            this.Controls.Add(this.btn_cıkısyapS);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_sq);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_sa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_permission);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullanıcıSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Seç";
            this.Load += new System.EventHandler(this.KullanıcıSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_permission;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_sq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_sa;
        private System.Windows.Forms.Button btn_cıkısyapS;
        private System.Windows.Forms.TextBox txt_IdAra;
        private System.Windows.Forms.Button btn_AraU;
        private System.Windows.Forms.Button btn_temizle;
    }
}