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
    public partial class StoreControl : Form
    {
        public StoreControl()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            HeadForm HeadForm = new HeadForm(); //открываем форму NewForma
            HeadForm.Show();
        }

        private void StoreControl_Load(object sender, EventArgs e)
        {
            DBConnection.GetStoreList(); //получение списка пользователей
            dgStore.DataSource = DBConnection.dtStore; //привязка набора данных к таблице
            sortTextBox.Text = "";
        }

        private void cancelSortButton_Click(object sender, EventArgs e)
        {
            DBConnection.GetStoreList(); //получение списка пользователей
            dgStore.DataSource = DBConnection.dtStore; //привязка набора данных к таблице
            sortTextBox.Text = "";
            zeroTovarCB.Checked = false;
        }

        private void sortSureButton_Click(object sender, EventArgs e)
        {
            DBConnection.GetSortStoreList(sortTextBox.Text, zeroTovarCB.Checked); //получение списка пользователей
            dgStore.DataSource = DBConnection.dtStore; //привязка набора данных к таблице
        }
    }
}
