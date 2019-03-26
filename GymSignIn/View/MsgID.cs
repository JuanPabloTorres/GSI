using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSignIn
{
    public partial class IDMsg : MaterialSkin.Controls.MaterialForm
    {
        string msg;
        public IDMsg(string msg)
        {

            this.msg = msg;
            InitializeComponent();
        }

        private void MsgID_Load(object sender, EventArgs e)
        {
            materialLabel2.Text = msg;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
