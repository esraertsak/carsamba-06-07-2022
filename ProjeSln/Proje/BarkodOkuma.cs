using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;

namespace Proje
{
    public partial class BarkodOkuma : Form
    {
        public BarkodOkuma()
        {
            InitializeComponent();
        }
        //FilterInfoCollection ve VideoCaptureDevice sınıfından nesnelerimi türettim. FilterInfoCollection cihazımdaki tüm kameraları, yakalama cihazlarını vs bulur. VideoCaptureDevice ise benim kullanacağım kamera için değişkenim olacak.
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;

        private void BarkodOkuma_Load(object sender, EventArgs e)
        {
            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //FilterInfo cihazdaki görüntü yakalama cihazları hakkında bilgi tutar.
            foreach (FilterInfo cihaz in Cihazlar)
            {
                comboBoxKamera.Items.Add(cihaz.Name);
            }
            //İlk bulduğu kamera ismi görünsün diye ilk atamayı yaptık, 0 verdik.
            comboBoxKamera.SelectedIndex = 0;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış yapmak mı istiyorsunuz?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {

            }
            if (kameram != null)
            {
                if (kameram.IsRunning)
                {
                    kameram.Stop();
                }
            }
        }
        //Kamerayı başlatmak için yazılan kodlar. NewFrame Her bir görüntü için yeni bir frame başlatır. 
        private void simpleButtonBasla_Click(object sender, EventArgs e)
        {
            kameram = new VideoCaptureDevice(Cihazlar[comboBoxKamera.SelectedIndex].MonikerString);

            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();
        }
        //Kullanılan cihazın metodunu oluşturuyorum
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap GoruntulenenBarkod = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader okuyucu = new BarcodeReader();
            var sonuc = okuyucu.Decode(GoruntulenenBarkod);

            if (sonuc != null)
            {
                textBox1.Invoke(new MethodInvoker(delegate ()
                {
                    textBox1.Text = sonuc.ToString();
                }
                ));
            }

            pictureBox1.Image = GoruntulenenBarkod;
        }

        private void comboBoxKamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
