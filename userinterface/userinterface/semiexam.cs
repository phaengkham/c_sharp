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
    public partial class semiexam : Form
    {
        public semiexam()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name, surname, gmail,gender,course,phone;
          
            name = txt_name.Text;
            surname = txt_surname.Text;
            gmail = txt_gmail.Text;
            phone = maskedTextBox1.Text;
            //phone= double.Parse(maskedTextBox1.Text);
            if (rdb_male.Checked == true)
            {
                gender = rdb_male.Text;
            }
            else{
                gender = rdb_female.Text;
            }
            if(rdb_it.Checked == true)
            {
                course = rdb_it.Text;
            }
            else if(rdb_finance.Checked == true)
            {
                course = rdb_finance.Text;
            }
            else if(rdb_management.Checked == true)
            {
                course=rdb_management.Text;
            }
            else
            {
                course=rdb_English.Text;
            }
            rtb_show.Text= name + Environment.NewLine+ surname + 
                Environment.NewLine + gender + Environment.NewLine+ phone + 
                Environment.NewLine+ gmail + Environment.NewLine+course;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            rtb_show.Clear();
        }

        private void semiexam_Load(object sender, EventArgs e)
        {

        }
    }
}
