namespace FinancialCrm
{
    partial class FrmKayitOl
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
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKayitOlPassword = new System.Windows.Forms.TextBox();
            this.txtKayitOlUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFrmLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnKayitOl.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(75, 227);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(230, 41);
            this.btnKayitOl.TabIndex = 13;
            this.btnKayitOl.Text = "Kayıt ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(90, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 59);
            this.label3.TabIndex = 12;
            this.label3.Text = "KAYIT OL";
            // 
            // txtKayitOlPassword
            // 
            this.txtKayitOlPassword.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtKayitOlPassword.Location = new System.Drawing.Point(75, 187);
            this.txtKayitOlPassword.Name = "txtKayitOlPassword";
            this.txtKayitOlPassword.Size = new System.Drawing.Size(230, 30);
            this.txtKayitOlPassword.TabIndex = 11;
            this.txtKayitOlPassword.Text = "Şifre";
            this.txtKayitOlPassword.UseSystemPasswordChar = true;
            // 
            // txtKayitOlUsername
            // 
            this.txtKayitOlUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKayitOlUsername.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtKayitOlUsername.Location = new System.Drawing.Point(75, 119);
            this.txtKayitOlUsername.Name = "txtKayitOlUsername";
            this.txtKayitOlUsername.Size = new System.Drawing.Size(230, 30);
            this.txtKayitOlUsername.TabIndex = 10;
            this.txtKayitOlUsername.Text = "Enter kullanıcı adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(71, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btnFrmLogin
            // 
            this.btnFrmLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFrmLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFrmLogin.ForeColor = System.Drawing.Color.White;
            this.btnFrmLogin.Location = new System.Drawing.Point(123, 298);
            this.btnFrmLogin.Name = "btnFrmLogin";
            this.btnFrmLogin.Size = new System.Drawing.Size(137, 41);
            this.btnFrmLogin.TabIndex = 14;
            this.btnFrmLogin.Text = "Giriş yap";
            this.btnFrmLogin.UseVisualStyleBackColor = false;
            this.btnFrmLogin.Click += new System.EventHandler(this.btnFrmLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(170, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "veya";
            // 
            // FrmKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFrmLogin);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKayitOlPassword);
            this.Controls.Add(this.txtKayitOlUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKayitOl";
            this.Load += new System.EventHandler(this.FrmKayitOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKayitOlPassword;
        private System.Windows.Forms.TextBox txtKayitOlUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFrmLogin;
        private System.Windows.Forms.Label label4;
    }
}