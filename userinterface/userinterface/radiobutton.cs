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
    public partial class radiobutton : Form
    {
        public radiobutton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbmale.Checked == true)
            {
                MessageBox.Show("ລົມໄດ້", "ເປັນຄົນໂສດ");
            }
            if(rdbfemale.Checked == true)
            {
                MessageBox.Show("ຫ້າມລົມ", "ມີແຟນແລ້ວ");
            }
        }
    }
}
