using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSignIn.Model
{
    public class Client
    {

        public Client()
        {
            this.name = string.Empty;
            this.Id = 0000;
            this.phone = "000-000-0000";
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int Id;

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string startDate;

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private string signtime;

        public string SignTime
        {
            get { return signtime; }
            set { signtime = value; }
        }

        private string paystatus;

        public string PayStatus
        {
            get { return paystatus; }
            set { paystatus = value; }
        }

        private string typePlan;

        public string TypePlan
        {
            get { return typePlan; }
            set { typePlan = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //Create property that hold a image.
        private byte[] image;

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }


    }
}
