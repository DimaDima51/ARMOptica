using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMOptica
{
    public partial class CustomersControl : Form
    {
        public CustomersControl()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            HeadForm HeadForm = new HeadForm(); //открываем форму
            HeadForm.Show();
        }

        private void CustomersControl_Load(object sender, EventArgs e)
        {
            DBConnection.GetCustomerList(); //получение списка пользователей
            dgCustomers.DataSource = DBConnection.dtCustomers; //привязка набора данных к таблице
            FIOtxtbox.Text = telephonetxtbox.Text = emailtxtbox.Text = adresstxtbox.Text = "";
        }

        private void showCustomerAddPanel_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            AddCustomerPanel AddCustomerPanel = new AddCustomerPanel(); //открываем форму
            AddCustomerPanel.Show();
        }

        private void showredactCustomerPanel_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            redactCustomerPanel redactCustomerPanel = new redactCustomerPanel(); //открываем форму
            redactCustomerPanel.Show();
        }

        private void cancelSortButton_Click(object sender, EventArgs e)
        {
            DBConnection.GetCustomerList(); //получение списка пользователей
            dgCustomers.DataSource = DBConnection.dtCustomers; //привязка набора данных к таблице
            FIOtxtbox.Text = telephonetxtbox.Text = emailtxtbox.Text = adresstxtbox.Text = "";
        }

        private void sortSureButton_Click(object sender, EventArgs e)
        {
            DBConnection.GetCustomerList(FIOtxtbox.Text, telephonetxtbox.Text, adresstxtbox.Text, emailtxtbox.Text); //получение списка пользователей
            dgCustomers.DataSource = DBConnection.dtCustomers; //привязка набора данных к таблице
        }
    }
}
