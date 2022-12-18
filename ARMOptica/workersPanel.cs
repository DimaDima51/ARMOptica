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
    public partial class workersPanel : Form
    {
        public workersPanel()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            HeadForm HeadForm = new HeadForm(); //открываем форму NewForma
            HeadForm.Show();
        }

        private void workersPanel_Load(object sender, EventArgs e)
        {
            DBConnection.GetWorkersList(); //получение списка пользователей
            dgWorkers.DataSource = DBConnection.dtWorkers; //привязка набора данных к таблице
            userTB.Text = IDTB.Text = FIOTB.Text = PostTB.Text = TelTB.Text = adrTB.Text = "";
        }

        private void cancelSortButton_Click(object sender, EventArgs e)
        {
            DBConnection.GetWorkersList(); //получение списка пользователей
            dgWorkers.DataSource = DBConnection.dtWorkers; //привязка набора данных к таблице
            userTB.Text = IDTB.Text = FIOTB.Text = PostTB.Text = TelTB.Text = adrTB.Text = "";
        }

        private void IDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void TelTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void sortSureButton_Click(object sender, EventArgs e)
        {
            DBConnection.GetWorkersList(userTB.Text, IDTB.Text, FIOTB.Text, PostTB.Text, TelTB.Text, adrTB.Text); //получение списка пользователей
            dgWorkers.DataSource = DBConnection.dtWorkers; //привязка набора данных к таблице
        }
    }
}
