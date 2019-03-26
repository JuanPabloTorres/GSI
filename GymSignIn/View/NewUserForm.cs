using GymSignIn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GymSignIn
{
    public partial class NewUserForm : MaterialSkin.Controls.MaterialForm
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter adapter;

        public NewUserForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CheckIfEmpty(NameTextBox.Text) && CheckIfEmpty(PhoneTextBox.Text) &&( radioButtonMonth.Checked || radioButtonAnnual.Checked)  && CheckIfEmpty(emailtxtbox.Text))
            {
                Client newUser = new Client();
                newUser.Name = NameTextBox.Text;
                newUser.Phone = PhoneTextBox.Text;
                newUser.Email = emailtxtbox.Text;

                Random randomId = new Random();
                newUser.ID= randomId.Next(1111, 9999);

                newUser.PayStatus = "Good";

                if(radioButtonMonth.Checked)
                {
                    newUser.TypePlan = "Monthly";
                }
                else
                {
                    newUser.TypePlan = "Annual";
                }

                string strconn = "Data Source=.;Initial Catalog=GymDataBase;Integrated Security=True";
                conn = new SqlConnection(strconn);
                conn.Open();

                string insertquery = "INSERT INTO [Clients](Id,Name,Phone,StartDate,PayStatus,TypePlan,email) VALUES(@Id,@Name,@Phone,@StartDate,@PayStatus,@TypePlan,@Email)";

                cmd = new SqlCommand(insertquery, conn);
                cmd.Parameters.AddWithValue("@Id", newUser.ID);
                cmd.Parameters.AddWithValue("@Name", newUser.Name);
                cmd.Parameters.AddWithValue("@Phone", newUser.Phone);
                cmd.Parameters.AddWithValue("@StartDate",DateTime.Today);
                cmd.Parameters.AddWithValue("@PayStatus", newUser.PayStatus);
                cmd.Parameters.AddWithValue("@TypePlan", newUser.TypePlan);
                cmd.Parameters.AddWithValue("@Email", newUser.Email);
                cmd.ExecuteNonQuery();
             
                conn.Close();
                this.Hide();
                IDMsg MsgIDBox = new IDMsg(newUser.ID.ToString());
                MsgIDBox.ShowDialog();

              
            }
            else
            {
                MessageBox.Show("Llena los encasillados.");
            }
        }

        bool CheckIfEmpty(string textbox)
        {
            bool Isempty;
            if(textbox != string.Empty)
            {
                Isempty = true;
            }
            else
            {
                Isempty = false;
            }

            return Isempty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonAnnual_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
