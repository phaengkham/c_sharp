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
    public partial class frmDistrict : Form
    {
        public frmDistrict()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ConnectDatabase cd = new ConnectDatabase();
        private void frmDistrict_Load(object sender, EventArgs e)
        {
            cd.ConnectDatabase3CS1_2();
            SqlDataAdapter daP = new SqlDataAdapter("Select * from Province", cd.conn);
            DataSet dsP = new DataSet();
            daP.Fill(dsP, "P");
            cbProvince.DataSource = dsP.Tables[0];
            cbProvince.DisplayMember = "ProvinceName";
            cbProvince.ValueMember = "ProvinceID";
            txtDistrictID.Enabled = false;
        }
    }
}
