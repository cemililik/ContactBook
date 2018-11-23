using ContactBook.Entities;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_add_contact_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            int ReturnValues = BLL.addRecord(txt_new_name.Text, txt_new_surname.Text, txt_new_number1.Text, txt_new_number2.Text, txt_new_number3.Text, txt_new_email.Text, txt_new_webadress.Text, txt_new_adress.Text, txt_new_info.Text);
            if(ReturnValues>0)
            {
                MessageBox.Show("Successful!! New Record Added","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu işte bir iş var", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_new_name.Text = "";
            txt_new_surname.Text = "";
            txt_new_number1.Text = "";
            txt_new_number2.Text = "";
            txt_new_number3.Text = "";
            txt_new_email.Text = "";
            txt_new_webadress.Text = "";
            txt_new_adress.Text = "";
            txt_new_info.Text = "";
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            addList();
        }

        private void addList()
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            List<contacts> ContactList = BLL.listContact();

            if(ContactList != null && ContactList.Count>0)
            {
                lst_list.DataSource = ContactList;
            }
        }

    }
}
 