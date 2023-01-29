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
    public partial class richtexbox : Form
    {
        public richtexbox()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (chb_bold.Checked == true)
            {
                lb_show.Font = new Font(lb_show.Font, FontStyle.Bold);
            }
            if (chb_italic.Checked == true)
            {
                lb_show.Font = new Font(lb_show.Font, FontStyle.Italic);
            }
            if (chb_underlin.Checked == true)
            {
                lb_show.Font = new Font(lb_show.Font, FontStyle.Underline);
            }
            if (chb_bold.Checked == true && chb_italic.Checked == true)
            {
                lb_show.Font = new Font(lb_show.Font, FontStyle.Bold | FontStyle.Italic);
            }
            if (chb_bold.Checked == true && chb_underlin.Checked == true)
            {
                lb_show.Font = new Font(lb_show.Font, FontStyle.Bold | FontStyle.Underline);
            }
            if (chb_italic.Checked == true && chb_underlin.Checked == true)
            {
                lb_show.Font = new Font(lb_show.Font, FontStyle.Italic | FontStyle.Underline);
            }
            if (chb_bold.Checked == true && chb_italic.Checked == true && chb_underlin.Checked == true)
            {
                lb_show.Font = new Font(lb_show.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
            if (rdb_red.Checked == true)
            {
                lb_show.ForeColor = System.Drawing.Color.Red;
            }
            if (rdb_white.Checked == true)
            {
                lb_show.ForeColor = System.Drawing.Color.White;
            }
            if (rdb_pick.Checked == true)
            {
                lb_show.ForeColor = System.Drawing.Color.Pink;
            }
            lb_show.Text = "Name:" + txt_name.Text + Environment.NewLine + "" + "Message:" + rt_message.Text;
                
        }

        private void richtexbox_Load(object sender, EventArgs e)
        {

        }
    }
}
