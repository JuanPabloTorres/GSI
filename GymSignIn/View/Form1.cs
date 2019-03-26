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
using System.Threading;

using System.Net;
using System.Net.Mail;
using GymSignIn.Controllers;

namespace GymSignIn
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {    
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlController sqlController = new SqlController();

            sqlController.SignInCheck(IDTextBox.Text);

            IDTextBox.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserForm userForm =new NewUserForm();
            userForm.ShowDialog();
         
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TodaysSignIn todaysSign = new TodaysSignIn();
            todaysSign.ShowDialog();
           
        }

      


    }
}
