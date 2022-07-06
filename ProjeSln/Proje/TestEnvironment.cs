using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
using DevExpress.Utils.Gesture;

namespace Proje
{
    public partial class TestEnvironment : Form
    {
       
        SqlConnection baglanti;
        SqlDataReader dr;
        SqlCommand komut;
        Serial_Number es;
        
        public TestEnvironment(Serial_Number seri)
        {
            InitializeComponent();
            es = seri;
        }
    

        private void TestEnvironment_Load(object sender, EventArgs e)
        {
          
           
            foreach (var seriPort in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(seriPort);
            }
            comboBoxPorts.SelectedIndex = 0;
            groupControlasama2.Hide();
            groupControl3.Hide();
            groupControl4asama.Hide();

            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxPorts.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.Even;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            try
            {
                serialPort1.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Seri port bağlantısı yapılmadı.\n Hata: { ex.Message}",  "Problem",  MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            if (serialPort1.IsOpen)
            {
                simpleButtonbaglan.Enabled = false;
                groupControlasama2.Show();
                groupControlasama1.Hide();
                

            }
           


        }

 
        // oku butonu tıklandığı zaman seri no aynı ise messagebox cıkar. if messagebox == yes test-rev-no bir artar ardından sql de setup tablede bir rowa
        // seri no + 1 yazılır.

        private void simpleButtonOku_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source=DESKTOP-ASFN1BE;Initial Catalog=PCB;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM revizyon WHERE seri_no='" + textEditSeriNo.Text + "'", baglanti);

            dr = komut.ExecuteReader();
            dr.Read();
            {
                if (dr.HasRows == true)
                {
                    DialogResult dialog = MessageBox.Show("Kart önceden test edildi!\n Tekrar test etmek istiyor musunuz?", "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialog == DialogResult.Yes)
                    {
                        groupControlasama2.Hide();
                        groupControl3.Show();


                        //test_revizyon_no bir attığı yer ve seri_no + artan sayı rev_seri_no kolonuna yazılır.
                        string yourserino = textEditSeriNo.Text;
                        baglanti = new SqlConnection(@"Data Source=DESKTOP-ASFN1BE;Initial Catalog=PCB;Integrated Security=True");
                        baglanti.Open();


                        // komut = new SqlCommand("update seri set test_revizyon_no=test_revizyon_no + 1 where seri_no='" + yourserino + "';", baglanti);
                        //komut = new SqlCommand("update revizyon set test_revizyon_no=test_revizyon_no + 1 where seri_no='" + yourserino + "';", baglanti);
                        //var dr1 = komut.ExecuteNonQuery();


                        //// komut = new SqlCommand("update seri set rev_seri_no = seri_no + '.' + CONVERT(nvarchar(50), test_revizyon_no) where seri_no='"+yourserino+"';", baglanti);
                        //komut = new SqlCommand("update revizyon set rev_seri_no = seri_no + '.' + CONVERT(nvarchar(50), test_revizyon_no) where seri_no='" + yourserino + "';", baglanti);
                        //var dr2 = komut.ExecuteNonQuery();

                       // komut = new SqlCommand("SELECT IsNull( MAX (test_revizyon_no),0) test_revizyon_no FROM revizyon WHERE seri_no='" + yourserino + "'", baglanti);
                       var  komut = new SqlCommand("select top 1  test_revizyon_no from revizyon where seri_no ='" + yourserino + "'order by test_revizyon_no desc",baglanti);
                        var dr3 = komut.ExecuteScalar();
                       int dr5  = dr3 != null ? Convert.ToInt32(dr3) : 0;
                      

                        //int  dr3 = (Convert.ToInt32(komut.ExecuteScalar()));


                     //   komut = new SqlCommand("INSERT INTO revizyon(seri_no,test_revizyon_no,rev_seri_no) values ('" + yourserino + "', '"+(dr5+1).ToString()+"','"+yourserino+"'.'"+(dr5+1).ToString()+"')",baglanti);                    // var dr4 = komut.ExecuteNonQuery();
                        komut = new SqlCommand("INSERT INTO revizyon(seri_no,test_revizyon_no,rev_seri_no) values (@serino,@revizyonno,@rev_seri_no)", baglanti);
                       
                        komut.Parameters.AddWithValue( "@serino", yourserino);
                        komut.Parameters.AddWithValue("@revizyonno", (dr5+1).ToString());
                        komut.Parameters.AddWithValue("@rev_seri_no", $"{yourserino}.{(dr5 + 1)}");
                        var dr4 = komut.ExecuteNonQuery();
                    }
                    else
                    {
                        groupControlasama1.Show();
                        this.Hide();
                    }
                   
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Böyle bir kart yoktur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            baglanti.Close();
        }

      




        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            MenuPage gecis = new MenuPage();
            gecis.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Voltage gecis = new Voltage();
            gecis.Show();
            this.Hide();
        }
    }
    }


