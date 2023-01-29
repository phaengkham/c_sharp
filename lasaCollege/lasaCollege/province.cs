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
    public partial class provinceform : Form
    {
        public provinceform()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cnt = new connection();

        private void provinceform_Load(object sender, EventArgs e)
        {
            cnt.lasaConnectionDatabase();
            showProvince();
        }
        private void showProvince()
        {
            da = new SqlDataAdapter("Select * from province", cnt.cn);
            da.Fill(ds, "tbprovince");
            ds.Tables[0].Clear();
            da.Fill(ds, "tbprovince");
            dgv.DataSource = ds.Tables[0];
            dgv.Refresh();

            dgv.Columns["pid"].HeaderText = "ລະຫັດແຂວງ";
            dgv.Columns["pname"].HeaderText = "ຊື່ແຂວງ";
            dgv.ColumnHeadersDefaultCellStyle.ForeColor=Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor=Color.Red;
            dgv.Columns[0].HeaderCell.Style.Font=new Font("Phetsarath OT",14,FontStyle.Bold);
            dgv.Columns[1].HeaderCell.Style.Font = new Font("Phetsarath OT", 14, FontStyle.Bold);
            dgv.EnableHeadersVisualStyles = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.cmd = new SqlCommand("insert into province values(@pid,@pname)", cnt.cn);
                cnt.cmd.Parameters.AddWithValue("pid", txt_provinceId.Text);
                cnt.cmd.Parameters.AddWithValue("pname", txt_provincename.Text);
                cnt.cmd.ExecuteNonQuery();
                showProvince();
                MessageBox.Show("ຂໍ້ມູນຖືກບັນທຶກແລ້ວ");
                txt_provinceId.Clear();
                txt_provincename.Clear();
                txt_provinceId.Focus();
            }
            catch
            {
                MessageBox.Show("ຜິດທີ່ປຸ່ມບັນທຶກ");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.cmd = new SqlCommand("update province set pid=@pid,pname=@pname where pid=@pid", cnt.cn);
                cnt.cmd.Parameters.AddWithValue("pid", txt_provinceId.Text);
                cnt.cmd.Parameters.AddWithValue("pname", txt_provincename.Text);
                cnt.cmd.ExecuteNonQuery();
                showProvince();
                MessageBox.Show("ຂໍ້ມູນຖືກແກ້ໄຂແລ້ວ");
                txt_provinceId.Clear();
                txt_provincename.Clear();
                txt_provinceId.Focus();
            }
            catch
            {
                MessageBox.Show("ຜິດທີ່ປຸ່ມແກ້ໄຂ");
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_provinceId.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                txt_provincename.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("ຜິດທີ່ DataGridView");
            }
        }

        private void btn_delecte_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.cmd = new SqlCommand("delete province where pid=@pid", cnt.cn);
                cnt.cmd.Parameters.AddWithValue("pid", txt_provinceId.Text);
                cnt.cmd.Parameters.AddWithValue("pname", txt_provincename.Text);
                cnt.cmd.ExecuteNonQuery();
                showProvince();
                MessageBox.Show("ຂໍ້ມູນຖືກລຶບແລ້ວ");
                txt_provinceId.Clear();
                txt_provincename.Clear();
                txt_provinceId.Focus();
            }
            catch
            {
                MessageBox.Show("ຜິດທີ່ປຸ່ມລຶບ");
            }
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            district ds=new district();
            ds.Show();
            this.Show();
        }
    }
}
