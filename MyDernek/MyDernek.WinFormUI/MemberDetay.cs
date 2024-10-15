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
    public partial class MemberDetay : Form
    {
        private Member _member1;
        private IMemberService _memberService;
        private ICityService _cityService;
        private IBloodTypeService _bloodTypeService;
        public event EventHandler SecondFormClosed;
        private string conString = @"Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\MyDernekDb.accdb";
        public MemberDetay(Member member)
        {
            InitializeComponent();
            _member1 = member;
            _memberService = new MemberManager(conString);
            _cityService = new CityManager(conString);
            _bloodTypeService = new BloodTypeManager(conString);
            this.FormClosed += SecondForm_FormClosed;
        }
        private void SecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Olayı tetikle 
            OnSecondFormClosed();
        }

        // Olayı tetikleyen metod
        protected virtual void OnSecondFormClosed()
        {
            SecondFormClosed?.Invoke(this, EventArgs.Empty);
        }
        private void MemberDetay_Load(object sender, EventArgs e)
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

            if (_member1.IsActive == true)
                rdbtnActive.Checked = true;
            else
                rdbtnNotActive.Checked = true;

            if (_member1.IsAdmin == true)
            {
                checkBoxIsAdmin.Checked = true;
                checkBoxIsAdmin.Text = "Admin";
            }
            else
            {
                checkBoxIsAdmin.Checked = false;
                checkBoxIsAdmin.Text = "Üye";
            }

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

            _member1.IsActive = rdbtnActive.Checked ? true : false;

            _member1.IsAdmin = checkBoxIsAdmin.Checked ? true : false;


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

        

        private void btnMemberDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Üyeyi silmek istediğinize emin misiniz?", "Üye Silme", MessageBoxButtons.YesNo);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    
                    _memberService.Delete(_member1);
                    this.Close();

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxIsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            bool isAdmin = _member1.IsAdmin == true;
            int adminCount = _memberService.GetAll().Where(x => x.IsAdmin == true).Count();
            if (isAdmin && adminCount == 1)
            {
                lblAdminCountMessage.Text = "En az bir admin olmalı";
                lblAdminCountMessage.Visible = true;
                checkBoxIsAdmin.Checked = true;
                checkBoxIsAdmin.Text = "Admin";
            }
        }

        private void btnMemberPayments_Click(object sender, EventArgs e)
        {
            MemberPaymentPage paymentPage = new MemberPaymentPage(_member1);
            paymentPage.Show();
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
    }
}
