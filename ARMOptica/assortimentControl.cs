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
    public partial class assortimentControl : Form
    {
        public assortimentControl()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            HeadForm HeadForm = new HeadForm(); //открываем форму
            HeadForm.Show();
        }

        private void assortimentControl_Load(object sender, EventArgs e)
        {
            DBConnection.GetAssortimentList(); //получение списка пользователей
            dgAssortiment.DataSource = DBConnection.dtAssortiment; //привязка набора данных к таблице
            sortNameTB.Text = sortPriceTB.Text = sortCategTB.Text = "";
        }

        private void sortSureButton_Click(object sender, EventArgs e)
        {
            DBConnection.GetSortAssortimentList(sortNameTB.Text, sortCategTB.Text, sortPriceTB.Text); //получение списка пользователей
            dgAssortiment.DataSource = DBConnection.dtAssortiment; //привязка набора данных к таблице

        }

        private void sortTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void cancelSortButton_Click(object sender, EventArgs e)
        {
            DBConnection.GetAssortimentList(); //получение списка пользователей
            dgAssortiment.DataSource = DBConnection.dtAssortiment; //привязка набора данных к таблице
            sortNameTB.Text = sortPriceTB.Text = sortCategTB.Text = "";
        }
    }
}
