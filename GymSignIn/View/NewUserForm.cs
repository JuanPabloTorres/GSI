using GymSignIn.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

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
            if(CheckIfEmpty(NameTextBox.Text) && CheckIfEmpty(PhoneTextBox.Text) &&( radioButtonMonth.Checked || radioButtonAnnual.Checked)  && CheckIfEmpty(emailtxtbox.Text) && clientPicureBox.Image != null)
            {
                Client newUser = new Client();
                newUser.Name = NameTextBox.Text;
                newUser.Phone = PhoneTextBox.Text;
                newUser.Email = emailtxtbox.Text;
                newUser.Image = pic;

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

                string insertquery = "INSERT INTO [Clients](Id,Name,Phone,StartDate,PayStatus,TypePlan,email,Image) VALUES(@Id,@Name,@Phone,@StartDate,@PayStatus,@TypePlan,@Email,@Image)";

                cmd = new SqlCommand(insertquery, conn);
                cmd.Parameters.AddWithValue("@Id", newUser.ID);
                cmd.Parameters.AddWithValue("@Name", newUser.Name);
                cmd.Parameters.AddWithValue("@Phone", newUser.Phone);
                cmd.Parameters.AddWithValue("@StartDate",DateTime.Today);
                cmd.Parameters.AddWithValue("@PayStatus", newUser.PayStatus);
                cmd.Parameters.AddWithValue("@TypePlan", newUser.TypePlan);
                cmd.Parameters.AddWithValue("@Email", newUser.Email);
                cmd.Parameters.AddWithValue("@Image", newUser.Image);
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

            //Camera camera = new Camera();
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
           
            //camera.OnFrameArrived += Camera_OnFrameArrived;
            //camera.ChangeCamera(0);
            //camera.Start(1);


        }



        Image image;
        //private void Camera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        //{
        //    image = e.GetFrame();

        //    clientPicureBox.Image = image;
        //}

        byte[] pic;

        private void materialRaisedButton2_Click_1(object sender, EventArgs e)
        {
            //camera.Stop();
            clientPicureBox.Image = image;
            MemoryStream stream = new MemoryStream();
            clientPicureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
             pic = stream.ToArray();
          

        }

       
    }
}
