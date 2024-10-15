using iTextSharp.text;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyDernek.WinFormUI
{
    public partial class DuesPage : Form
    {
        private IDuesService _duesService;
        public DuesPage(string conString)
        {
            InitializeComponent();
            _duesService = new DuesManager(conString);
        }
        private void DuesPage_Load(object sender, EventArgs e)
        {
            //Aidat yıllarının comboboxa eklenmesi
            for(int i = DateTime.Now.Year; i<=DateTime.Now.Year+5;i++) 
            {
                cmbxYear.Items.Add(i);

            }

            //Aidat aylarının comboboxa eklenmesi
            cmbxMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cmbxMonth.Items.Add(i);
            }

            //Aidat yılı ve ayları veritabanından çekilip comboboxlara eklenmesi

            LoadCbxMonthAndYearUpdate();

            //cmbxYearUpdate.DataSource = _duesService.GetAll().Select(x => x.Year).Distinct().ToList();
            //cmbxMonthUpdate.DataSource = _duesService.GetAll().Select(x => x.Month).Distinct().ToList();


            dataGridView1.DataSource = _duesService.GetAll();

        }
        private void LoadCbxMonthAndYearUpdate()
        {
            var uniqueDuesYearsAndMonths = _duesService.GetAll();

            // Yılları içeren ComboBox
            cmbxYearUpdate.DataSource = uniqueDuesYearsAndMonths.Select(d => d.DuesYear).Distinct().ToList();

            // Ayları içeren ComboBox
            cmbxMonthUpdate.DataSource = uniqueDuesYearsAndMonths.Select(d => d.DuesMonth).Distinct().ToList();
        }

        
        private void cmbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbxYear_SelectedIndexChanged eventi çalıştığında aidat aylarının comboboxa eklenmesi
            lblMonth.Visible = true;
            cmbxMonth.Visible = true;

           
        }

        private void UpDownDuesAmount_ValueChanged(object sender, EventArgs e)
        {
            int selectedValue = (int)UpDownDuesAmountUpdate.Value;
            if (selectedValue < 0 || selectedValue > 100000)
            {
                UpDownDuesAmountUpdate.Value = Math.Max(0, Math.Min(100000, selectedValue));
            }
            btnDuesAdd.Visible = true;
        }

        private void btnDuesAdd_Click(object sender, EventArgs e)
        {

            try
            {
                int amount = Convert.ToInt32(UpDownDuesAmount.Value);
                int month = Convert.ToInt32(cmbxMonth.SelectedItem);
                int year = Convert.ToInt32(cmbxYear.SelectedItem);

                bool IsExist = _duesService.GetAll().Any(x => x.DuesYear == year && x.DuesMonth == month);

                if (!IsExist)
                {
                    _duesService.Add(new Dues
                    {
                        DuesAmount = amount,
                        DuesYear = year,
                        DuesMonth = month
                    });

                    MessageBox.Show("Aidat ekleme işlemi başarılı");
                    dataGridView1.DataSource = _duesService.GetAll();
                }
                else
                {
                    DialogResult dialogResult;
                    dialogResult = MessageBox.Show("Aidat Zaten Eklenmiş Düzenlemek İster Misiniz ?", "Zaten Var!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult.Equals(DialogResult.Yes)) 
                    {
                        groupBox2.Visible = true;
                        Dues dues = _duesService.Get(month, year);

                        cmbxYearUpdate.SelectedItem = dues.DuesYear;
                        cmbxMonthUpdate.SelectedItem = dues.DuesMonth;
                        UpDownDuesAmountUpdate.Value = dues.DuesAmount;

                       
                    }
                    else
                    {

                        MessageBox.Show("Lütfen Olmayan Bir Aidat Seçin.");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox2.Visible = true;
            btnDuesDelete.Visible = true;
            btnDuesDelete.Visible = true;

            int year = (int)dataGridView1.CurrentRow.Cells[1].Value;
            int month = (int)dataGridView1.CurrentRow.Cells[2].Value;

            Dues dues = _duesService.Get(month, year);

            cmbxYearUpdate.SelectedItem = dues.DuesYear;
            cmbxMonthUpdate.SelectedItem = dues.DuesMonth;
            UpDownDuesAmountUpdate.Value = dues.DuesAmount;
        }

        private void cmbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDuesAmount.Visible = true;
            UpDownDuesAmount.Visible = true;

        }

        private void btnDuesUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = (int)UpDownDuesAmountUpdate.Value;
                int year = Convert.ToInt32(cmbxYearUpdate.SelectedItem.ToString());
                int month = Convert.ToInt32(cmbxMonthUpdate.SelectedItem.ToString());

                Dues dues = _duesService.Get(month, year);
                if (dues!=null)
                {
                    dues.DuesAmount = amount;
                    dues.DuesMonth = month;
                    dues.DuesYear = year;
                    
                    _duesService.Update(dues);
                    
                    MessageBox.Show("Aidat Güncelleme İşlemi Başarılı");
                    
                    dataGridView1.DataSource = _duesService.GetAll();
                }
                else
                {
                    MessageBox.Show("Olmayan bir aidat güncellenemez lütfen ekleyiniz.");
                }
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDuesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int year = (int)dataGridView1.CurrentRow.Cells[1].Value;
                int month = (int)dataGridView1.CurrentRow.Cells[2].Value;

                Dues dues = _duesService.Get(month, year);
                if (dues!=null)
                {
                    
                    _duesService.Delete(dues);
                    MessageBox.Show("Aidat silme işlemi başarılı.");
                    dataGridView1.DataSource = _duesService.GetAll();
                }
                else
                {
                    MessageBox.Show("Olmayan bir aidat silinemez lütfen ekleyiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpDownDuesAmount_Click(object sender, EventArgs e)
        {
            btnDuesAdd.Visible = true;
        }
    }
}
