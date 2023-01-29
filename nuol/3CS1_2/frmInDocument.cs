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
    public partial class frmInDocument : Form
    {
        public frmInDocument()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ConnectDatabase cd = new ConnectDatabase();
        private void frmInDocument_Load(object sender, EventArgs e)
        {
            cd.ConnectDatabase3CS1_2();
            ShowDocument();
        }
        private void ShowDocument()
        {
            da = new SqlDataAdapter("Select * from InDocument", cd.conn);
            da.Fill(ds, "Doc");
            ds.Tables[0].Clear();
            da.Fill(ds, "Doc");
            DGV.DataSource = ds.Tables[0];
            DGV.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = "";
            if(openFileDialog1.FileName!="")
            {
                file = openFileDialog1.FileName;
                axAcroPDF1.LoadFile(file);
                txtDocPath.Text = file;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
