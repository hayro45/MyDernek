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
    public partial class NewMemberPage : Form
    {
        private Member _member1 =new Member();
        private Dues _dues;
        private IMemberService _memberService;
        private ICityService _cityService;
        private IBloodTypeService _bloodTypeService;
        private IDuesService _duesService;
        public event EventHandler SecondFormClosed;
        private string conString = @"Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\MyDernekDb.accdb";
        
        public NewMemberPage()
        {
            InitializeComponent();
           
            _memberService = new MemberManager(conString);
            _cityService = new CityManager(conString);
            _bloodTypeService = new BloodTypeManager(conString);
            _duesService = new DuesManager(conString);
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
        private void NewMemberPage_Load(object sender, EventArgs e)
        {
            LoadCbxBloodType();
            LoadCbxCity();
            LoadDues();
        }
        private void LoadDues()
        {
            DateTime dateTime = DateTime.Now;
            int month = dateTime.Month;
            int year = dateTime.Year;

            try
            {
                _dues = _duesService.Get(month, year);

            }
            catch (Exception e){
                MessageBox.Show(e.Message);            
                //DuesPage duesPage = new DuesPage();
                //duesPage.Show();
            } 
            

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

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            _member1.TcKimlik = txtTcKimlik.Text.Trim();
            _member1.FirstName = txtFirstName.Text.Trim();
            _member1.LastName = txtLastname.Text.Trim();
            _member1.Email = txtMail.Text.Trim();
            _member1.UserPassword = txtPassword.Text.Trim();
            _member1.BloodTypeId = cbxBloodType.SelectedValue.ToString();
            _member1.CityId = cbxCity.SelectedValue.ToString();
            _member1.IsActive = rdbtnActive.Checked ? true : false;
            _member1.IsAdmin = chcIsAdmin.Checked ? true : false;
            _member1.DebtAmount = 0;
            _member1.DuesAmount = _dues.DuesAmount;


            //aidatın son günü hesaplanıyor
            DateTime bugun = DateTime.Today;
            DateTime ilkGun = new DateTime(_dues.DuesYear, _dues.DuesMonth, 1);
            int ayinGunSayisi = DateTime.DaysInMonth(_dues.DuesYear, _dues.DuesMonth);
            DateTime sonGun = ilkGun.AddDays(ayinGunSayisi-1);
            DateTime sonGunSaat2359 = sonGun.AddHours(23).AddMinutes(59);


            //aidatın ödeneceği son gün atanıyor,
            //aidat hangi ayda ise o ayın son gününün son dakikasına kadar ödenebilir.
            _member1.DueDate = sonGunSaat2359;

            try
            {
                _memberService.Add(_member1);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
