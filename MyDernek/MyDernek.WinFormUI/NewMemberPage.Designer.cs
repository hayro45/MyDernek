namespace MyDernek.WinFormUI
{
    partial class NewMemberPage
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbtnNotActive = new System.Windows.Forms.RadioButton();
            this.rdbtnActive = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxBloodType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chcIsAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(195, 181);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 22);
            this.txtPassword.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 187);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 77;
            this.label11.Text = "Şifre: ";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(195, 151);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(173, 22);
            this.txtMail.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 157);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 75;
            this.label10.Text = "Eposta: ";
            // 
            // rdbtnNotActive
            // 
            this.rdbtnNotActive.AutoSize = true;
            this.rdbtnNotActive.Location = new System.Drawing.Point(312, 273);
            this.rdbtnNotActive.Name = "rdbtnNotActive";
            this.rdbtnNotActive.Size = new System.Drawing.Size(55, 20);
            this.rdbtnNotActive.TabIndex = 74;
            this.rdbtnNotActive.TabStop = true;
            this.rdbtnNotActive.Text = "Pasif";
            this.rdbtnNotActive.UseVisualStyleBackColor = true;
            // 
            // rdbtnActive
            // 
            this.rdbtnActive.AutoSize = true;
            this.rdbtnActive.Location = new System.Drawing.Point(194, 273);
            this.rdbtnActive.Name = "rdbtnActive";
            this.rdbtnActive.Size = new System.Drawing.Size(50, 20);
            this.rdbtnActive.TabIndex = 73;
            this.rdbtnActive.TabStop = true;
            this.rdbtnActive.Text = "Aktif";
            this.rdbtnActive.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 72;
            this.label9.Text = "Aktif Üye: ";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(177, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(206, 25);
            this.lblBaslik.TabIndex = 71;
            this.lblBaslik.Text = "YENİ ÜYE SAYFASI";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(374, 286);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(108, 52);
            this.btnAddMember.TabIndex = 70;
            this.btnAddMember.Text = "Ekle";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Şehir: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Kan Grubu: ";
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(195, 240);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(173, 24);
            this.cbxCity.TabIndex = 67;
            // 
            // cbxBloodType
            // 
            this.cbxBloodType.FormattingEnabled = true;
            this.cbxBloodType.Location = new System.Drawing.Point(195, 210);
            this.cbxBloodType.Name = "cbxBloodType";
            this.cbxBloodType.Size = new System.Drawing.Size(173, 24);
            this.cbxBloodType.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "TcKimlik: ";
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(195, 61);
            this.txtTcKimlik.Margin = new System.Windows.Forms.Padding(4);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(173, 22);
            this.txtTcKimlik.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "İsim: ";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(195, 121);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(173, 22);
            this.txtLastname.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Soyisim: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(195, 91);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(173, 22);
            this.txtFirstName.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "Admin Yetkisi: ";
            // 
            // chcIsAdmin
            // 
            this.chcIsAdmin.AutoSize = true;
            this.chcIsAdmin.Location = new System.Drawing.Point(194, 303);
            this.chcIsAdmin.Name = "chcIsAdmin";
            this.chcIsAdmin.Size = new System.Drawing.Size(64, 20);
            this.chcIsAdmin.TabIndex = 80;
            this.chcIsAdmin.Text = "Admin";
            this.chcIsAdmin.UseVisualStyleBackColor = true;
            // 
            // NewMemberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 421);
            this.Controls.Add(this.chcIsAdmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rdbtnNotActive);
            this.Controls.Add(this.rdbtnActive);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.cbxBloodType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewMemberPage";
            this.Text = "NewMemberPage";
            this.Load += new System.EventHandler(this.NewMemberPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbtnNotActive;
        private System.Windows.Forms.RadioButton rdbtnActive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxBloodType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chcIsAdmin;
    }
}