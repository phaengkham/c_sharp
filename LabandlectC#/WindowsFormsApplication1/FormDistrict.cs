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
    public partial class FormDistrict : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ClassConnetDatabase cd = new ClassConnetDatabase();
        string sql = null;
        public FormDistrict()
        {
            InitializeComponent();
            
        }
        private void showdata()
        {
            try
            {
                cd.connetDatabasecs31_2();
                ds = new DataSet();
                sql = "Select DistrictID,DistrictName,ProvinceName from View_District";
                da = new SqlDataAdapter(sql, cd.conn);
                da.Fill(ds, "D");
                ds.Tables[0].Clear();
                da.Fill(ds, "D");
                dgv.DataSource = ds.Tables[0];
                dgv.Refresh();
                dgv.Columns[0].HeaderText = "ລະຫັດເມືອງ";
                dgv.Columns[1].HeaderText = "ຊື່ເມືອງ";
                dgv.Columns[2].HeaderText = "ຊື່ແຂວງ";
                dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void FormDistrict_Load(object sender, EventArgs e)
        {
            try
            {
                cd.connetDatabasecs31_2();
                da = new SqlDataAdapter("Select *from Province", cd.conn);
                //ds = new DataSet();
                da.Fill(ds, "P");
                ds.Tables[0].Clear();
                da.Fill(ds, "P");
                cmbProvince.DataSource = ds.Tables[0];
                cmbProvince.DisplayMember = "ProvinceName";
                cmbProvince.ValueMember = "ProvinceID";
                txtID.Enabled = false;
            }catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            showdata();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cd.connetDatabasecs31_2();
                sql = "insert into District values(@DName,@PID)";
                cd.cmd =new SqlCommand(sql, cd.conn);
                //cd.cmd.Parameters.AddWithValue("DID", txtID.Text);
                cd.cmd.Parameters.AddWithValue("DName", txtName.Text);
                cd.cmd.Parameters.AddWithValue("PID", cmbProvince.SelectedValue);
                cd.cmd.ExecuteNonQuery();
                showdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                cd.connetDatabasecs31_2();
                sql = "Update District set DistrictName=@DName,ProvinceID=@PID where DistrictID=@DID";
                cd.cmd = new SqlCommand(sql, cd.conn);
                cd.cmd.Parameters.AddWithValue("DID", txtID.Text);
                cd.cmd.Parameters.AddWithValue("DName", txtName.Text);
                cd.cmd.Parameters.AddWithValue("PID", cmbProvince.SelectedValue);
                cd.cmd.ExecuteNonQuery();
                showdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbProvince.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                cd.connetDatabasecs31_2();
                sql = "Delete from District  where DistrictID=@DID";
                cd.cmd = new SqlCommand(sql, cd.conn);
                cd.cmd.Parameters.AddWithValue("DID", txtID.Text);
                cd.cmd.ExecuteNonQuery();
                showdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
