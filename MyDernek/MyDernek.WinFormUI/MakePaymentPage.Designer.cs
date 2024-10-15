namespace MyDernek.WinFormUI
{
    partial class MakePaymentPage
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
            this.lblBorcAidat = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBorcAidat
            // 
            this.lblBorcAidat.AutoSize = true;
            this.lblBorcAidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBorcAidat.Location = new System.Drawing.Point(256, 94);
            this.lblBorcAidat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorcAidat.Name = "lblBorcAidat";
            this.lblBorcAidat.Size = new System.Drawing.Size(0, 16);
            this.lblBorcAidat.TabIndex = 11;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(400, 158);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Öde";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(219, 24);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(0, 24);
            this.lblBaslik.TabIndex = 9;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(211, 159);
            this.txtSum.Margin = new System.Windows.Forms.Padding(4);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(166, 22);
            this.txtSum.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ödenecek Tutar: ";
            // 
            // MakePaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.lblBorcAidat);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MakePaymentPage";
            this.Text = "MakePaymentPage";
            this.Load += new System.EventHandler(this.MakePaymentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorcAidat;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label1;
    }
}