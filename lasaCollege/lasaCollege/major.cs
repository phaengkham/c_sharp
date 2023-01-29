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
    public partial class major : Form
    {
        public major()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cnt = new connection();

        private void showMajorData()
        {
            da=new SqlDataAdapter("select * from major",cnt.cn);
            da.Fill(ds, "tbmajor");
            ds.Tables[0].Clear();
            da.Fill(ds, "tbmajor");
            dgv_show.DataSource = ds.Tables[0];
            dgv_show.Refresh();

            dgv_show.Columns["mid"].HeaderText = "ລະຫັດພາກວິຊາ";
            dgv_show.Columns["mname"].HeaderText = "ຊື່ພາກວິຊາ";
            dgv_show.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_show.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
            dgv_show.Columns[0].HeaderCell.Style.Font = new Font("Phetsarath OT", 14, FontStyle.Bold);
            dgv_show.Columns[1].HeaderCell.Style.Font = new Font("Phetsarath OT", 14, FontStyle.Bold);
            dgv_show.EnableHeadersVisualStyles = false;
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            studentform studentform =new studentform();
            studentform.Show();
            this.Hide();
        }

        private void major_Load(object sender, EventArgs e)
        {
            cnt.lasaConnectionDatabase();
            showMajorData();
        }

        private void txt_majorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_majorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cnt.cmd = new SqlCommand("insert into major values(@mid,@mname)",cnt.cn);
            cnt.cmd.Parameters.AddWithValue("mid",txt_majorId.Text);
            cnt.cmd.Parameters.AddWithValue("mname",txt_majorName.Text);
            cnt.cmd.ExecuteNonQuery();
            showMajorData();

            txt_majorId.Clear();
            txt_majorName.Clear();
            txt_majorId.Focus();
        }

        private void dgv_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_majorId.Text = dgv_show.SelectedRows[0].Cells[0].Value.ToString();
            txt_majorName.Text=dgv_show.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cnt.cmd = new SqlCommand("update major set mid=@mid,mname=@mname where mid=@mid",cnt.cn);
            cnt.cmd.Parameters.AddWithValue("mid", txt_majorId.Text);
            cnt.cmd.Parameters.AddWithValue("mname", txt_majorName.Text);
            cnt.cmd.ExecuteNonQuery();
            showMajorData();
            txt_majorId.Clear();
            txt_majorName.Clear();
            txt_majorId.Focus();
        }

        private void btn_delecte_Click(object sender, EventArgs e)
        {
            cnt.cmd = new SqlCommand("delete major where mid=@mid",cnt.cn);
            cnt.cmd.Parameters.AddWithValue("mid", txt_majorId.Text);
            cnt.cmd.Parameters.AddWithValue("mname", txt_majorName.Text);
            cnt.cmd.ExecuteNonQuery();
            showMajorData();
            txt_majorId.Clear();
            txt_majorName.Clear();
            txt_majorId.Focus();
        }
    }
}
