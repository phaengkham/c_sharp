using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userinterface
{
    public partial class formShow : Form
    {
        public string image { get; set; }
        public String fname { get; set; }
        public String lname { get; set; }
        public String gender { get; set; }
        public String gmail { get; set; }
        public String password { get; set; }
        public formShow()
        {
            InitializeComponent();
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            registerform form = new registerform();
            form.ShowDialog();
        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formShow_Load(object sender, EventArgs e)
        {
            lb_fname.Text = fname;
            lb_lname.Text = lname;
            lb_gender.Text = gender;
            lb_gmail.Text = gmail;
            lb_password.Text = password;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            loginin form=new loginin();
            form.ShowDialog();
        }
    }
}
