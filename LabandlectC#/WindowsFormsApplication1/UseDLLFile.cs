using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLFile;

namespace WindowsFormsApplication1
{
    public partial class UseDLLFile : Form
    {
        public UseDLLFile()
        {
            InitializeComponent();
        }
        Area a = new Area();
        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            r = int.Parse(txtr.Text);
             txtCircleArea.Text =  a.circle(r).ToString("#,###.00");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double l, w;
            l = double.Parse(txtl.Text);
            w = double.Parse(txtw.Text);
            txtrianglearea.Text = a.retriangle(l, w).ToString("#,###.00");
        }

        private void UseDLLFile_Load(object sender, EventArgs e)
        {

        }
    }
}
