using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        
        private void MenuPage_Load(object sender, EventArgs e)
        {

        }

        private void BtnTestOrtami_Click(object sender, EventArgs e)
        {
           TestEnvironment gecis = new TestEnvironment(new Serial_Number());
            gecis.Show();
            this.Hide();
        }

     

        private void btncikisMenupage_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış yapmak mı istiyorsunuz?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();

        }
    }
}
