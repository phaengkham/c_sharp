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
using System.Data.OleDb;

namespace _3CS1_2
{
    public partial class frmProvince : Form
    {
        public frmProvince()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ConnectDatabase cd = new ConnectDatabase();
        private void frmProvince_Load(object sender, EventArgs e)
        {
            cd.ConnectDatabase3CS1_2();
            ShowProvince();
        }
        private void ShowProvince()
        {
            da = new SqlDataAdapter("Select * from Province", cd.conn);
            da.Fill(ds, "Province");
            ds.Tables[0].Clear();
            da.Fill(ds, "Province");
            DGV.DataSource = ds.Tables[0];
            DGV.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string excelFileName;
            openFileDialog1.ShowDialog();
            excelFileName = openFileDialog1.FileName;
            string connExcel = "Provider=Microsoft.ACE.OleDb.12.0;Data source=" + excelFileName +"; extended properties=Excel 12.0;";
            OleDbDataAdapter daExcel = new OleDbDataAdapter("select * from [Sheet1$]", connExcel);
            DataSet dsExcel = new DataSet();
            daExcel.Fill(dsExcel, "Excel");
            DGV2.DataSource = dsExcel.Tables[0];
            DGV.Refresh();
        }

        private void DGV2_Click(object sender, EventArgs e)
        {
            try {
                txtProvinceID.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells[0].Value.ToString();
                txtProvinceName.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cd.cmd = new SqlCommand("Insert into Province values(@ProvinceID,@ProvinceName)", cd.conn);
            cd.cmd.Parameters.AddWithValue("ProvinceID", txtProvinceID.Text);
            cd.cmd.Parameters.AddWithValue("ProvinceName", txtProvinceName.Text);
            cd.cmd.ExecuteNonQuery();
            ShowProvince();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < DGV2.Rows.Count-1; i++)
            {
                int j;
                bool check=false;
                for (j = 0; j < DGV.Rows.Count - 1; j++)
                {
                    if (DGV2.Rows[i] == DGV2.Rows[j])
                    {
                        check = true;
                    }
                }
                if(check==false)
                {
                    cd.cmd = new SqlCommand("Insert into Province values(@ProvinceID,@ProvinceName)", cd.conn);
                    cd.cmd.Parameters.AddWithValue("ProvinceID", DGV2.Rows[i].Cells[0].Value.ToString());
                    cd.cmd.Parameters.AddWithValue("ProvinceName", DGV2.Rows[i].Cells[1].Value.ToString());
                    cd.cmd.ExecuteNonQuery();
                    ShowProvince();

                }
            }
        }

    }
}
