namespace MyDernek.WinFormUI
{
    partial class ZedGraphPage
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
            this.zedGraphControlPaymentStatus = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // zedGraphControlPaymentStatus
            // 
            this.zedGraphControlPaymentStatus.Location = new System.Drawing.Point(13, 61);
            this.zedGraphControlPaymentStatus.Name = "zedGraphControlPaymentStatus";
            this.zedGraphControlPaymentStatus.ScrollGrace = 0D;
            this.zedGraphControlPaymentStatus.ScrollMaxX = 0D;
            this.zedGraphControlPaymentStatus.ScrollMaxY = 0D;
            this.zedGraphControlPaymentStatus.ScrollMaxY2 = 0D;
            this.zedGraphControlPaymentStatus.ScrollMinX = 0D;
            this.zedGraphControlPaymentStatus.ScrollMinY = 0D;
            this.zedGraphControlPaymentStatus.ScrollMinY2 = 0D;
            this.zedGraphControlPaymentStatus.Size = new System.Drawing.Size(860, 377);
            this.zedGraphControlPaymentStatus.TabIndex = 0;
            this.zedGraphControlPaymentStatus.UseExtendedPrintDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(333, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aylık ve Yıllık Aidat Gelirleri";
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(13, 11);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYears.TabIndex = 3;
            this.comboBoxYears.SelectedIndexChanged += new System.EventHandler(this.comboBoxYears_SelectedIndexChanged);
            // 
            // ZedGraphPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.comboBoxYears);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraphControlPaymentStatus);
            this.Name = "ZedGraphPage";
            this.Text = "ZedGraphPage";
            this.Load += new System.EventHandler(this.ZedGraphPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControlPaymentStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxYears;
    }
}