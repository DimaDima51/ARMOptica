using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ARMOptica
{
    public partial class HeadForm : Form
    {
        public HeadForm()
        {
            InitializeComponent();
        }

        private void CFCustomers_Load(object sender, EventArgs e)
        {
            helloLabel.Text = "Учётная запись: " + DBConnection.User;
            helloLabel2.Text = "ID: " + DBConnection.idWorker;
        }

        private void OpenCustomerControl_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            CustomersControl CustomersControl = new CustomersControl(); //открываем форму
            CustomersControl.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e) //закрытие программы
        {
            DBConnection.Close();
            Application.Exit();
        }

        private void OpenStoreControl_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            StoreControl StoreControl = new StoreControl(); //открываем форму
            StoreControl.Show();
        }

        private void OpenAssortimentControl_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            assortimentControl assortimentControl = new assortimentControl(); //открываем форму
            assortimentControl.Show();
        }

        private void OpenWorkersPanel_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            workersPanel workersPanel = new workersPanel(); //открываем форму
            workersPanel.Show();
        }

        private void openCheckPanel_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            checkPanel checkPanel = new checkPanel(); //открываем форму
            checkPanel.Show();
        }

        private void openWatchChecksPanel_Click(object sender, EventArgs e)
        {
            Close(); //закрываем текущую форму
            watchChecksPanel watchChecksPanel = new watchChecksPanel(); //открываем форму
            watchChecksPanel.Show();
        }

    }
}
