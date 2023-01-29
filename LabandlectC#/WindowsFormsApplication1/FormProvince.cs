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
namespace WindowsFormsApplication1
{
    public partial class FormProvince : Form
    {
        public FormProvince()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        ClassConnetDatabase cdd = new ClassConnetDatabase();
        private void FormProvince_Load(object sender, EventArgs e)
        {
            cdd.connetDatabasecs31_2();
            Shows();
        }
        private void Shows()
        {
            try {
                ds = new DataSet();
                da = new SqlDataAdapter("select * from Province", cdd.conn);
                da.Fill(ds, "P");
                ds.Tables[0].Clear();
                da.Fill(ds, "P");
                dgv.DataSource = ds.Tables[0];
                dgv.Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string excelFileName;
                openFileDialog1.ShowDialog();
                excelFileName = openFileDialog1.FileName;
                string connExcel = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFileName + ";Extended Properties=Excel 12.0;";
                OleDbDataAdapter daExcel = new OleDbDataAdapter("select * from [Sheet1$]", connExcel);
                DataSet dsExcel = new DataSet();
                daExcel.Fill(dsExcel, "Excel");
                DGV2.DataSource = dsExcel.Tables[0];
                DGV2.Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells[0].Value.ToString();
                txtName.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cdd.cmd = new SqlCommand("insert into Province values(@ID,@Name)", cdd.conn);
            cdd.cmd.Parameters.AddWithValue("ID", txtID.Text);
            cdd.cmd.Parameters.AddWithValue("Name", txtName.Text);
            cdd.cmd.ExecuteNonQuery();
            Shows();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int i;
                for (i = 0; i < DGV2.Rows.Count - 1; i++)
                {
                    int j;
                    bool check = false;
                    for (j = 0; j < dgv.Rows.Count - 1; i++)
                    {
                        if (DGV2.Rows[i] == DGV2.Rows[i])
                        {
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        cdd.cmd = new SqlCommand("insert into Province values(@ID,@Name)", cdd.conn);
                        cdd.cmd.Parameters.AddWithValue("ID", DGV2.Rows[i].Cells[0].Value.ToString());
                        cdd.cmd.Parameters.AddWithValue("Name", DGV2.Rows[i].Cells[1].Value.ToString());
                        cdd.cmd.ExecuteNonQuery();
                        Shows();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error:" + ex.Message); }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            cdd.cmd = new SqlCommand("Delete from Province where ProvinceID=@ID", cdd.conn);
            cdd.cmd.Parameters.AddWithValue("ID", txtID.Text);
            cdd.cmd.ExecuteNonQuery();
            Shows();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString();
                txtName.Text = dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
