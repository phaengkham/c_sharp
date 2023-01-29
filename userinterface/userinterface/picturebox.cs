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
    public partial class picturebox : Form
    {
        public picturebox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(ofd.FileName);
                pictureBox2.Image = bmp;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            picturebox form2=new picturebox();
            form2.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_goNext_Click(object sender, EventArgs e)
        {
            radiobutton form3=new radiobutton();
            form3.ShowDialog();        }
    }
}
