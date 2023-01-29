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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text =="phaengkham" && txt_password.Text == "1234")
            {
                new semiexam().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ສິ່ງທີ່ປ້ອນໄປບໍ່ຖືກຕ້ອງ, ກະລຸນາປ້ອນໃໝ່", "ຄໍາເຕືອນ", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_show_password.Checked == true)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
           // if(e.KeyCode == Keys.Enter)
           // {
               // btn_login.PerformClick();
           // }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
