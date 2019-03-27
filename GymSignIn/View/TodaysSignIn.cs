using GymSignIn.Controllers;
using GymSignIn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

          
            string strconn = "Data Source=.;Initial Catalog=GymDataBase;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand command = new SqlCommand
                                ("select Image from Clients where ID="+IDTextBox.Text, conn);
          
            SqlDataAdapter dp = new SqlDataAdapter(command);
            DataSet ds = new DataSet("Image");

            byte[] MyData = new byte[0];

            dp.Fill(ds, "Image");
            DataRow myRow;
            myRow = ds.Tables["Image"].Rows[0];        

            MyData = (byte[])myRow["Image"];
          

            MemoryStream stream = new MemoryStream(MyData);
          
            pictureBox1.Image = Image.FromStream(stream);

            

            

            IDTextBox.Text = string.Empty;
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int columIndex = dataGridView1.CurrentCell.ColumnIndex;

                idlb.Text = "ID:" + dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

                if (dataGridView1.Rows[rowIndex].Cells[1].Value != null)
                {
                    emaillb.Text = "Email:" + dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();

                }
                else
                {

                    emaillb.Text = "Email:" + "Inser email";
                    string x;
                }
              namlb.Text= "Name:"+dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();

                if (dataGridView1.Rows[rowIndex].Cells[3].Value != null)
                {
                lstlb.Text= dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();

                }
                paystatuslb.Text ="Pay Status:"+ dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                stdlb.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                phonelb.Text ="Phone:"+ dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
                memlb.Text= "Membership:"+dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            }


        }
    }
}
