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
    public partial class loginin : Form
    {
        public loginin()
        {
            InitializeComponent();
        }

        private void loginin_Load(object sender, EventArgs e)
        {

        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text =="phaengkham"&& txt_password.Text == "1234")
            {
                new semiexam().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ສິ່ງທີ່ປ້ອນໄປບໍ່ຖືກຕ້ອງ","ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        private void lb_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void ch_show_password_CheckedChanged(object sender, EventArgs e)
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
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerform form = new registerform();
            form.ShowDialog();
        }
    }
}
