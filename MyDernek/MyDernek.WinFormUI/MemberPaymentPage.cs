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
    public partial class MemberPaymentPage : Form
    {
        private Member _member;
        private IMemberService _memberService;
        private IMemberPaymentStatusService _paymentService;

        public string conString = @"Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\MyDernekDb.accdb";
        
        public MemberPaymentPage(Member member)
        {
            InitializeComponent();
            _member = member;
            _memberService = new MemberManager(conString);
            _paymentService = new MemberPaymentStatusManager(conString);
        }

        private void MemberPaymentPage_Load(object sender, EventArgs e)
        {
            label1.Text = _member.FirstName + " Adlı Kullanıcının Geçmiş Ödemeleri";
            dataGridView1.DataSource = _paymentService.GetMemberPaymentStatus(_member.TcKimlik)
                .Select(m => new {
                    m.TcKimlik,
                    m.Member.FirstName,
                    m.Member.LastName,
                    m.Member.Email,
                    m.AmountPaid,
                    m.PaymentDate,
                }).ToList();
            
        }
    }
}
