using MyDernek.Business.Abstract;
using MyDernek.Business.Concrete;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDernek.WinFormUI
{
    public partial class MemberPage : Form
    {
        private Member _member1;
        private IMemberService _memberService;
        private ICityService _cityService;
        private IBloodTypeService _bloodTypeService;
        private string conString = @"Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\MyDernekDb.accdb";
        public MemberPage(Member member)
        {
            InitializeComponent();
            _member1 = member;
            lblSayHello.Text = "Merhaba Hoşgeldiniz Sayın "+member.FirstName +" "+member.LastName;
            _memberService = new MemberManager(conString);
            _cityService = new CityManager(conString);
            _bloodTypeService = new BloodTypeManager(conString);

        }

        private void MemberPage_Load(object sender, EventArgs e)
        {
            txtTcKimlik.Text = _member1.TcKimlik.ToString();
            txtFirstName.Text = _member1.FirstName.ToString();
            txtLastname.Text = _member1.LastName.ToString();
            txtMail.Text = _member1.Email.ToString();
            txtPassword.Text = _member1.UserPassword.ToString();

            LoadCbxBloodType();
            LoadCbxCity();

            cbxBloodType.SelectedValue = _member1.BloodTypeId;
            cbxCity.SelectedValue = _member1.CityId;

            

            txtDepthAmount.Text = _member1.DebtAmount.ToString();
            txtDuesAmount.Text = _member1.DuesAmount.ToString();
            dtpDueDate.Value = _member1.DueDate;
        }
        private void LoadCbxCity()
        {
            cbxCity.DataSource = _cityService.GetAll();
            cbxCity.DisplayMember = "CityName";
            cbxCity.ValueMember = "CityId";
        }

        private void LoadCbxBloodType()
        {

            cbxBloodType.DataSource = _bloodTypeService.GetAll();
            cbxBloodType.DisplayMember = "TypeName";
            cbxBloodType.ValueMember = "BloodTypeId";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _member1.FirstName = txtFirstName.Text;
            _member1.LastName = txtLastname.Text;
            _member1.UserPassword = txtPassword.Text;
            _member1.Email = txtMail.Text;
            _member1.BloodTypeId = cbxBloodType.SelectedValue.ToString();
            _member1.CityId = cbxCity.SelectedValue.ToString();
            try
            {
            _memberService.Update(_member1);

            MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDepthSet_Click(object sender, EventArgs e)
        {
            MakePaymentPage makePaymentPage = new MakePaymentPage(_member1, true);
            makePaymentPage.Show();
        }

        private void btnDuesSet_Click(object sender, EventArgs e)
        {
            MakePaymentPage makePaymentPage = new MakePaymentPage(_member1, false);
            makePaymentPage.Show();
        }

        private void btnMemberPayments_Click(object sender, EventArgs e)
        {
            MemberPaymentPage paymentPage = new MemberPaymentPage(_member1);
            paymentPage.Show();
        }
    }
}
