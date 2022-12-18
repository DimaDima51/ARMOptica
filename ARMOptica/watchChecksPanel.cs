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
    public partial class watchChecksPanel : Form
    {
        public watchChecksPanel()
        {
            InitializeComponent();
        }

        private void checksPanel_Load(object sender, EventArgs e)
        {
            DBConnection.GetChecks(); //получение списка пользователей
            dgChecks.DataSource = DBConnection.dtChecks; //привязка набора данных к таблице
            productNameTB.Text = workerFIOTB.Text = custFIOTB.Text = countTB.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            HeadForm HeadForm = new HeadForm(); //открываем форму
            HeadForm.Show();
        }

        private void cancelSortButton_Click(object sender, EventArgs e)
        {
            DBConnection.GetChecks(); //получение списка пользователей
            dgChecks.DataSource = DBConnection.dtChecks; //привязка набора данных к таблице
            productNameTB.Text = workerFIOTB.Text = custFIOTB.Text = countTB.Text = "";
        }

        private void orderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void countTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void adrTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void sortSureButton_Click(object sender, EventArgs e)
        {
            DBConnection.GetChecks(productNameTB.Text, workerFIOTB.Text, custFIOTB.Text, countTB.Text); //получение списка пользователей
            dgChecks.DataSource = DBConnection.dtChecks; //привязка набора данных к таблице
        }
    }
}
