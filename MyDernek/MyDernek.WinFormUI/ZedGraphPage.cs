using MyDernek.Business.Abstract;
using MyDernek.Business.Concrete;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace MyDernek.WinFormUI
{
    public partial class ZedGraphPage : Form
    {
        private IMemberPaymentStatusService _memberPaymentStatusService;
        public ZedGraphPage(string conString)
        {
            InitializeComponent();
            _memberPaymentStatusService = new MemberPaymentStatusManager(conString);
        }

        private void ZedGraphPage_Load(object sender, EventArgs e)
        {
            //veritabanındaki yılların benzersiz değerleri combobaxa yüklenmesi ve DrawBoxPlot fonksiyonuna seçilen ayın gönderilmesi
            comboBoxYears.DataSource = _memberPaymentStatusService.GetAll().Select(p => p.PaymentDate.Year).Distinct().ToList();
            comboBoxYears.SelectedIndex = 0;
            DrawBoxPlot(zedGraphControlPaymentStatus, (int)comboBoxYears.SelectedItem, _memberPaymentStatusService.GetAll());



        }
        private void DrawBoxPlot(ZedGraphControl zedGraphControl, int selectedYear, List<MemberPaymentStatus> paymentStatusData)
        {
            // Seçilen yıla ait verileri filtrele
            var selectedYearData = paymentStatusData
                .Where(data => data.PaymentDate.Year == selectedYear)
                .ToList();

            // Aylara göre toplam geliri hesapla
            var monthlyTotal = new double[12];
            foreach (var payment in selectedYearData)
            {
                int monthIndex = payment.PaymentDate.Month - 1; // Ay indeksi 0'dan başladığı için 1 çıkartıyoruz
                monthlyTotal[monthIndex] += (double)payment.AmountPaid;
            }

            // ZedGraphControl için GraphPane oluştur
            GraphPane graphPane = zedGraphControl.GraphPane;
            graphPane.CurveList.Clear(); // Var olan grafiği temizle

            // Kutuları oluştur
            var boxes = new BoxObj[12];
            for (int i = 0; i < 12; i++)
            {
                double boxWidth = 0.8; // Kutu genişliği
                double boxSpacing = 0.2; // Kutular arası boşluk
                double boxX = i + 1 + i * boxSpacing - boxWidth / 2;

                boxes[i] = new BoxObj(boxX, monthlyTotal[i], boxWidth, monthlyTotal[i], Color.Black, Color.Aqua);
                graphPane.GraphObjList.Add(boxes[i]);
            }

            // Eksen ayarları
            graphPane.XAxis.Scale.TextLabels = new[] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            graphPane.XAxis.Scale.Max = 13;
            graphPane.XAxis.Type = AxisType.Text;
            
            //y eksenindeki değerlerin virgülden sonra 2 basamak gösterilmesi, 1000 ler basamağına virgül konulması ve TL sembolünün eklenmesi
            graphPane.YAxis.Scale.Format = "0.00 ₺";

            
            //y ekseni ve x ekseni sahip olduğu kutulara göre sclenin ayarlanması
            graphPane.YAxis.Scale.Max = monthlyTotal.Max() + 100;
            graphPane.YAxis.Scale.Min = monthlyTotal.Min() - 100;
            //açılışta y ekseni otomatik olarak ölçeklendirilmesi
            graphPane.YAxis.Scale.MinAuto = true;
            graphPane.YAxis.Scale.MaxAuto = true;
            
            

            // Eksen başlıkları
            graphPane.Title.Text = $"{selectedYear} Yılı Aylara Göre Toplam Gelir Grafiği";
            graphPane.XAxis.Title.Text = "Aylar";
            graphPane.YAxis.Title.Text = "Toplam Gelir (TL)";

           

            zedGraphControl.Refresh();
            
        }



        private void comboBoxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobaxın indexi değiştiğinde DrawBoxPlot fonksiyonuna seçilen ayın gönderilmesi ve eski çizimi silip yeniden çizilmesi
            
            DrawBoxPlot(zedGraphControlPaymentStatus, (int)comboBoxYears.SelectedItem, _memberPaymentStatusService.GetAll());


        }
    }
}
