namespace MyDernek.WinFormUI
{
    partial class SendMail
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
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnMessageUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(83, 35);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(227, 210);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mesaj";
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(316, 219);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(110, 26);
            this.btnSendMail.TabIndex = 2;
            this.btnSendMail.Text = "Gönder";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnMessageUpdate
            // 
            this.btnMessageUpdate.Location = new System.Drawing.Point(316, 35);
            this.btnMessageUpdate.Name = "btnMessageUpdate";
            this.btnMessageUpdate.Size = new System.Drawing.Size(110, 27);
            this.btnMessageUpdate.TabIndex = 3;
            this.btnMessageUpdate.Text = "Mesajı Düzenle";
            this.btnMessageUpdate.UseVisualStyleBackColor = true;
            this.btnMessageUpdate.Click += new System.EventHandler(this.btnMessageUpdate_Click);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 287);
            this.Controls.Add(this.btnMessageUpdate);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Name = "SendMail";
            this.Text = "SendMail";
            this.Load += new System.EventHandler(this.SendMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnMessageUpdate;
    }
}