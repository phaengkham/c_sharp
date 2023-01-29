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

namespace WindowsFormsApplication1
{
    public partial class FormPosition : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        ClassConnetDatabase cd = new ClassConnetDatabase();
        string sql;
        public FormPosition()
        {
            InitializeComponent();
        }
        public void ShowPosition()
        {

            ds = new DataSet();
            da = new SqlDataAdapter("Select * from Position", cd.conn);
            da.Fill(ds, "P");
            ds.Tables[0].Clear();
            da.Fill(ds, "P");
            dgv.DataSource = ds.Tables[0];
            dgv.Refresh();
            dgv.Columns[0].HeaderText = "ລະຫັດຕໍາແໜ່ງ";
            dgv.Columns[1].HeaderText = "ຊື່ຕໍາແໜ່ງ";
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void FormPosition_Load(object sender, EventArgs e)
        {
            cd.connetDatabasecs31_2();
            ShowPosition();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into Position values(@ID,@Name)";
                cd.cmd = new SqlCommand(sql, cd.conn);
                cd.cmd.Parameters.AddWithValue("ID", txtID.Text);
                cd.cmd.Parameters.AddWithValue("Name", txtName.Text);
                cd.cmd.ExecuteNonQuery();
                ShowPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "Update Position set PositionName=@Name where PositionID=@ID";
                cd.cmd = new SqlCommand(sql, cd.conn);
                cd.cmd.Parameters.AddWithValue("ID", txtID.Text);
                cd.cmd.Parameters.AddWithValue("Name", txtName.Text);
                cd.cmd.ExecuteNonQuery();
                ShowPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "Delete from Position where PositionID=@ID";
                cd.cmd = new SqlCommand(sql, cd.conn);
                cd.cmd.Parameters.AddWithValue("ID", txtID.Text);
                cd.cmd.ExecuteNonQuery();
                ShowPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
