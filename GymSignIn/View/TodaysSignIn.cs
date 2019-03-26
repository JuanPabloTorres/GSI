using GymSignIn.Controllers;
using GymSignIn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSignIn
{
    public partial class TodaysSignIn : MaterialSkin.Controls.MaterialForm
    {
        public TodaysSignIn()
        {
            InitializeComponent();
        }

        private void TodaysSignIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet9.Firms' table. You can move, or remove it, as needed.
            this.firmsTableAdapter2.Fill(this.gymDataBaseDataSet9.Firms);
            // TODO: This line of code loads data into the 'gymDataBaseDataSet8.Firms' table. You can move, or remove it, as needed.
            this.firmsTableAdapter1.Fill(this.gymDataBaseDataSet8.Firms);
            // TODO: This line of code loads data into the 'gymDataBaseDataSet7.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.gymDataBaseDataSet7.Clients);
            // TODO: This line of code loads data into the 'gymDataBaseDataSet6.Firms' table. You can move, or remove it, as needed.
            this.firmsTableAdapter.Fill(this.gymDataBaseDataSet6.Firms);
            // TODO: This line of code loads data into the 'gymDataBaseDataSet5.TodaySign' table. You can move, or remove it, as needed.
            this.todaySignTableAdapter1.Fill(this.gymDataBaseDataSet5.TodaySign);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
      

        //Verifica las firmas del dia.
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            SqlController sqlController = new SqlController();
            dataGridView1.DataSource = sqlController.GetAllTodaySigns();

        }
      

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            SqlController sqlController = new SqlController();

            dataGridView1.DataSource = sqlController.GetAllFirms();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            SqlController sqlController = new SqlController();

            dataGridView1.DataSource = sqlController.GetAllClients();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            SqlController sqlController = new SqlController();

            dataGridView1.DataSource = sqlController.FindThis(IDTextBox.Text);
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            SqlController sqlController = new SqlController();

            int clientid = Convert.ToInt32(IDTextBox.Text);
            sqlController.UpdateStatusFromClientsTo(clientid);

            EmailController emailController = new EmailController();

            emailController.SendEmailTo(sqlController.GetInformationOfThis(IDTextBox.Text));

            sqlController.UpdatesStatusFromFirmsTo(clientid);
           

        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            SqlController sqlController = new SqlController();

            dataGridView1.DataSource = sqlController.SelectNotGoodPayStatus();

        }
    }
}
