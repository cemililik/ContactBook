using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBook.App
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //bll.Authentication(txt_Username.Text, txt_Password.Text);
            int ReturnValues =  bll.Authentication(txt_Username.Text, txt_Password.Text);
            //int ReturnValues = 0;
            if (ReturnValues > 0)
            {
                MainPage main = new MainPage();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password","Attention",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
