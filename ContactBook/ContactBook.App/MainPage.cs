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
                addList();
            }
            else
            {
                MessageBox.Show("Something wrong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lst_list_DoubleClick(object sender, EventArgs e)
        {
            ListBox LST = (ListBox)sender;
            contacts clickedContact = (contacts)LST.SelectedItem;
            //MessageBox.Show(clickedContact.cName);

            if (clickedContact != null)
            {
                txt_update_name.Text = clickedContact.cName;
                txt_update_surname.Text = clickedContact.cSurname;
                txt_update_number1.Text = clickedContact.numberI;
                txt_update_number2.Text = clickedContact.numberII;
                txt_update_number3.Text = clickedContact.numberIII;
                txt_update_email.Text = clickedContact.emailAdress;
                txt_update_webadress.Text = clickedContact.webAdress;
                txt_update_adress.Text = clickedContact.adress;
                txt_update_info.Text = clickedContact.info;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Guid id = ((contacts)lst_list.SelectedItem).id;
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            int ReturnValues = BLL.updateRecord(id,txt_update_name.Text, txt_update_surname.Text, txt_update_number1.Text, txt_update_number2.Text, txt_update_number3.Text,txt_update_email.Text,txt_new_webadress.Text,txt_update_adress.Text,txt_update_info.Text);
            if (ReturnValues>0)
            {
                MessageBox.Show("Successful!! Record Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addList();
            }
            else
            {
                MessageBox.Show("Something wrong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Guid id = ((contacts)lst_list.SelectedItem).id;
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            int ReturnValues = BLL.deleteContact(id);
            if (ReturnValues > 0)
            {
                MessageBox.Show("Successful!! Record Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addList();
            }
            else
            {
                MessageBox.Show("Something wrong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lst_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 