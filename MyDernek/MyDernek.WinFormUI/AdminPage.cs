using iTextSharp.text.pdf;
using iTextSharp.text;
using MyDernek.Business.Abstract;
using MyDernek.Business.Concrete;
using MyDernek.DataAccess.Concrete;
using MyDernek.DataAccess.Concrete.AdoNet;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDernek.WinFormUI
{
    public partial class AdminPage : Form
    {
        public Member _member;
        private IMemberService _memberService;
        private ICityService _cityService;
        private IBloodTypeService _bloodTypeService;
        private IMemberPaymentStatusService _memberPaymentStatusService;


        public string conString = @"Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\MyDernekDb.accdb";


        public AdminPage(Member member)
        {
            InitializeComponent();
            _member = member;
            _memberService = new MemberManager(conString);
            _cityService = new CityManager(conString);
            _bloodTypeService = new BloodTypeManager(conString);
            _memberPaymentStatusService = new MemberPaymentStatusManager(conString);
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + _member.FirstName;
            LoadCbxBloodType();
            LoadCbxCity();
        }
        private void LoadCbxCity()
        {
            cbxCity.DataSource = _cityService.GetAll();
            cbxCity.DisplayMember = "CityName";
            cbxCity.ValueMember = "CityId";
        }

        private void LoadCbxBloodType()
        {

            cbxBloodTypes.DataSource = _bloodTypeService.GetAll();
            cbxBloodTypes.DisplayMember = "TypeName";
            cbxBloodTypes.ValueMember = "BloodTypeId";
        }
        private void btnGetMembersWithDebt_Click(object sender, EventArgs e)
        {
            //Clear the datagridView data
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = _memberService.GetMembersWithDebt().Select(m => new
            {
                m.TcKimlik,
                m.FirstName,
                m.LastName,
                m.Email,
                m.UserPassword,
                m.BloodType.TypeName,
                m.City.CityName,
                m.IsActive,
                m.IsAdmin,
                m.DebtAmount,
                m.DueDate,
                m.DuesAmount
            }).ToList();
            btnMailToMembers.Visible = true;
            btnMembersToPdf.Visible = true;
        }

        private void btnGetMember_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource= _memberService.GetAll().Select(m => new {
                m.TcKimlik,
                m.FirstName,
                m.LastName,
                m.Email,
                m.UserPassword,
                m.BloodType.TypeName,
                m.City.CityName,
                m.IsActive,
                m.IsAdmin,
                m.DebtAmount,
                m.DueDate,
                m.DuesAmount
            }).ToList();
        }

        private void btnTcKimlikSearch_Click(object sender, EventArgs e)
        {
            var member = _memberService.Get(txtTcKimlikSearch.Text);

            MemberDetay memberPage = new MemberDetay(member);
            memberPage.FormClosed += SecondForm_FormClosed;
            
            memberPage.Show();
        }
        private void SecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {

            dataGridView1.DataSource = _memberService.GetAll().Select(m => new
            {
                m.TcKimlik,
                m.FirstName,
                m.LastName,
                m.Email,
                m.UserPassword,
                m.BloodType.TypeName,
                m.City.CityName,
                m.IsActive,
                m.IsAdmin,
                m.DebtAmount,
                m.DueDate,
                m.DuesAmount
            }).ToList();
        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _memberService.GetMembersByCity(cbxCity.SelectedValue.ToString()).Select(m => new
                {
                    m.TcKimlik,
                    m.FirstName,
                    m.LastName,
                    m.Email,
                    m.UserPassword,
                    m.BloodType.TypeName,
                    m.City.CityName,
                    m.IsActive,
                    m.IsAdmin,
                    m.DebtAmount,
                    m.DueDate,
                    m.DuesAmount
                }).ToList();
            }
            catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTcKimlikSearch.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTcKimlikSearch.Focus();
        }

        private void cbxBloodTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _memberService.GetMembersByBloodType(cbxBloodTypes.SelectedValue.ToString()).Select(m => new
                {
                    m.TcKimlik,
                    m.FirstName,
                    m.LastName,
                    m.Email,
                    m.UserPassword,
                    m.BloodType.TypeName,
                    m.City.CityName,
                    m.IsActive,
                    m.IsAdmin,
                    m.DebtAmount,
                    m.DueDate,
                    m.DuesAmount
                }).ToList();
            }
            catch { }
        }

        private void rdbtnActive_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (rdbtnActive.Checked == true)
            {
                dataGridView1.DataSource = _memberService.GetMembersByStatus(true)
                .Select(m => new
                {
                    m.TcKimlik,
                    m.FirstName,
                    m.LastName,
                    m.Email,
                    m.UserPassword,
                    m.BloodType.TypeName,
                    m.City.CityName,
                    m.IsActive,
                    m.IsAdmin,
                    m.DebtAmount,
                    m.DueDate,
                    m.DuesAmount
                }).ToList();

            }
            else if (rdbtnNotActive.Checked == true)
            {
                dataGridView1.DataSource = _memberService.GetMembersByStatus(false)
                .Select(m => new
                {
                    m.TcKimlik,
                    m.FirstName,
                    m.LastName,
                    m.Email,
                    m.UserPassword,
                    m.BloodType.TypeName,
                    m.City.CityName,
                    m.IsActive,
                    m.IsAdmin,
                    m.DebtAmount,
                    m.DueDate,
                    m.DuesAmount
                }).ToList();

            }
        }

        private void btnDatePickerSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            
            dataGridView1.DataSource = _memberPaymentStatusService.GetMembersPastPaymentsBtwTwoDate(startDate, endDate).Select(m => new
            {
                m.TcKimlik,
                m.Member.FirstName,
                m.Member.LastName,
                m.AmountPaid,
                m.PaymentDate
            }).ToList();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            NewMemberPage newMemberPage = new NewMemberPage();
            newMemberPage.FormClosed += SecondForm_FormClosed;
            newMemberPage.Show();

        }

        private void btnMailToMembers_Click(object sender, EventArgs e)
        {
            List<Member> members = _memberService.GetMembersWithDebt();
            if (members.Count>0)
            {
                SendMail sendMail = new SendMail(members, _member);
                sendMail.FormClosed += SecondForm_FormClosed;
                sendMail.Show();
            }
            else
            {
                MessageBox.Show("Borclu üye bulunmadı.");
            }
            
        }

        private void btnMembersToPdf_Click(object sender, EventArgs e)
        {
            //pdf oluşturulacak
            List<Member> members = _memberService.GetMembersWithDebt();

            DataTable table = new DataTable();
            table.Columns.Add("TcKimlik", typeof(string));
            table.Columns.Add("Ad", typeof(string));
            table.Columns.Add("Soyad", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Borç", typeof(decimal));

            foreach (Member member in members)
            {
                table.Rows.Add(member.TcKimlik, member.FirstName, member.LastName, member.Email, member.DebtAmount);
            }

            string pdfPath = "MembersList.pdf";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Select a Location to Save the PDF File",
                FileName = pdfPath
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pdfPath = saveFileDialog.FileName;
            }

            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));
            document.Open();

            PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
            pdfTable.WidthPercentage = 100;

            // Başlık satırı oluşturma
            PdfPCell[] cells = new PdfPCell[table.Columns.Count];
            for (int i = 0; i < table.Columns.Count; i++)
            {
                cells[i] = new PdfPCell(new Phrase(table.Columns[i].ColumnName));
            }
            for (int i = 0; i < cells.Length; i++)
            {
                pdfTable.AddCell(cells[i]);
            }
            // Üye verilerini tabloya ekleme
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    pdfTable.AddCell(new Phrase(row[column].ToString()));
                }
            }

            document.Add(pdfTable);
            document.Close();

        }

        private void btnDues_Click(object sender, EventArgs e)
        {
            DuesPage duesPage = new DuesPage(conString);
            duesPage.Show();
        }

        private void btnZedGraph_Click(object sender, EventArgs e)
        {
            ZedGraphPage zedGraphPage = new ZedGraphPage(conString);
            zedGraphPage.Show();
        }
    }
}
