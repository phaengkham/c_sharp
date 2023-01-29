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
    public partial class statuspaid : Form
    {
        public statuspaid()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cnt = new connection();

        private void lb_back_Click(object sender, EventArgs e)
        {
            studentform studentform = new studentform();
            studentform.Show();
            this.Hide();
        }

        private void statuspaid_Load(object sender, EventArgs e)
        {
            cnt.lasaConnectionDatabase();
            showData();
           
        }
        private void showData()
        {
            da=new SqlDataAdapter("select * from statusPaid",cnt.cn);
            da.Fill(ds, "statusPaid");
            ds.Tables[0].Clear();
            da.Fill(ds,"statusPaid");
            dgv_show.DataSource = ds.Tables[0];
            dgv_show.Refresh();

            dgv_show.Columns["sid"].HeaderText = "ລະຫັດສະຖານະການຈ່າຍເງິນ";
            dgv_show.Columns["sname"].HeaderText = "ສະຖານະການຈ່າຍເງິນ";
            dgv_show.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_show.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
            dgv_show.Columns[0].HeaderCell.Style.Font = new Font("Phetsarath OT", 14, FontStyle.Bold);
            dgv_show.Columns[1].HeaderCell.Style.Font = new Font("Phetsarath OT", 14, FontStyle.Bold);
            dgv_show.EnableHeadersVisualStyles = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.cmd = new SqlCommand("insert into statusPaid values(@sid,@sname)",cnt.cn);
                cnt.cmd.Parameters.AddWithValue("sid",txt_statusId.Text);
                cnt.cmd.Parameters.AddWithValue("sname", txt_statusName.Text);
                cnt.cmd.ExecuteNonQuery();
                showData();
                MessageBox.Show("Save Successfully");
                txt_statusId.Clear();
                txt_statusName.Clear();
                txt_statusId.Focus();
            }
            catch
            {
                MessageBox.Show("error in save button");
            }
        }

        private void dgv_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_statusId.Text = dgv_show.SelectedRows[0].Cells[0].Value.ToString();
            txt_statusName.Text=dgv_show.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cnt.cmd = new SqlCommand("update statusPaid set sid=@sid,sname=@sname where sid=@sid",cnt.cn);
            cnt.cmd.Parameters.AddWithValue("sid", txt_statusId.Text);
            cnt.cmd.Parameters.AddWithValue("sname", txt_statusName.Text);
            cnt.cmd.ExecuteNonQuery();
            showData();
            MessageBox.Show("update successfully");
            txt_statusId.Clear();
            txt_statusName.Clear();
            txt_statusId.Focus();
        }

        private void btn_delecte_Click(object sender, EventArgs e)
        {
            cnt.cmd = new SqlCommand("delete statusPaid where sid=@sid",cnt.cn);
            cnt.cmd.Parameters.AddWithValue("sid", txt_statusId.Text);
            cnt.cmd.Parameters.AddWithValue("sname", txt_statusName.Text);
            cnt.cmd.ExecuteNonQuery();
            showData();
            MessageBox.Show("delete successfully");
            txt_statusId.Clear();
            txt_statusName.Clear();
            txt_statusId.Focus();
        }
    }
}
