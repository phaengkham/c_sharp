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
    public partial class occupation : Form
    {
        public occupation()
        {
            InitializeComponent();
        }
        SqlDataAdapter da=new SqlDataAdapter();
        DataSet ds=new DataSet();
        connection cnt = new connection();

        private void showOccupation()
        {
            da = new SqlDataAdapter("Select * from occupation", cnt.cn);
            da.Fill(ds, "tboccupation");
            ds.Tables[0].Clear();
            da.Fill(ds, "tboccupation");
            dgv_show.DataSource = ds.Tables[0];
            dgv_show.Refresh();

            dgv_show.Columns["oid"].HeaderText = "ລະຫັດອາຊີບ";
            dgv_show.Columns["oname"].HeaderText = "ຊື່ອາຊີບ";
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

        private void occupation_Load(object sender, EventArgs e)
        {
            cnt.lasaConnectionDatabase();
            showOccupation();
        }

        private void dgv_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_occupationId.Text = dgv_show.SelectedRows[0].Cells[0].Value.ToString();
            txt_occupation.Text=dgv_show.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cnt.cmd = new SqlCommand("insert into occupation values(@oid,@oname)", cnt.cn);
            cnt.cmd.Parameters.AddWithValue("oid", txt_occupationId.Text);
            cnt.cmd.Parameters.AddWithValue("oname",txt_occupation.Text);
            cnt.cmd.ExecuteNonQuery();
            showOccupation();
            txt_occupationId.Clear();
            txt_occupation.Clear();
            txt_occupationId.Focus();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cnt.cmd = new SqlCommand("update occupation set oid=@oid,oname=@oname where oid=@oid", cnt.cn);
            cnt.cmd.Parameters.AddWithValue("oid", txt_occupationId.Text);
            cnt.cmd.Parameters.AddWithValue("oname", txt_occupation.Text);
            cnt.cmd.ExecuteNonQuery();
            showOccupation();
            txt_occupationId.Clear();
            txt_occupation.Clear();
            txt_occupationId.Focus();
        }

        private void btn_delecte_Click(object sender, EventArgs e)
        {
            cnt.cmd = new SqlCommand("delete occupation where oid=@oid", cnt.cn);
            cnt.cmd.Parameters.AddWithValue("oid", txt_occupationId.Text);
            cnt.cmd.Parameters.AddWithValue("oname", txt_occupation.Text);
            cnt.cmd.ExecuteNonQuery();
            showOccupation();
            txt_occupationId.Clear();
            txt_occupation.Clear();
            txt_occupationId.Focus();
        }
    }
}
