using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _3CS1_2
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ConnectDatabase ccd = new ConnectDatabase();
        string Gender = null;
        string EmStatus = "";
        string WorkType = "";
          private void frmEmployee_Load(object sender, EventArgs e)
        {
            ccd.ConnectDatabase3CS1_2();
            SqlDataAdapter daP = new SqlDataAdapter("Select * from Province", ccd.conn);
            DataSet dsP = new DataSet();
            daP.Fill(dsP, "P");
            cbProvince.DataSource = dsP.Tables[0];
            cbProvince.DisplayMember = "ProvinceName";
            cbProvince.ValueMember = "ProvinceID";
                
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter daD = new SqlDataAdapter("Select * from District where ProvinceID=" + cbProvince.SelectedValue + "", ccd.conn);
                DataSet dsD = new DataSet();
                daD.Fill(dsD, "D");
                dsD.Tables[0].Clear();
                daD.Fill(dsD, "D");
                cbDistrict.DataSource = dsD.Tables[0];
                cbDistrict.DisplayMember = "DistrictName";
                cbDistrict.ValueMember = "DIstrictID";
            }
            catch (Exception ex)
            {

            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked == true)
            {
                Gender = "ຊາຍ";
                rbFemale.Checked = false;
                txtWomenDate.Enabled = false;
            }
        }

        private void bFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked == true)
            {
                Gender = "ຍິງ";
                rbMale.Checked = false;
                txtWomenDate.Enabled = true;
            }
        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSingle.Checked == true)
            {
                EmStatus = "ໂສດ";
                txtChildNo.Text = "0";
                txtChildNo.ReadOnly = true;
                txtSpouseName.Text = "";
                txtSpouseSurnme.Text = "";
                txtSpousePlace.Text = "";
                txtSpouseName.ReadOnly=true;
                txtSpouseSurnme.ReadOnly = true;
                txtSpousePlace.ReadOnly=true;
                WorkType = "";
                groupBox5.Enabled = false;
            }
        }

        private void rbMarried_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMarried.Checked == true)
            {
                EmStatus = "ແຕ່ງງານ";
                txtChildNo.Clear();
                txtChildNo.ReadOnly =false;
                txtSpouseName.Text = "";
                txtSpouseSurnme.Text = "";
                txtSpousePlace.Text = "";
                txtSpouseName.ReadOnly = false;
                txtSpouseSurnme.ReadOnly = false;
                txtSpousePlace.ReadOnly = false;
                groupBox5.Enabled = true;
            }
        }

        private void rbDivorce_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDivorce.Checked == true)
            {
                EmStatus = "ຢ່າຮ້າງ";
                txtChildNo.Clear();
                txtChildNo.ReadOnly = false;
                txtSpouseName.Text = "";
                txtSpouseSurnme.Text = "";
                txtSpousePlace.Text = "";
                txtSpouseName.ReadOnly = false;
                txtSpouseSurnme.ReadOnly = false;
                txtSpousePlace.ReadOnly = false;
                groupBox5.Enabled = true;
            }
        }

        private void rbWidow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWidow.Checked == true)
            {
                EmStatus = "ໝ້າຍ";
                txtChildNo.Clear();
                txtChildNo.ReadOnly = false;
                txtSpouseName.Text = "";
                txtSpouseSurnme.Text = "";
                txtSpousePlace.Text = "";
                txtSpouseName.ReadOnly = false;
                txtSpouseSurnme.ReadOnly = false;
                txtSpousePlace.ReadOnly = false;
                groupBox5.Enabled = true;
            }
        }

        private void rbGoverment_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGoverment.Checked == true)
            {
                WorkType = "ລັດ";
            }
          
        }

        private void rbSemiGovererment_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSemiGovererment.Checked == true)
            {
                WorkType = "ລັດວິສະຫະກິດ";
            }
        }

        private void rbPrivate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrivate.Checked == true)
            {
                WorkType = "ເອກະຊົນ";
            }
        }

        private void rbOrganization_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrganization.Checked == true)
            {
                WorkType = "ອົງກອນສາກົນ";
            }
        }

        private void rbBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBusiness.Checked == true)
            {
                WorkType = "ທຸລະກິດສ່ວນຕົວ";
            }
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOther.Checked == true)
            {
                WorkType = "ອື່ນໆ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtPath.Text = openFileDialog1.FileName;
            pbPhoto.Image = Image.FromFile(txtPath.Text);
        }

        private void txtChildNo_TextChanged(object sender, EventArgs e)
        {
            if (txtChildNo.Text == "")
            {

            }
            else
            {
                int num=0;
                bool isnum = int.TryParse(txtChildNo.Text, out num);
                if (isnum == false)
                {
                    MessageBox.Show("ກະລຸນາປ້ອນຈຳນວນລູກເປັນຕົວເລກ");
                    txtChildNo.Clear();
                    txtChildNo.Focus();
                }
            }
           
        }
    }
}
