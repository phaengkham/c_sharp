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
    public partial class datetime : Form
    {
        public datetime()
        {
            InitializeComponent();
        }

        private void datetime_Load(object sender, EventArgs e)
        {
         
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dt = dateTimePicker1.Text;
            textBox1.Text = dt;
        }
    }
}
