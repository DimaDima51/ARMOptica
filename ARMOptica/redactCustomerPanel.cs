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
    public partial class redactCustomerPanel : Form
    {

        public redactCustomerPanel()
        {
            InitializeComponent();
        }
        private void redactCustomerPanel_Load(object sender, EventArgs e)
        {
            DBConnection.GetCustomerList(); //получение списка пользователей
            dgCustomers.DataSource = DBConnection.dtCustomers; //привязка набора данных к таблице
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            CustomersControl CustomersControl = new CustomersControl(); //открываем форму
            CustomersControl.Show();
            idCustomertxtbox.Text = FIOtxtbox.Text = telephonetxtbox.Text = adresstxtbox.Text = emailtxtbox.Text = "";
        }

        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCustomertxtbox.Text = dgCustomers.CurrentRow.Cells[0].Value.ToString();
            FIOtxtbox.Text = dgCustomers.CurrentRow.Cells[1].Value.ToString();
            telephonetxtbox.Text = dgCustomers.CurrentRow.Cells[2].Value.ToString();
            adresstxtbox.Text = dgCustomers.CurrentRow.Cells[3].Value.ToString();
            emailtxtbox.Text = dgCustomers.CurrentRow.Cells[4].Value.ToString();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            if (idCustomertxtbox.Text == "" || FIOtxtbox.Text == "" || telephonetxtbox.Text == "" || adresstxtbox.Text == "")
            {
                MessageBox.Show("Пропущен один из обязательных параметров!");
            }
            else
            {
                DBConnection.redactCustomer(idCustomertxtbox.Text, FIOtxtbox.Text, telephonetxtbox.Text, adresstxtbox.Text, emailtxtbox.Text);
                MessageBox.Show("Покупатель успешно отредактирован!");
                DBConnection.GetCustomerList(); //получение списка пользователей
                dgCustomers.DataSource = DBConnection.dtCustomers; //привязка набора данных к таблице
                idCustomertxtbox.Text = FIOtxtbox.Text = telephonetxtbox.Text = adresstxtbox.Text = emailtxtbox.Text = "";
            }
        }
    }
}
