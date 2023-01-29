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
    public partial class FormReligion : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        ClassConnetDatabase cd = new ClassConnetDatabase();
        string sql;
        public FormReligion()
        {
            InitializeComponent();
        }
        public void ShowReligion()
        {

            ds = new DataSet();
            da = new SqlDataAdapter("Select * from Religion", cd.conn);
            da.Fill(ds, "R");
            ds.Tables[0].Clear();
            da.Fill(ds, "R");
            dgv.DataSource = ds.Tables[0];
            dgv.Refresh();
            dgv.Columns[0].HeaderText = "ລະຫັດສາສະໜາ";
            dgv.Columns[1].HeaderText = "ຊື່ສາສະໜາ";
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into Religion values(@ID,@Name)";
                cd.cmd = new SqlCommand(sql, cd.conn);
                cd.cmd.Parameters.AddWithValue("ID", txtID.Text);
                cd.cmd.Parameters.AddWithValue("Name", txtName.Text);
                cd.cmd.ExecuteNonQuery();
                ShowReligion();
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
                cd.cmd = new SqlCommand("update Religion set ReligionName=@Name where ReligionID=@ID", cd.conn);
                cd.cmd.Parameters.AddWithValue("ID", txtID.Text);
                cd.cmd.Parameters.AddWithValue("Name", txtName.Text);
                cd.cmd.ExecuteNonQuery();
                ShowReligion();
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
                cd.cmd = new SqlCommand("Delete from Religion where ReligionID=@ID", cd.conn);
                cd.cmd.Parameters.AddWithValue("ID", txtID.Text);
                cd.cmd.Parameters.AddWithValue("Name", txtName.Text);
                cd.cmd.ExecuteNonQuery();
                ShowReligion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
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

        private void FormReligion_Load(object sender, EventArgs e)
        {
            cd.connetDatabasecs31_2();
            ShowReligion();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != null)
                {
                    ds = new DataSet();
                    da = new SqlDataAdapter("Select * from Religion where ReligionID='" + txtID.Text + "'", cd.conn);
                    da.Fill(ds, "R");
                    ds.Tables[0].Clear();
                    da.Fill(ds, "R");
                    dgv.DataSource = ds.Tables[0];
                    dgv.Refresh();
                    dgv.Columns[0].HeaderText = "ລະຫັດສາສະໜາ";
                    dgv.Columns[1].HeaderText = "ຊື່ສາສະໜາ";
                    dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    ds = new DataSet();
                    da = new SqlDataAdapter("Select * from Religion ", cd.conn);
                    da.Fill(ds, "R");
                    ds.Tables[0].Clear();
                    da.Fill(ds, "R");
                    dgv.DataSource = ds.Tables[0];
                    dgv.Refresh();
                    dgv.Columns[0].HeaderText = "ລະຫັດສາສະໜາ";
                    dgv.Columns[1].HeaderText = "ຊື່ສາສະໜາ";
                    dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                
            }catch (Exception ex)
            {

            }
            
        }
    }
}
