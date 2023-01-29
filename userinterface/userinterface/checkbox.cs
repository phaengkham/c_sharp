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
    public partial class checkbox : Form
    {
        public checkbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            if (chb_c.Checked == true)
            {
                str = "ເຈົ້າເລືອກຮຽນພາສາ C" + Environment.NewLine;
            }
            if (chb_csharp.Checked == true)
            {
                str = str + "ເຈົ້າເລືອກຮຽນພາສາ C#" + Environment.NewLine;
            }
            if(chb_java.Checked == true)
            {
                str = str + "ເຈົ້າເລືອກຮຽນພາສາ Java" + Environment.NewLine;
            }
            if(chb_html.Checked == true)
            {
                str=str + "ເຈົ້າເລືອກຮຽນພາສາ HTML"+Environment.NewLine;
            }
            if(chb_css.Checked == true)
            {
                str=str + "ເຈົ້າເລືອກຮຽນພາສາ CSS" +Environment.NewLine;
            }
            if(chb_sql.Checked == true) {              
                str= str + "ເຈົ້າເລືອກຮຽນພາສາ SQL Server"+Environment.NewLine;
            }
            label1.Text = str;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
