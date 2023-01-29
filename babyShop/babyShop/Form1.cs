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

namespace babyShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
        //SqlCommand cmd = new SqlCommand();
        //SqlDataAdapter adapter = new SqlDataAdapter();

       


        private void lb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void chb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_showPassword.Checked)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerForm form=new registerForm();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = txt_username.Text;
            String password = txt_password.Text;
            try {
                String querry="SELECT * FROM tblogin WHERE username = '"+txt_username.Text+"'AND password = '"+txt_password.Text+"'";
                SqlDataAdapter dat=new SqlDataAdapter(querry,con);
                DataTable dt = new DataTable();
                dat.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    username=txt_username.Text;
                    password=txt_password.Text;
                    
                    showForm sf = new showForm();
                    sf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ","ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }
            }
            catch {
                MessageBox.Show("error");
            }
            finally
            {
                con.Close();
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }
    }
}
