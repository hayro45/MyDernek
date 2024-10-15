namespace MyDernek.WinFormUI
{
    partial class DuesPage
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
            this.btnDuesAdd = new System.Windows.Forms.Button();
            this.cmbxYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbxMonth = new System.Windows.Forms.ComboBox();
            this.UpDownDuesAmount = new System.Windows.Forms.NumericUpDown();
            this.lblDuesAmount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuesUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxYearUpdate = new System.Windows.Forms.ComboBox();
            this.UpDownDuesAmountUpdate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxMonthUpdate = new System.Windows.Forms.ComboBox();
            this.btnDuesDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDuesAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDuesAmountUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDuesAdd
            // 
            this.btnDuesAdd.Location = new System.Drawing.Point(89, 128);
            this.btnDuesAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuesAdd.Name = "btnDuesAdd";
            this.btnDuesAdd.Size = new System.Drawing.Size(105, 28);
            this.btnDuesAdd.TabIndex = 0;
            this.btnDuesAdd.Text = "Aidat Ekle";
            this.btnDuesAdd.UseVisualStyleBackColor = true;
            this.btnDuesAdd.Visible = false;
            this.btnDuesAdd.Click += new System.EventHandler(this.btnDuesAdd_Click);
            // 
            // cmbxYear
            // 
            this.cmbxYear.FormattingEnabled = true;
            this.cmbxYear.Location = new System.Drawing.Point(110, 36);
            this.cmbxYear.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxYear.Name = "cmbxYear";
            this.cmbxYear.Size = new System.Drawing.Size(84, 24);
            this.cmbxYear.TabIndex = 1;
            this.cmbxYear.SelectedIndexChanged += new System.EventHandler(this.cmbxYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(62, 44);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(28, 16);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Yıl: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 183);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(331, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aidatlar Sayfası";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(62, 76);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(29, 16);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Ay: ";
            this.lblMonth.Visible = false;
            // 
            // cmbxMonth
            // 
            this.cmbxMonth.FormattingEnabled = true;
            this.cmbxMonth.Location = new System.Drawing.Point(110, 68);
            this.cmbxMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxMonth.Name = "cmbxMonth";
            this.cmbxMonth.Size = new System.Drawing.Size(84, 24);
            this.cmbxMonth.TabIndex = 5;
            this.cmbxMonth.Visible = false;
            this.cmbxMonth.SelectedIndexChanged += new System.EventHandler(this.cmbxMonth_SelectedIndexChanged);
            // 
            // UpDownDuesAmount
            // 
            this.UpDownDuesAmount.Location = new System.Drawing.Point(110, 99);
            this.UpDownDuesAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UpDownDuesAmount.Name = "UpDownDuesAmount";
            this.UpDownDuesAmount.Size = new System.Drawing.Size(84, 22);
            this.UpDownDuesAmount.TabIndex = 7;
            this.UpDownDuesAmount.Visible = false;
            this.UpDownDuesAmount.ValueChanged += new System.EventHandler(this.UpDownDuesAmount_ValueChanged);
            this.UpDownDuesAmount.Click += new System.EventHandler(this.UpDownDuesAmount_Click);
            // 
            // lblDuesAmount
            // 
            this.lblDuesAmount.AutoSize = true;
            this.lblDuesAmount.Location = new System.Drawing.Point(7, 105);
            this.lblDuesAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuesAmount.Name = "lblDuesAmount";
            this.lblDuesAmount.Size = new System.Drawing.Size(86, 16);
            this.lblDuesAmount.TabIndex = 8;
            this.lblDuesAmount.Text = "Aidat Miktarı: ";
            this.lblDuesAmount.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDuesAdd);
            this.groupBox1.Controls.Add(this.lblDuesAmount);
            this.groupBox1.Controls.Add(this.cmbxYear);
            this.groupBox1.Controls.Add(this.UpDownDuesAmount);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.lblMonth);
            this.groupBox1.Controls.Add(this.cmbxMonth);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 172);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aidat Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuesUpdate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbxYearUpdate);
            this.groupBox2.Controls.Add(this.UpDownDuesAmountUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbxMonthUpdate);
            this.groupBox2.Location = new System.Drawing.Point(534, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 172);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aidat Güncelle";
            this.groupBox2.Visible = false;
            // 
            // btnDuesUpdate
            // 
            this.btnDuesUpdate.Location = new System.Drawing.Point(89, 128);
            this.btnDuesUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuesUpdate.Name = "btnDuesUpdate";
            this.btnDuesUpdate.Size = new System.Drawing.Size(105, 28);
            this.btnDuesUpdate.TabIndex = 0;
            this.btnDuesUpdate.Text = "Aidat Güncelle";
            this.btnDuesUpdate.UseVisualStyleBackColor = true;
            this.btnDuesUpdate.Click += new System.EventHandler(this.btnDuesUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aidat Miktarı: ";
            // 
            // cmbxYearUpdate
            // 
            this.cmbxYearUpdate.FormattingEnabled = true;
            this.cmbxYearUpdate.Location = new System.Drawing.Point(110, 36);
            this.cmbxYearUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxYearUpdate.Name = "cmbxYearUpdate";
            this.cmbxYearUpdate.Size = new System.Drawing.Size(84, 24);
            this.cmbxYearUpdate.TabIndex = 1;
            // 
            // UpDownDuesAmountUpdate
            // 
            this.UpDownDuesAmountUpdate.Location = new System.Drawing.Point(110, 99);
            this.UpDownDuesAmountUpdate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UpDownDuesAmountUpdate.Name = "UpDownDuesAmountUpdate";
            this.UpDownDuesAmountUpdate.Size = new System.Drawing.Size(84, 22);
            this.UpDownDuesAmountUpdate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yıl: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ay: ";
            // 
            // cmbxMonthUpdate
            // 
            this.cmbxMonthUpdate.FormattingEnabled = true;
            this.cmbxMonthUpdate.Location = new System.Drawing.Point(110, 68);
            this.cmbxMonthUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxMonthUpdate.Name = "cmbxMonthUpdate";
            this.cmbxMonthUpdate.Size = new System.Drawing.Size(84, 24);
            this.cmbxMonthUpdate.TabIndex = 5;
            // 
            // btnDuesDelete
            // 
            this.btnDuesDelete.Location = new System.Drawing.Point(335, 158);
            this.btnDuesDelete.Name = "btnDuesDelete";
            this.btnDuesDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDuesDelete.TabIndex = 11;
            this.btnDuesDelete.Text = "Aidat Sil";
            this.btnDuesDelete.UseVisualStyleBackColor = true;
            this.btnDuesDelete.Visible = false;
            this.btnDuesDelete.Click += new System.EventHandler(this.btnDuesDelete_Click);
            // 
            // DuesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 384);
            this.Controls.Add(this.btnDuesDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DuesPage";
            this.Text = "DuesPage";
            this.Load += new System.EventHandler(this.DuesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDuesAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDuesAmountUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDuesAdd;
        private System.Windows.Forms.ComboBox cmbxYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbxMonth;
        private System.Windows.Forms.NumericUpDown UpDownDuesAmount;
        private System.Windows.Forms.Label lblDuesAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuesUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxYearUpdate;
        private System.Windows.Forms.NumericUpDown UpDownDuesAmountUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxMonthUpdate;
        private System.Windows.Forms.Button btnDuesDelete;
    }
}