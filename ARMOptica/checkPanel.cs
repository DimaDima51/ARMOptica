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
    public partial class checkPanel : Form
    {
        public string buyer = "";
        public string tovarBuy = "";
        public string saleID = "1";
        public decimal price;
        public checkPanel()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            buyer = tovarBuy = "";
            saleID = "1";
            Close(); //закрываем текущую форму
            HeadForm HeadForm = new HeadForm(); //открываем форму
            HeadForm.Show();
        }

        private void checkPanel_Load(object sender, EventArgs e)
        {
            buyer = tovarBuy = "";
            sortCustomertxtbx.Text = sortTovartxtbx.Text = "";
            saleID = "1";
            DBConnection.GetCustomersForCheck(sortCustomertxtbx.Text); //получение списка
            dgCustomers.DataSource = DBConnection.dtCustomersForCheck; //привязка набора данных к таблице

            DBConnection.GetTovarForCheck(sortTovartxtbx.Text); //получение списка
            dgStore.DataSource = DBConnection.dtTovarForCheck; //привязка набора данных к таблице

            DBConnection.GetDiscounts(); //получение списка
            dgSales.DataSource = DBConnection.dtDiscounts; //привязка набора данных к таблице
        }

        private void sureButton1_Click(object sender, EventArgs e)
        {
            DBConnection.GetCustomersForCheck(sortCustomertxtbx.Text); //получение списка
            dgCustomers.DataSource = DBConnection.dtCustomersForCheck; //привязка набора данных к таблице
        }

        private void sureButton2_Click(object sender, EventArgs e)
        {
            DBConnection.GetTovarForCheck(sortTovartxtbx.Text); //получение списка
            dgStore.DataSource = DBConnection.dtTovarForCheck; //привязка набора данных к таблице
        }

        private void clnButton1_Click(object sender, EventArgs e)
        {
            sortCustomertxtbx.Text = "";
            DBConnection.GetCustomersForCheck(sortCustomertxtbx.Text); //получение списка
            dgCustomers.DataSource = DBConnection.dtCustomersForCheck; //привязка набора данных к таблице
        }

        private void clnButton2_Click(object sender, EventArgs e)
        {
            sortTovartxtbx.Text = "";
            DBConnection.GetTovarForCheck(sortTovartxtbx.Text); //получение списка
            dgStore.DataSource = DBConnection.dtTovarForCheck; //привязка набора данных к таблице
        }

        private void dgSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            saleID = dgSales.CurrentRow.Cells[0].Value.ToString();
            saleTxtBx.Text = dgSales.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buyer = dgCustomers.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgStore_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tovarBuy = dgStore.CurrentRow.Cells[0].Value.ToString();
            price = Convert.ToDecimal(dgStore.CurrentRow.Cells[3].Value.ToString());
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(countBuytxtbx.Text) <= 0 || buyer == "" || tovarBuy == "")
            {
                MessageBox.Show("Не корректно введены данные!");
            }
            else
            {
                dgCustomers.Enabled = false;
                dgSales.Enabled = false;
                dgStore.Enabled = false;
                countBuytxtbx.Enabled = false;
                decimal count = Convert.ToDecimal(countBuytxtbx.Text);
                decimal sale = Convert.ToDecimal(saleTxtBx.Text) / 100;
                priceTxtbx.Text = Convert.ToString((price * count) - (price * count * sale));
                addCheckBtn.Enabled = true;
                calculateButton.Enabled = false;
            }
        }

        private void cltButton_Click(object sender, EventArgs e)
        {
            buyer = tovarBuy = priceTxtbx.Text = "";
            countBuytxtbx.Text = "1";
            saleTxtBx.Text = "0";
            saleID = "1";
            addCheckBtn.Enabled = false;
            dgCustomers.Enabled = true;
            dgSales.Enabled = true;
            dgStore.Enabled = true;
            countBuytxtbx.Enabled = true;
            calculateButton.Enabled = true;
        }

        private void addCheckBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(countBuytxtbx.Text) <= 0 || buyer == "" || tovarBuy == "" || priceTxtbx.Text == "")
            {
                MessageBox.Show("Не корректно введены данные!");
            }
            else
            {
                DBConnection.addCheck(tovarBuy, DBConnection.idWorker, buyer, countBuytxtbx.Text, saleID, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                MessageBox.Show("Чек успешно сформирован!");
                dgCustomers.Enabled = true;
                dgSales.Enabled = true;
                dgStore.Enabled = true;
                countBuytxtbx.Enabled = true;
                calculateButton.Enabled = true;
                addCheckBtn.Enabled = false;
            }
        }

        private void countBuytxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }
    }
}
