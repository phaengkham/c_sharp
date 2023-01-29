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
    public partial class registerform : Form
    {
        public registerform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loginin form=new loginin();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerform_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opf =  new OpenFileDialog();
            if(opf.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(opf.FileName);
                pb_image.Image = bmp;
                pb_image.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void chb_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_show_password.Checked == true)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
           // String image,fname, lname, gender, gmail, password;
            formShow fs=new formShow();
            
            fs.fname = txt_fname.Text;
            fs.lname = txt_lname.Text;
            fs.gmail = txt_gmail.Text;
            fs.password = txt_password.Text;
            if(rdb_male.Checked == true)
            {
                fs.gender = rdb_male.Text;
            }
            else
            {
                fs.gender=rdb_female.Text;
            }
            fs.ShowDialog();

        }
    }
}
