using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lasaCollege
{
    public partial class studentform : Form
    {
        public studentform()
        {
            InitializeComponent();
        }


        private void studentform_Load(object sender, EventArgs e)
        {
            txt_stId.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_image_Click(object sender, EventArgs e)
        {
          
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txt_path.Text = openFileDialog1.FileName;
                pb_image.Image = Image.FromFile(txt_path.Text);
            }
        }

        private void btn_addMajor_Click(object sender, EventArgs e)
        {
            major mj = new major();
            mj.Show();
            this.Hide();
        }

        private void btn_addStatus_Click(object sender, EventArgs e)
        {
            statuspaid sta=new statuspaid();
            sta.Show();
            this.Hide();
        }

        private void btn_addBorndistrict_Click(object sender, EventArgs e)
        {
            district dist=new district();
            dist.Show();
            this.Hide();
        }

        private void btn_addbornprovince_Click(object sender, EventArgs e)
        {
            provinceform prv = new provinceform();
            prv.Show();
            this.Hide();
        }

        private void btn_addDistrict_Click(object sender, EventArgs e)
        {
            district dist = new district();
            dist.Show();
            this.Hide();
        }

        private void btn_addProvince_Click(object sender, EventArgs e)
        {
            provinceform prv = new provinceform();
            prv.Show();
            this.Hide();
        }

        private void btn_addEthnic_Click(object sender, EventArgs e)
        {
            ethnic ethnic = new ethnic();
            ethnic.Show();
            this.Hide();
        }

        private void btn_addFoccupation_Click(object sender, EventArgs e)
        {
            occupation occ=new occupation();
            occ.Show();
            this.Hide();
        }

        private void btn_addMoccupation_Click(object sender, EventArgs e)
        {
            occupation occ = new occupation();
            occ.Show();
            this.Hide();
        }
    }
}
