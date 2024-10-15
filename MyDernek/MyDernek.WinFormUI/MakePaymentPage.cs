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
    public partial class MakePaymentPage : Form
    {
        private Member _member;
        bool _borcmu;
        private IMemberPaymentStatusService _memberPaymentStatusManager;
        private IMemberService _memberManager;
        private readonly string conString = @"Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\MyDernekDb.accdb";
        public MakePaymentPage(Member member, bool borcmu)
        {
            InitializeComponent();
            _member = member;
            _borcmu = borcmu;
            _memberPaymentStatusManager = new MemberPaymentStatusManager(conString);
            _memberManager = new MemberManager(conString);
        }

        private void MakePaymentPage_Load(object sender, EventArgs e)
        {
            if (_borcmu)
            {
                lblBaslik.Text = "Borç Ödeme Sayfası";
                lblBorcAidat.Text = "Borç: " + _member.DebtAmount.ToString();
            }
            else
            {
                lblBaslik.Text = "Aidat Ödeme Sayfası";
                lblBorcAidat.Text = "Aidat: " + _member.DuesAmount.ToString();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal sum = Convert.ToDecimal(txtSum.Text.Trim());
                        
            if (_borcmu)
            {
                if (sum > _member.DebtAmount)
                {
                    MessageBox.Show("Girdiğiniz tutar borcunuzdan fazla olamaz.");
                }
                else
                {
                    _member.DebtAmount -= sum;
                    _memberManager.Update(_member);
                    _memberPaymentStatusManager.Add(new MemberPaymentStatus
                    {
                        TcKimlik = _member.TcKimlik,
                        PaymentDate = DateTime.Now,
                        AmountPaid = sum
                    });
                    MessageBox.Show("Borç ödeme işlemi başarıyla gerçekleşti.");
                    this.Close();
                }
            }
            else
            {
                if (sum > _member.DuesAmount)
                {
                    MessageBox.Show("Girdiğiniz tutar aidatınızdan fazla olamaz.");
                }
                else
                {
                    _member.DuesAmount -= sum;
                    _memberManager.Update(_member);
                    _memberPaymentStatusManager.Add(new MemberPaymentStatus
                    {
                        TcKimlik = _member.TcKimlik,
                        PaymentDate = DateTime.Now,
                        AmountPaid = sum,
                    });
                    MessageBox.Show("Aidat ödeme işlemi başarıyla gerçekleşti.");
                    this.Close();
                }
            }
            
        }
    }
}
