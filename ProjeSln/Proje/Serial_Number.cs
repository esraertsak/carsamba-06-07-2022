using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Proje
{
    public partial class Serial_Number : Form
    {
        //ID variable used in Updating and Deleting Record  
       // int id=0;
        int revizyon=1;
        

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ASFN1BE;Initial Catalog=PCB;Integrated Security=True");
        SqlCommand komut,komut2;
    
        public Serial_Number()
        {
            InitializeComponent();
            DisplayData();


        }
        //GRIDVIEWDE DATA GÖSTERME
        private void DisplayData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT seri.seri_no, seri.test_tarihi, seri.test_operator,revizyon.test_revizyon_no FROM revizyon INNER JOIN seri ON revizyon.seri_no = seri.seri_no",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }


        //DATA TEMİZLEME 
        private void ClearData()
        {
            textEditID.Text = "";
            textEditserino.Text = "";
            textEditRevizyonno.Text = "";
            dateTimePicker1.Text = "";
            textEditoperator.Text = "";

        }
        //EKLEME
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

            if (textEditserino.Text != "" && dateTimePicker1.Text != "" && textEditoperator.Text != "")
            {
                komut = new SqlCommand("insert into seri(seri_no,test_tarihi,test_operator) values(@seri_no,@tarih,@operator)", baglanti);   
                baglanti.Open();

                komut.Parameters.AddWithValue("@seri_no", textEditserino.Text);         
                komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@operator", textEditoperator.Text);
                komut.ExecuteNonQuery();

                komut2 = new SqlCommand("insert into revizyon(seri_no,test_revizyon_no,rev_seri_no) values(@serino,@revizyon,@rev_seri_no)", baglanti);
                komut2.Parameters.AddWithValue("@serino", textEditserino.Text);
                komut2.Parameters.AddWithValue("@revizyon", textEditRevizyonno.Text);
                komut2.Parameters.AddWithValue("@rev_seri_no", $"{textEditserino.Text}.{(Convert.ToInt32(textEditRevizyonno.Text) + 1).ToString()}");
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt başarılı!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Lütfen detayları sağlayın !");

            }
        }

        //GÜNCELLEME
        private void simpleButton3_Click_1(object sender, EventArgs e)
        {

            if (textEditID.Text != "" && textEditserino.Text != "" && dateTimePicker1.Text != "" && textEditoperator.Text != "")
            {
                komut = new SqlCommand("update seri set  seri_no=@seri_no, test_tarihi=@tarih ,test_operator=@operator  where id=@id", baglanti);
                komut2 = new SqlCommand(" update revizyon set test_revizyon_no = @revizyon where seri_no = (select top 1 seri_no from revizyon where seri_no = @serino order by test_revizyon_no desc)", baglanti);
 
                 //komut2 = new SqlCommand("update revizyon set  test_revizyon_no=@revizyon where id=@id", baglanti);
                
                baglanti.Open();
               // komut.Parameters.AddWithValue("@id", textEditID.Text);
                komut.Parameters.AddWithValue("@seri_no", textEditserino.Text);                               
                komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@operator", textEditoperator.Text);
                komut.ExecuteNonQuery();


                komut2.Parameters.AddWithValue("@serino", textEditserino.Text);
                komut2.Parameters.AddWithValue("@revizyon", textEditRevizyonno.Text);
                komut2.ExecuteNonQuery();

                MessageBox.Show("Başarılı bir şekilde güncellendi!");
                baglanti.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir sütun seçin!");
            }

        }

        public class TestClass
        {

            public string seri_no { get; set; }
            public string test_revizyon_no { get; set; }
            public DateTime test_tarihi { get; set; }
            public string test_operator { get; set; }
        }
   

        //SİLME
        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            string seri_no = textEditserino.Text;
            if (seri_no != null && seri_no != "")
            {
                baglanti.Open();
                komut2 = new SqlCommand("delete from revizyon where seri_no=@serino", baglanti);
                komut2.Parameters.AddWithValue("@serino", seri_no);
                komut2.ExecuteNonQuery();
               

                komut = new SqlCommand("delete from seri where seri_no=@serino", baglanti);                           
                komut.Parameters.AddWithValue("@serino", seri_no);
                komut.ExecuteNonQuery();
                baglanti.Close();


                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }
        


        private void Serial_Number_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void gridViewserino_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

           // textEditID.EditValue = gridViewserino.GetFocusedRowCellValue("id");
            textEditserino.EditValue = gridViewserino.GetFocusedRowCellValue("seri_no");
            textEditRevizyonno.EditValue = gridViewserino.GetFocusedRowCellValue("test_revizyon_no");
            dateTimePicker1.Value =DateTime.Parse( gridViewserino.GetFocusedRowCellValue("test_tarihi").ToString());
            textEditoperator.EditValue = gridViewserino.GetFocusedRowCellValue("test_operator");
           // id = Convert.ToInt32(textEditID.EditValue);
        }

        public void mesaj() 
        {
            if (this.gridViewserino.GetFocusedRowCellValue("test_revizyon_no") == null)

                return;
            MessageBox.Show("Revizyon No: " + this.gridViewserino.GetFocusedRowCellValue("test_revizyon_no"));
            
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            TestEnvironment gecis = new TestEnvironment(this);
            gecis.Show();
            this.Hide();
        }



        private void gridViewserino_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRow dr = gridViewserino.GetDataRow(gridViewserino.FocusedRowHandle);
            if (dr != null)
            {

               // textEditID.Text = dr[0].ToString();
                textEditserino.Text = dr[1].ToString();
                textEditRevizyonno.Text = dr[2].ToString();
                dateTimePicker1.Value = DateTime.Parse(dr[3].ToString());
                textEditoperator.Text = dr[4].ToString();

               // id = Convert.ToInt32(dr[0].ToString());
                revizyon = Convert.ToInt32(dr[2].ToString());


            }
        }
    }
}
