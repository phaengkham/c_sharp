using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace babyShop
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }
        

        private void lb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            Form1 form= new Form1(); 
            form.ShowDialog();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void chk_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_showpassword.Checked)
            {
                txt_password.UseSystemPasswordChar=true;
            }
            else
            {
                txt_password.UseSystemPasswordChar=false;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PHAENGMSI\\PHBABY;Initial Catalog=babyShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into tb_register value (@fname,@lname,@gender,@phone,@gmail,@password", con);
            cmd.Parameters.AddWithValue("@fname", txt_fname.Text);
            cmd.Parameters.AddWithValue("@lname",txt_lname.Text);
            cmd.Parameters.Add("@gender", SqlDbType.VarChar, 10).Value = (rdb_male.Checked) ? rdb_male : rdb_female;
            cmd.Parameters.AddWithValue("@phone",int.Parse(txt_phone.Text));
            cmd.Parameters.AddWithValue("@gmail", txt_gmail.Text);
            cmd.Parameters.AddWithValue("@password",txt_password.Text);
            cmd.ExecuteNonQuery();
            //con.Close();
            MessageBox.Show("ທ່ານລົງທະບຽນແລ້ວ");
        }
    }
}
