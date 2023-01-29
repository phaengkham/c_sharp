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

namespace lasaCollege
{
    public partial class district : Form
    {
        public district()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds =new DataSet();
        connection cnt=new connection();

        private void showDistrict()
        {
           
            da=new SqlDataAdapter("select * from districtView", cnt.cn);
            da.Fill(ds, "view");
            ds.Tables.Clear();
            da.Fill(ds, "view");
            dgv_show.DataSource = ds.Tables["view"];

        }

        private void label5_Click(object sender, EventArgs e)
        {
            studentform studentform=new studentform();
            studentform.Show();
            this.Hide();
        }

        private void district_Load(object sender, EventArgs e)
        {
            cnt.lasaConnectionDatabase();
            showDistrict();
            da = new SqlDataAdapter("select * from district",cnt.cn);
            da.Fill(ds, "district");

            da = new SqlDataAdapter("select * from province", cnt.cn);
            da.Fill(ds, "province");
            cbb_province.DisplayMember = "pname";
            cbb_province.ValueMember = "pid";
            cbb_province.DataSource = ds.Tables["province"];

            dgv_show.Columns[0].HeaderText = "ລະຫັດເມືອງ";
            dgv_show.Columns[1].HeaderText = "ຊື່ເມືອງ";
            dgv_show.Columns[2].HeaderText = "ຊື່ແຂວງ";
            dgv_show.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_show.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
            dgv_show.Columns[0].HeaderCell.Style.Font = new Font("Phetsarath OT", 14, FontStyle.Bold);
            dgv_show.Columns[1].HeaderCell.Style.Font = new Font("Phetsarath OT", 14, FontStyle.Bold);
            dgv_show.Columns[2].HeaderCell.Style.Font = new Font("Phetsarath OT", 14, FontStyle.Bold);
            dgv_show.EnableHeadersVisualStyles = false;
        }

        private void btn_addProvince_Click(object sender, EventArgs e)
        {
            provinceform pr =new provinceform();
            pr.Show();
            this.Hide();
        }

        private void dgv_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_districtId.Text = dgv_show.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_districtName.Text = dgv_show.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbb_province.Text = dgv_show.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cnt.lasaConnectionDatabase();
            cnt.cmd = new SqlCommand("insert into district values(@did,@dname,@pid)",cnt.cn);
            cnt.cmd.Parameters.AddWithValue("did",txt_districtId.Text);
            cnt.cmd.Parameters.AddWithValue("dname",txt_districtName.Text);
            cnt.cmd.Parameters.AddWithValue("pid",cbb_province.SelectedValue);
            cnt.cmd.ExecuteNonQuery();
            showDistrict();
            txt_districtId.Clear();
            txt_districtName.Clear();
            txt_districtId.Focus();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cnt.lasaConnectionDatabase();
            cnt.cmd = new SqlCommand("update district set did=@did,dname=@dname,pid=@pid where did=@did",cnt.cn);
            cnt.cmd.Parameters.AddWithValue("did", txt_districtId.Text);
            cnt.cmd.Parameters.AddWithValue("dname", txt_districtName.Text);
            cnt.cmd.Parameters.AddWithValue("pid", cbb_province.SelectedValue);
            cnt.cmd.ExecuteNonQuery();
            showDistrict();
            txt_districtId.Clear();
            txt_districtName.Clear();
            txt_districtId.Focus();
        }

        private void btn_delecte_Click(object sender, EventArgs e)
        {
            cnt.lasaConnectionDatabase();
            cnt.cmd = new SqlCommand("delete district where did=@did",cnt.cn);
            cnt.cmd.Parameters.AddWithValue("did", txt_districtId.Text);
            cnt.cmd.Parameters.AddWithValue("dname", txt_districtName.Text);
            cnt.cmd.Parameters.AddWithValue("pid", cbb_province.SelectedValue);
            cnt.cmd.ExecuteNonQuery();
            showDistrict();
            txt_districtId.Clear();
            txt_districtName.Clear();
            txt_districtId.Focus();
        }
    }
}
