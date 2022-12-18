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
    public partial class AddCustomerPanel : Form
    {
        public AddCustomerPanel()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            FIOtxtbox.Text = telephonetxtbox.Text = adresstxtbox.Text = emailtxtbox.Text = "";
            Close(); //закрываем текущую форму
            CustomersControl CustomersControl = new CustomersControl(); //открываем форму
            CustomersControl.Show();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            if (FIOtxtbox.Text == "" || telephonetxtbox.Text == "" || adresstxtbox.Text == "")
            {
                MessageBox.Show("Пропущен один из обязательных параметров!");
            }
            else
            {
                DBConnection.AddCustomer(FIOtxtbox.Text, telephonetxtbox.Text, adresstxtbox.Text, emailtxtbox.Text);
                MessageBox.Show("Покупатель успешно добавлен!");
                FIOtxtbox.Text = telephonetxtbox.Text = adresstxtbox.Text = emailtxtbox.Text = "";
            }
        }

        private void AddCustomerPanel_Load(object sender, EventArgs e)
        {
            FIOtxtbox.Text = telephonetxtbox.Text = adresstxtbox.Text = emailtxtbox.Text = "";
        }

        private void cltButton_Click(object sender, EventArgs e)
        {
            FIOtxtbox.Text = telephonetxtbox.Text = adresstxtbox.Text = emailtxtbox.Text = "";
            MessageBox.Show("Успешно очищено!");
        }
    }
}
