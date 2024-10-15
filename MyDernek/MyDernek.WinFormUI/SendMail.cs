using MyDernek.DataAccess.Concrete;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDernek.WinFormUI
{
    public partial class SendMail : Form
    {
        private List<Member> _members;
        private Member _admin;
        private string _message;
        public event EventHandler SecondFormClosed;
        private string conString = @"Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\MyDernekDb.accdb";

        private Database database;

        public SendMail(List<Member> members, Member admin)
        {
            InitializeComponent();
            _admin = admin;
            _members = members;
            this.FormClosed += SecondForm_FormClosed;
            database = new Database(conString);
        }

        private void SendMail_Load(object sender, EventArgs e)
        {
            _message = database.GetDebthMessage();
            txtMessage.Text = _message.ToString();
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

        private void btnMessageUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                database.UpdateMessage(txtMessage.Text.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < _members.Count; i++)
            {

                try
                {
                    MailMessage EPosta = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    smtp.Credentials = new System.Net.NetworkCredential("seninepostagir@outlook.com", "seninşifregirs");
                    smtp.Port = 587;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.EnableSsl = true;


                    EPosta.To.Add(_members[i].Email.ToString());
                    EPosta.From = new MailAddress("seninepostagir@outlook.com");
                    EPosta.Subject = "Dernek Borç Gecikmesi";
                    EPosta.Body =  txtMessage.Text.ToString();



                    smtp.Send(EPosta);
                }catch(Exception ex)
                {
                    MessageBox.Show("HATA" + i.ToString() + ". mail gönderilemedi!");
                }
            }
            MessageBox.Show("Toplu Mail Gönderme İşlemi Başarılı.");

            this.Close();

        }
    }
}
