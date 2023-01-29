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
using ClassConnectDatabase;

namespace _3CS1_2
{
    public partial class frmEducation : Form
    {
        public frmEducation()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ConnectDatabase cd = new ConnectDatabase();
        //ClassConnectionDatabase ccd = new ClassConnectionDatabase();
        private void frmEducation_Load(object sender, EventArgs e)
        {
           cd.ConnectDatabase3CS1_2();
            //ccd.ConnectDatabase3CS1_2();
            ShowEducation();
            DGV.Columns[0].HeaderText = "ລະຫັດລະດັບການສຶກສາ";
            DGV.Columns[1].HeaderText = "ຊື່ລະດັບການສຶກສາ";
            DGV.Columns[0].Width = 200;
            DGV.Columns[1].Width = 200;
        }
        public void ShowEducation()
        {
            da = new SqlDataAdapter("Select * from Education", cd.conn);
            da.Fill(ds, "Education");
            ds.Tables[0].Clear();
            da.Fill(ds, "Education");
            DGV.DataSource = ds.Tables[0];
            DGV.Refresh();
        }
    }
}
