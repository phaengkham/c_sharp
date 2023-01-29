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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ConnectDatabase cd = new ConnectDatabase();

        private void frmStudent_Load(object sender, EventArgs e)
        {
            cd.ConnectDatabase3CS1_2();
            ShowStudent();
        }
        private void ShowStudent()
        {
            da = new SqlDataAdapter("Select * from Student", cd.conn);
            da.Fill(ds, "Student");
            ds.Tables[0].Clear();
            da.Fill(ds, "Student");
            DGV2.DataSource = ds.Tables[0];
            DGV2.Refresh();
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog1.ShowDialog();
            filename = OpenFileDialog1.FileName;
            OleDbConnection connExcel = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data source=" + filename + "; Extended Properties=Excel 12.0;");
            OleDbDataAdapter daEx = new OleDbDataAdapter("Select * from [Sheet1$]", connExcel);
            DataSet dsEx = new DataSet();
            daEx.Fill(dsEx, "Excel");
            dsEx.Tables[0].Clear();
            daEx.Fill(dsEx, "Excel");
            DGV1.DataSource = dsEx.Tables[0];
            DGV1.Refresh();
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            DGV1.Columns.Add(chk);
            chk.HeaderText="ເລືອກ";

        }

        private void btnChooseSave_Click(object sender, EventArgs e)
        {
            int i, j;
            bool check = false;
            string info="";
            for (i = 0; i < DGV1.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(DGV1.Rows[i].Cells[4].Value) == true)
                {
                    for (j = 0; j < DGV2.RowCount - 1; j++)
                    {
                        if (DGV1.Rows[i].Cells[0].Value.ToString() == DGV2.Rows[j].Cells[0].Value.ToString())
                        {
                            check = true;
                            info = DGV1.Rows[i].Cells[1].Value + " " + DGV1.Rows[i].Cells[2].Value + " " + DGV1.Rows[i].Cells[3].Value + " ມີແລ້ວ";
                        }
                    }
                    if (check == true)
                    {
                        MessageBox.Show(info);
                    }
                    else {
                        cd.cmd = new SqlCommand("Insert into Student values(@StudentID,@Title,@StudentName,@Surname)", cd.conn);
                        cd.cmd.Parameters.AddWithValue("StudentID", DGV1.Rows[i].Cells[0].Value);
                        cd.cmd.Parameters.AddWithValue("Title", DGV1.Rows[i].Cells[1].Value);
                        cd.cmd.Parameters.AddWithValue("StudentName", DGV1.Rows[i].Cells[2].Value);
                        cd.cmd.Parameters.AddWithValue("Surname", DGV1.Rows[i].Cells[3].Value);
                        cd.cmd.ExecuteNonQuery();
                        ShowStudent();
                    }
                    check = false;
                }
               
            }
        }

        private void btnAllSave_Click(object sender, EventArgs e)
        {
            int i, j;
            bool check = false;
            string info = "";
            for (i = 0; i < DGV1.RowCount - 1; i++)
            {
                    for (j = 0; j < DGV2.RowCount - 1; j++)
                    {
                        if (DGV1.Rows[i].Cells[0].Value.ToString() == DGV2.Rows[j].Cells[0].Value.ToString())
                        {
                            check = true;
                            info = DGV1.Rows[i].Cells[1].Value + " " + DGV1.Rows[i].Cells[2].Value + " " + DGV1.Rows[i].Cells[3].Value + " ມີແລ້ວ";
                        }
                    }
                    if (check == true)
                    {
                        MessageBox.Show(info);
                    }
                    else
                    {
                        cd.cmd = new SqlCommand("Insert into Student values(@StudentID,@Title,@StudentName,@Surname)", cd.conn);
                        cd.cmd.Parameters.AddWithValue("StudentID", DGV1.Rows[i].Cells[0].Value);
                        cd.cmd.Parameters.AddWithValue("Title", DGV1.Rows[i].Cells[1].Value);
                        cd.cmd.Parameters.AddWithValue("StudentName", DGV1.Rows[i].Cells[2].Value);
                        cd.cmd.Parameters.AddWithValue("Surname", DGV1.Rows[i].Cells[3].Value);
                        cd.cmd.ExecuteNonQuery();
                        ShowStudent();
                    }
                    check = false;
                }
        }
    }
}
