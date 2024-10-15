namespace MyDernek.WinFormUI
{
    partial class AdminPage
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTcKimlikSearch = new System.Windows.Forms.TextBox();
            this.btnTcKimlikSearch = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDatePickerSearch = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGetMembersWithDebt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtnNotActive = new System.Windows.Forms.RadioButton();
            this.rdbtnActive = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxBloodTypes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.btnGetMember = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnMailToMembers = new System.Windows.Forms.Button();
            this.btnMembersToPdf = new System.Windows.Forms.Button();
            this.btnDues = new System.Windows.Forms.Button();
            this.btnZedGraph = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTcKimlikSearch);
            this.groupBox5.Controls.Add(this.btnTcKimlikSearch);
            this.groupBox5.Location = new System.Drawing.Point(350, 110);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 60);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TcKimliğe Göre Ara";
            // 
            // txtTcKimlikSearch
            // 
            this.txtTcKimlikSearch.Location = new System.Drawing.Point(6, 25);
            this.txtTcKimlikSearch.Name = "txtTcKimlikSearch";
            this.txtTcKimlikSearch.Size = new System.Drawing.Size(131, 22);
            this.txtTcKimlikSearch.TabIndex = 6;
            // 
            // btnTcKimlikSearch
            // 
            this.btnTcKimlikSearch.Location = new System.Drawing.Point(143, 18);
            this.btnTcKimlikSearch.Name = "btnTcKimlikSearch";
            this.btnTcKimlikSearch.Size = new System.Drawing.Size(51, 36);
            this.btnTcKimlikSearch.TabIndex = 5;
            this.btnTcKimlikSearch.Text = "Ara";
            this.btnTcKimlikSearch.UseVisualStyleBackColor = true;
            this.btnTcKimlikSearch.Click += new System.EventHandler(this.btnTcKimlikSearch_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDatePickerSearch);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Location = new System.Drawing.Point(735, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 76);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tarih Aralığında Ödeme Durumu";
            // 
            // btnDatePickerSearch
            // 
            this.btnDatePickerSearch.Location = new System.Drawing.Point(222, 27);
            this.btnDatePickerSearch.Name = "btnDatePickerSearch";
            this.btnDatePickerSearch.Size = new System.Drawing.Size(51, 36);
            this.btnDatePickerSearch.TabIndex = 2;
            this.btnDatePickerSearch.Text = "Ara";
            this.btnDatePickerSearch.UseVisualStyleBackColor = true;
            this.btnDatePickerSearch.Click += new System.EventHandler(this.btnDatePickerSearch_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnGetMembersWithDebt
            // 
            this.btnGetMembersWithDebt.Location = new System.Drawing.Point(13, 111);
            this.btnGetMembersWithDebt.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetMembersWithDebt.Name = "btnGetMembersWithDebt";
            this.btnGetMembersWithDebt.Size = new System.Drawing.Size(124, 59);
            this.btnGetMembersWithDebt.TabIndex = 18;
            this.btnGetMembersWithDebt.Text = "Borcu Olanları Getir";
            this.btnGetMembersWithDebt.UseVisualStyleBackColor = true;
            this.btnGetMembersWithDebt.Click += new System.EventHandler(this.btnGetMembersWithDebt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnNotActive);
            this.groupBox3.Controls.Add(this.rdbtnActive);
            this.groupBox3.Location = new System.Drawing.Point(556, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 60);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aktif Pasif Üye Ara";
            // 
            // rdbtnNotActive
            // 
            this.rdbtnNotActive.AutoSize = true;
            this.rdbtnNotActive.Location = new System.Drawing.Point(104, 21);
            this.rdbtnNotActive.Name = "rdbtnNotActive";
            this.rdbtnNotActive.Size = new System.Drawing.Size(55, 20);
            this.rdbtnNotActive.TabIndex = 8;
            this.rdbtnNotActive.TabStop = true;
            this.rdbtnNotActive.Text = "Pasif";
            this.rdbtnNotActive.UseVisualStyleBackColor = true;
            this.rdbtnNotActive.CheckedChanged += new System.EventHandler(this.rdbtnActive_CheckedChanged);
            // 
            // rdbtnActive
            // 
            this.rdbtnActive.AutoSize = true;
            this.rdbtnActive.Location = new System.Drawing.Point(17, 21);
            this.rdbtnActive.Name = "rdbtnActive";
            this.rdbtnActive.Size = new System.Drawing.Size(50, 20);
            this.rdbtnActive.TabIndex = 7;
            this.rdbtnActive.TabStop = true;
            this.rdbtnActive.Text = "Aktif";
            this.rdbtnActive.UseVisualStyleBackColor = true;
            this.rdbtnActive.CheckedChanged += new System.EventHandler(this.rdbtnActive_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxBloodTypes);
            this.groupBox2.Location = new System.Drawing.Point(350, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 60);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kan Grubuna Göre Ara";
            // 
            // cbxBloodTypes
            // 
            this.cbxBloodTypes.FormattingEnabled = true;
            this.cbxBloodTypes.Location = new System.Drawing.Point(6, 21);
            this.cbxBloodTypes.Name = "cbxBloodTypes";
            this.cbxBloodTypes.Size = new System.Drawing.Size(188, 24);
            this.cbxBloodTypes.TabIndex = 4;
            this.cbxBloodTypes.SelectedIndexChanged += new System.EventHandler(this.cbxBloodTypes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCity);
            this.groupBox1.Location = new System.Drawing.Point(350, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 60);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şehre Göre Ara";
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(6, 21);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(188, 24);
            this.cbxCity.TabIndex = 4;
            this.cbxCity.SelectedIndexChanged += new System.EventHandler(this.cbxCity_SelectedIndexChanged);
            // 
            // btnGetMember
            // 
            this.btnGetMember.Location = new System.Drawing.Point(13, 178);
            this.btnGetMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetMember.Name = "btnGetMember";
            this.btnGetMember.Size = new System.Drawing.Size(124, 60);
            this.btnGetMember.TabIndex = 14;
            this.btnGetMember.Text = "Bütün Üyeleri Getir";
            this.btnGetMember.UseVisualStyleBackColor = true;
            this.btnGetMember.Click += new System.EventHandler(this.btnGetMember_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 271);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1064, 290);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(13, 44);
            this.btnNewMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(124, 59);
            this.btnNewMember.TabIndex = 21;
            this.btnNewMember.Text = "Yeni Üye Ekle";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnMailToMembers
            // 
            this.btnMailToMembers.Location = new System.Drawing.Point(144, 111);
            this.btnMailToMembers.Name = "btnMailToMembers";
            this.btnMailToMembers.Size = new System.Drawing.Size(93, 59);
            this.btnMailToMembers.TabIndex = 22;
            this.btnMailToMembers.Text = "Borclulara Mail At";
            this.btnMailToMembers.UseVisualStyleBackColor = true;
            this.btnMailToMembers.Visible = false;
            this.btnMailToMembers.Click += new System.EventHandler(this.btnMailToMembers_Click);
            // 
            // btnMembersToPdf
            // 
            this.btnMembersToPdf.Location = new System.Drawing.Point(243, 111);
            this.btnMembersToPdf.Name = "btnMembersToPdf";
            this.btnMembersToPdf.Size = new System.Drawing.Size(93, 59);
            this.btnMembersToPdf.TabIndex = 23;
            this.btnMembersToPdf.Text = "Borcluların Pdfini Çıkar";
            this.btnMembersToPdf.UseVisualStyleBackColor = true;
            this.btnMembersToPdf.Visible = false;
            this.btnMembersToPdf.Click += new System.EventHandler(this.btnMembersToPdf_Click);
            // 
            // btnDues
            // 
            this.btnDues.Location = new System.Drawing.Point(586, 44);
            this.btnDues.Name = "btnDues";
            this.btnDues.Size = new System.Drawing.Size(115, 59);
            this.btnDues.TabIndex = 24;
            this.btnDues.Text = "Aidatları Getir";
            this.btnDues.UseVisualStyleBackColor = true;
            this.btnDues.Click += new System.EventHandler(this.btnDues_Click);
            // 
            // btnZedGraph
            // 
            this.btnZedGraph.Location = new System.Drawing.Point(718, 43);
            this.btnZedGraph.Name = "btnZedGraph";
            this.btnZedGraph.Size = new System.Drawing.Size(115, 59);
            this.btnZedGraph.TabIndex = 25;
            this.btnZedGraph.Text = "Aylık ve Yıllık Gelirler";
            this.btnZedGraph.UseVisualStyleBackColor = true;
            this.btnZedGraph.Click += new System.EventHandler(this.btnZedGraph_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.btnZedGraph);
            this.Controls.Add(this.btnDues);
            this.Controls.Add(this.btnMembersToPdf);
            this.Controls.Add(this.btnMailToMembers);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnGetMembersWithDebt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetMember);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTcKimlikSearch;
        private System.Windows.Forms.Button btnTcKimlikSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDatePickerSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGetMembersWithDebt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbtnNotActive;
        private System.Windows.Forms.RadioButton rdbtnActive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxBloodTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Button btnGetMember;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnMailToMembers;
        private System.Windows.Forms.Button btnMembersToPdf;
        private System.Windows.Forms.Button btnDues;
        private System.Windows.Forms.Button btnZedGraph;
    }
}