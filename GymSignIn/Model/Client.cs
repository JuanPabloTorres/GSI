namespace GymSignIn.Model
{
    public class Client
    {
        private string email;

        private int Id;

        //Create property that hold a image.
        private byte[] image;

        private string name;

        private string paystatus;

        private string phone;

        private string signtime;

        private string startDate;

        private string typePlan;

        public Client ()
        {
            this.name = string.Empty;
            this.Id = 0000;
            this.phone = "000-000-0000";
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string PayStatus
        {
            get { return paystatus; }
            set { paystatus = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string SignTime
        {
            get { return signtime; }
            set { signtime = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public string TypePlan
        {
            get { return typePlan; }
            set { typePlan = value; }
        }
    }
}