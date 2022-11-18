using GymSignIn.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GymSignIn.Controllers
{
    public class SqlController
    {
        private SqlCommand cmd;

        private SqlConnection conn;
        private SqlDataAdapter adapter;

        public void OpenConnection ()
        {
            string strconn = "Data Source=.;Initial Catalog=GymDataBase;Integrated Security=True";
            conn = new SqlConnection(strconn);
            conn.Open();
        }

        public void Insert (Client clientSign)
        {
            OpenConnection();
            DateTime daytoPay = new DateTime();
            daytoPay = Convert.ToDateTime(clientSign.StartDate);

            int daytopay = daytoPay.Day;
            string nextM = daytoPay.AddMonths(1).ToString().Substring(0, 10);

            string todayIs = DateTime.Today.ToString().Substring(0, 10);

            int today = DateTime.Today.Day;

            string month = "Monthly";
            string sub = clientSign.TypePlan.Substring(0, month.Length);
            if( sub == "Monthly" )
            {
                if( today == daytopay && ( daytoPay.Month != DateTime.Today.Month || daytoPay.Month == DateTime.Today.Month ) )
                {
                    clientSign.PayStatus = "To pay";

                    string updatequery = "UPDATE Clients SET PayStatus=@paystatus WHERE ID=@ID";

                    var updatecommand = new SqlCommand(updatequery, conn);

                    updatecommand.Parameters.AddWithValue("@paystatus", clientSign.PayStatus);
                    updatecommand.Parameters.AddWithValue("@ID", clientSign.ID);

                    updatecommand.ExecuteNonQuery();
                }
                else
                {
                    string good = "Good";
                    string payStatus = clientSign.PayStatus.Substring(0, good.Length);
                    if( payStatus != "Good" )
                    {
                        clientSign.PayStatus = "Pending";
                    }

                    string updatequery = "UPDATE Clients SET PayStatus=@paystatus WHERE ID=@ID";

                    var updatecommand = new SqlCommand(updatequery, conn);

                    updatecommand.Parameters.AddWithValue("@paystatus", clientSign.PayStatus);
                    updatecommand.Parameters.AddWithValue("@ID", clientSign.ID);

                    updatecommand.ExecuteNonQuery();
                }
            }
            string annual = "Annual";
            string sub2 = clientSign.TypePlan.Substring(0, annual.Length);

            if( sub2 == "Annual" )
            {
                if( daytoPay.Year < DateTime.Today.Year && daytoPay.Day == DateTime.Today.Day && daytoPay.Month == DateTime.Today.Month )
                {
                    clientSign.PayStatus = "To pay";

                    string updatequery = "UPDATE Clients SET PayStatus=@paystatus WHERE ID=@ID";

                    var updatecommand = new SqlCommand(updatequery, conn);

                    updatecommand.Parameters.AddWithValue("@paystatus", clientSign.PayStatus);
                    updatecommand.Parameters.AddWithValue("@ID", clientSign.ID);

                    updatecommand.ExecuteNonQuery();
                }
                else
                {
                    clientSign.PayStatus = "Good";
                    string updatequery = "UPDATE Clients SET PayStatus=@paystatus WHERE ID=@ID";

                    var updatecommand = new SqlCommand(updatequery, conn);

                    updatecommand.Parameters.AddWithValue("@paystatus", clientSign.PayStatus);
                    updatecommand.Parameters.AddWithValue("@ID", clientSign.ID);

                    updatecommand.ExecuteNonQuery();
                }
            }

            string insertquery = "INSERT INTO [Firms](Id,Name,SignTime,PayStatus,Phone,StartDate,TypePlan) VALUES(@Id,@Name,@SignTime,@PayStatus,@Phone,@StartDate,@TypePlan)";
            SqlCommand cmd = new SqlCommand(insertquery, conn);
            cmd.Parameters.AddWithValue("@Id", clientSign.ID);
            cmd.Parameters.AddWithValue("@Name", clientSign.Name);
            cmd.Parameters.AddWithValue("@SignTime", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@PayStatus", clientSign.PayStatus);
            cmd.Parameters.AddWithValue("@Phone", clientSign.Phone);
            cmd.Parameters.AddWithValue("@StartDate", clientSign.StartDate);
            cmd.Parameters.AddWithValue("@TypePlan", clientSign.TypePlan);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void SignInCheck (string IDTextBox)
        {
            OpenConnection();

            string selectquery = " SELECT * FROM Clients";

            cmd = new SqlCommand(selectquery, conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while( rd.Read() )
            {
                if( rd[0].ToString() == IDTextBox )
                {
                    Client clientSign = new Client();

                    clientSign.ID = Convert.ToInt32(rd[0]);
                    clientSign.Name = rd[1].ToString();
                    clientSign.Phone = rd[2].ToString();
                    clientSign.StartDate = rd[3].ToString();
                    clientSign.TypePlan = rd[5].ToString();
                    clientSign.Email = rd[6].ToString();

                    if( rd[4].ToString() != null )
                    {
                        clientSign.PayStatus = rd[4].ToString();
                    }
                    rd.Close();

                    if( AlreadySign(IDTextBox) )
                    {
                        AlreadySignMsgBox msgBox = new AlreadySignMsgBox();
                        msgBox.ShowDialog();
                    }
                    else
                    {
                        SqlController sqlController = new SqlController();

                        sqlController.Insert(clientSign);
                        EmailController emailController = new EmailController();
                        emailController.SendEmailTo(clientSign);
                    }

                    conn.Close();
                    break;
                }
            }
            IDTextBox = string.Empty;

            conn.Close();
        }

        private bool AlreadySign (string IDTextBox)
        {
            bool exist = false;

            string selectquery = " SELECT * FROM [Firms]";

            cmd = new SqlCommand(selectquery, conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while( rd.Read() )
            {
                string date = rd[2].ToString();

                string mdyString = date.Substring(0, 10);

                string today = DateTime.Today.ToString();
                string firsten = today.Substring(0, 10);
                today = firsten;
                if( today[0] == '0' )
                {
                    string temp = today.Remove(0, 1);
                    today = temp;
                }

                if( rd[0].ToString() == IDTextBox && mdyString == today )
                {
                    exist = true;
                    break;
                }
            }
            rd.Close();

            return exist;
        }

        public void CloseConnection ()
        {
            string strconn = "Data Source=.;Initial Catalog=GymDataBase;Integrated Security=True";
            conn = new SqlConnection(strconn);
            conn.Close();
        }

        public void UpdateStatusFromClientsTo (int cliendId)
        {
            OpenConnection();
            string updateStatusquery = "UPDATE Clients SET PayStatus=@paystatus WHERE ID=@ID";

            var cmd = new SqlCommand(updateStatusquery, conn);

            cmd.Parameters.AddWithValue("@paystatus", "Good");

            int id = Convert.ToInt32(cliendId);
            cmd.Parameters.AddWithValue("@ID", cliendId);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public void UpdatesStatusFromFirmsTo (int clientId)
        {
            OpenConnection();
            string updateStatusquery = "UPDATE Firms SET PayStatus=@paystatus WHERE ID=@ID";

            var cmd = new SqlCommand(updateStatusquery, conn);

            cmd.Parameters.AddWithValue("@paystatus", "Good");

            cmd.Parameters.AddWithValue("@ID", clientId);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public List<Client> GetAllTodaySigns ()
        {
            OpenConnection();
            string selectquery = "SELECT * FROM [Firms]";

            cmd = new SqlCommand(selectquery, conn);

            SqlDataReader rd = cmd.ExecuteReader();

            List<Client> todaysClients = new List<Client>();

            while( rd.Read() )
            {
                string date = rd[2].ToString();

                string mdyString = date.Substring(0, 10);

                string today = DateTime.Today.ToString();
                string firsten = today.Substring(0, 10);
                today = firsten;
                if( today[0] == '0' )
                {
                    string temp = today.Remove(0, 1);
                    today = temp;
                }

                if( mdyString == today )
                {
                    Client todayClient = new Client();
                    todayClient.ID = Convert.ToInt32(rd[0]);
                    todayClient.Name = rd[1].ToString();
                    todayClient.SignTime = rd[2].ToString();
                    todayClient.PayStatus = rd[3].ToString();
                    todayClient.StartDate = rd[4].ToString();
                    todayClient.Phone = rd[5].ToString();
                    todayClient.TypePlan = rd[6].ToString();

                    todaysClients.Add(todayClient);
                }
            }

            return todaysClients;
        }

        public DataTable GetAllClients ()
        {
            OpenConnection();

            string selectquery = "SELECT * FROM Clients";

            cmd = new SqlCommand(selectquery, conn);

            adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            CloseConnection();

            return dt;
        }

        public DataTable GetAllFirms ()
        {
            OpenConnection();

            string selectquery = "SELECT * FROM Firms";

            cmd = new SqlCommand(selectquery, conn);

            adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            CloseConnection();

            return dt;
        }

        public DataTable FindThis (string Id)
        {
            OpenConnection();

            string selectId = "SELECT * FROM Clients WHERE ID =" + Id;

            cmd = new SqlCommand(selectId, conn);

            adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            CloseConnection();

            return dt;
        }

        public DataTable SelectNotGoodPayStatus ()
        {
            OpenConnection();

            string selectquery = "SELECT * FROM Clients WHERE PayStatus =@PayStatus OR PayStatus=@PS";

            cmd = new SqlCommand(selectquery, conn);

            cmd.Parameters.AddWithValue("@PayStatus", "To pay");
            cmd.Parameters.AddWithValue("@PS", "Pending");

            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            CloseConnection();
            adapter.Fill(dt);

            return dt;
        }

        public Client GetInformationOfThis (string clientid)
        {
            Client client = new Client();
            OpenConnection();
            string selectquery = "SELECT * FROM Clients";

            cmd = new SqlCommand(selectquery, conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while( rd.Read() )
            {
                if( rd[0].ToString() == clientid )
                {
                    client.ID = Convert.ToInt32(rd[0]);
                    client.Name = rd[1].ToString();
                    client.Phone = rd[2].ToString();
                    client.StartDate = rd[3].ToString();
                    client.TypePlan = rd[5].ToString();
                    client.PayStatus = rd[4].ToString();
                    client.Email = rd[6].ToString();

                    break;
                }
            }

            return client;
        }

        public SqlController ()
        {
        }
    }
}