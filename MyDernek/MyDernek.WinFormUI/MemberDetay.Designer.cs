namespace MyDernek.WinFormUI
{
    partial class MemberDetay
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
            this.btnUpdate = new System.Windows.Forms.Button();
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
            this.txtDuesAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepthAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnMemberPayments = new System.Windows.Forms.Button();
            this.btnDuesSet = new System.Windows.Forms.Button();
            this.btnDepthSet = new System.Windows.Forms.Button();
            this.btnMemberDelete = new System.Windows.Forms.Button();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAdminCountMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 169);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 22);
            this.txtPassword.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 175);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Şifre: ";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(170, 139);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(173, 22);
            this.txtMail.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "Eposta: ";
            // 
            // rdbtnNotActive
            // 
            this.rdbtnNotActive.AutoSize = true;
            this.rdbtnNotActive.Location = new System.Drawing.Point(287, 261);
            this.rdbtnNotActive.Name = "rdbtnNotActive";
            this.rdbtnNotActive.Size = new System.Drawing.Size(55, 20);
            this.rdbtnNotActive.TabIndex = 46;
            this.rdbtnNotActive.TabStop = true;
            this.rdbtnNotActive.Text = "Pasif";
            this.rdbtnNotActive.UseVisualStyleBackColor = true;
            // 
            // rdbtnActive
            // 
            this.rdbtnActive.AutoSize = true;
            this.rdbtnActive.Location = new System.Drawing.Point(169, 261);
            this.rdbtnActive.Name = "rdbtnActive";
            this.rdbtnActive.Size = new System.Drawing.Size(50, 20);
            this.rdbtnActive.TabIndex = 45;
            this.rdbtnActive.TabStop = true;
            this.rdbtnActive.Text = "Aktif";
            this.rdbtnActive.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Aktif Üye: ";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(164, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(178, 25);
            this.lblBaslik.TabIndex = 43;
            this.lblBaslik.Text = "DETAY SAYFASI";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(357, 282);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 23);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Şehir: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Kan Grubu: ";
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(170, 228);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(173, 24);
            this.cbxCity.TabIndex = 39;
            // 
            // cbxBloodType
            // 
            this.cbxBloodType.FormattingEnabled = true;
            this.cbxBloodType.Location = new System.Drawing.Point(170, 198);
            this.cbxBloodType.Name = "cbxBloodType";
            this.cbxBloodType.Size = new System.Drawing.Size(173, 24);
            this.cbxBloodType.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "TcKimlik: ";
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(170, 49);
            this.txtTcKimlik.Margin = new System.Windows.Forms.Padding(4);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.ReadOnly = true;
            this.txtTcKimlik.Size = new System.Drawing.Size(173, 22);
            this.txtTcKimlik.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "İsim: ";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(170, 109);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(173, 22);
            this.txtLastname.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Soyisim: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(170, 79);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(173, 22);
            this.txtFirstName.TabIndex = 32;
            // 
            // txtDuesAmount
            // 
            this.txtDuesAmount.Location = new System.Drawing.Point(168, 369);
            this.txtDuesAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuesAmount.Name = "txtDuesAmount";
            this.txtDuesAmount.ReadOnly = true;
            this.txtDuesAmount.Size = new System.Drawing.Size(173, 22);
            this.txtDuesAmount.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 377);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "Aidat: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Aidat Son Ödeme Tarihi: ";
            // 
            // txtDepthAmount
            // 
            this.txtDepthAmount.Location = new System.Drawing.Point(168, 342);
            this.txtDepthAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepthAmount.Name = "txtDepthAmount";
            this.txtDepthAmount.ReadOnly = true;
            this.txtDepthAmount.Size = new System.Drawing.Size(173, 22);
            this.txtDepthAmount.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 349);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Borç: ";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Location = new System.Drawing.Point(167, 398);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(174, 22);
            this.dtpDueDate.TabIndex = 58;
            // 
            // btnMemberPayments
            // 
            this.btnMemberPayments.Location = new System.Drawing.Point(348, 396);
            this.btnMemberPayments.Name = "btnMemberPayments";
            this.btnMemberPayments.Size = new System.Drawing.Size(99, 40);
            this.btnMemberPayments.TabIndex = 59;
            this.btnMemberPayments.Text = "Geçmiş Ödemeler";
            this.btnMemberPayments.UseVisualStyleBackColor = true;
            this.btnMemberPayments.Click += new System.EventHandler(this.btnMemberPayments_Click);
            // 
            // btnDuesSet
            // 
            this.btnDuesSet.Location = new System.Drawing.Point(348, 368);
            this.btnDuesSet.Name = "btnDuesSet";
            this.btnDuesSet.Size = new System.Drawing.Size(99, 23);
            this.btnDuesSet.TabIndex = 57;
            this.btnDuesSet.Text = "Aidat Öde";
            this.btnDuesSet.UseVisualStyleBackColor = true;
            this.btnDuesSet.Click += new System.EventHandler(this.btnDuesSet_Click);
            // 
            // btnDepthSet
            // 
            this.btnDepthSet.Location = new System.Drawing.Point(348, 341);
            this.btnDepthSet.Name = "btnDepthSet";
            this.btnDepthSet.Size = new System.Drawing.Size(99, 23);
            this.btnDepthSet.TabIndex = 56;
            this.btnDepthSet.Text = "Borç Öde";
            this.btnDepthSet.UseVisualStyleBackColor = true;
            this.btnDepthSet.Click += new System.EventHandler(this.btnDepthSet_Click);
            // 
            // btnMemberDelete
            // 
            this.btnMemberDelete.Location = new System.Drawing.Point(386, 9);
            this.btnMemberDelete.Name = "btnMemberDelete";
            this.btnMemberDelete.Size = new System.Drawing.Size(96, 44);
            this.btnMemberDelete.TabIndex = 60;
            this.btnMemberDelete.Text = "Üye Sil";
            this.btnMemberDelete.UseVisualStyleBackColor = true;
            this.btnMemberDelete.Click += new System.EventHandler(this.btnMemberDelete_Click);
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(170, 291);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsAdmin.TabIndex = 61;
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            this.checkBoxIsAdmin.CheckedChanged += new System.EventHandler(this.checkBoxIsAdmin_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 62;
            this.label12.Text = "Yetki: ";
            // 
            // lblAdminCountMessage
            // 
            this.lblAdminCountMessage.AutoSize = true;
            this.lblAdminCountMessage.Location = new System.Drawing.Point(168, 308);
            this.lblAdminCountMessage.Name = "lblAdminCountMessage";
            this.lblAdminCountMessage.Size = new System.Drawing.Size(0, 16);
            this.lblAdminCountMessage.TabIndex = 63;
            this.lblAdminCountMessage.Visible = false;
            // 
            // MemberDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 448);
            this.Controls.Add(this.lblAdminCountMessage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkBoxIsAdmin);
            this.Controls.Add(this.btnMemberDelete);
            this.Controls.Add(this.txtDuesAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDepthAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnMemberPayments);
            this.Controls.Add(this.btnDuesSet);
            this.Controls.Add(this.btnDepthSet);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rdbtnNotActive);
            this.Controls.Add(this.rdbtnActive);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnUpdate);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberDetay";
            this.Text = "MemberDetay";
            this.Load += new System.EventHandler(this.MemberDetay_Load);
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
        private System.Windows.Forms.Button btnUpdate;
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
        private System.Windows.Forms.TextBox txtDuesAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepthAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnMemberPayments;
        private System.Windows.Forms.Button btnDuesSet;
        private System.Windows.Forms.Button btnDepthSet;
        private System.Windows.Forms.Button btnMemberDelete;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAdminCountMessage;
    }
}