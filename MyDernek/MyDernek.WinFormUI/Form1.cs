using MyDernek.Business.Concrete;
using MyDernek.DataAccess.Concrete.AdoNet;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDernek.WinFormUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public static List<string> GenerateUniqueTCKimlikNumbers(int count)
        {
            List<string> tcKimlikNumbers = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string randomTCKimlik = GenerateRandomTCKimlik();

                // Eğer üretilen TC kimlik numarası daha önce eklenmediyse listeye ekle
                if (!tcKimlikNumbers.Contains(randomTCKimlik))
                {
                    tcKimlikNumbers.Add(randomTCKimlik);
                }
                else
                {
                    // Eğer aynı TC kimlik numarası zaten varsa, bir daha üret
                    i--;
                }
            }

            return tcKimlikNumbers;
        }

        private static string GenerateRandomTCKimlik()
        {
            Random random = new Random();

            // İlk 9 rakamı rastgele seç
            int firstNineDigits = random.Next(100000000, 999999999);

            // 10. rakam için tek ya da çift olma koşuluyla rastgele seç
            int tenthDigit = random.Next(0, 9);
            tenthDigit = (tenthDigit % 2 == 0) ? tenthDigit : tenthDigit + 1;

            // 11. rakam için, ilk 10 rakamın toplamının 10'a göre modunu al
            int sum = firstNineDigits.ToString().Select(c => int.Parse(c.ToString())).Sum();
            int eleventhDigit = (sum % 10 == 0) ? 0 : 10 - (sum % 10);

            return $"{firstNineDigits:D9}{tenthDigit}{eleventhDigit}";
        }

        private string GenerateRandomName()
        {
            // Rasgele bir isim üretme
            string[] names = { "Ahmet", "Mehmet", "Ayşe", "Fatma", "Mustafa", "Can", "Elif", "Ali", "Zeynep" };
            return names[new Random().Next(names.Length)];
        }
        private string GenerateRandomSurName()
        {
            // Rasgele bir soy isim üretme
            string[] names = { "ŞEN", "KANDEMİR", "ÇEVİK", "ERKURAN", "TÜTEN",
                "ÖZTÜRK", "YÜZBAŞIOĞLU", "VURAL", "YÜCEL", "SÖNMEZ"
            };
            return names[new Random().Next(names.Length)];
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = @"Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\MyDernekDb.accdb";

            MemberManager memberManager = new MemberManager(conString);
            dataGridView1.DataSource = memberManager.GetAll().Select(m => new {
                m.TcKimlik,
                m.FirstName,
                m.LastName,
                m.Email,
                m.UserPassword,
                m.BloodType.TypeName,
                m.City.CityName,
                m.DebtAmount,
                m.DuesAmount,
                m.DueDate,
                m.IsActive,
                m.IsAdmin
            }).ToList();



        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //Veritabanındaki Member City ve Bloodtype tablolarını birleştirip listeleme
            string conString = @"Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\MyDernekDb.accdb";

            MemberRepository memberRepository = new MemberRepository(conString);
            dataGridView1.DataSource = memberRepository.GetAll().Select(m=> new {
                m.TcKimlik, 
                m.FirstName, 
                m.LastName,
                m.Email,
                m.UserPassword,
                m.BloodType.TypeName,
                m.City.CityName,
                m.DebtAmount,
                m.DuesAmount,
                m.DueDate,
                m.IsActive,
                m.IsAdmin
            }).ToList();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            List<string> tcKimlikNumbers = GenerateUniqueTCKimlikNumbers(30);

            List<Member> members = new List<Member>();

            for (int i = 0; i < 30; i++)
            {
                var firstName = GenerateRandomName();
                var lastName = GenerateRandomSurName();

                Member member = new Member
                {
                    TcKimlik = tcKimlikNumbers[i],
                    FirstName = firstName,
                    LastName = lastName,
                    BloodTypeId = "A-",
                    CityId = "47",
                    IsActive = true,
                    IsAdmin = true,
                    UserPassword = "123456",
                    Email = "mail@gmail.com",
                    DuesAmount = 14,
                    DueDate = DateTime.Now,
                    DebtAmount = 14
                };
                members.Add(member);

            }

            string conString = @"Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\MyDernekDb.accdb";

            MemberRepository memberRepository = new MemberRepository(conString);
            foreach (Member member in members)
            {
                memberRepository.Add(member);
            }
        }
    }
}
