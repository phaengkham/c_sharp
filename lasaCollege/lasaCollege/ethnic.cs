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
    public partial class ethnic : Form
    {
        public ethnic()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cnt = new connection();

        private void showData()
        {
            da=new SqlDataAdapter("Select * from ethnicgroup",cnt.cn);
            da.Fill(ds, "ethnicgroup");
            ds.Tables[0].Clear();
            da.Fill(ds, "ethnicgroup");
            dgv_show.DataSource = ds.Tables[0];
            dgv_show.Refresh();

            dgv_show.Columns[0].HeaderText = "ລະຫັດຊົນເຜົ່າ";
            dgv_show.Columns[1].HeaderText = "ຊື່ຊົນເຜົ່າ";
        }


        private void ethnic_Load(object sender, EventArgs e)
        {
            cnt.lasaConnectionDatabase();
            showData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.cmd = new SqlCommand("insert into ethnicgroup values(@eid,@ename)",cnt.cn);
                cnt.cmd.Parameters.AddWithValue("eid",txt_ethnicId.Text);
                cnt.cmd.Parameters.AddWithValue("ename",txt_ethnicName.Text);
                cnt.cmd.ExecuteNonQuery();
                showData();
                MessageBox.Show("ຂໍ້ມູນຖືກບັນທຶກແລ້ວ");
                txt_ethnicId.Clear();
                txt_ethnicName.Clear();
                txt_ethnicId.Focus();
            }
            catch
            {
                MessageBox.Show("ຜິດທີ່ປຸ່ມບັນທຶກ");
            }
        }

        private void dgv_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ethnicId.Text = dgv_show.SelectedRows[0].Cells[0].Value.ToString();
            txt_ethnicName.Text = dgv_show.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cnt.cmd = new SqlCommand("update ethnicgroup set eid=@eid,ename=@ename where eid=@eid", cnt.cn);
            cnt.cmd.Parameters.AddWithValue("eid", txt_ethnicId.Text);
            cnt.cmd.Parameters.AddWithValue("ename", txt_ethnicName.Text);
            cnt.cmd.ExecuteNonQuery();
            showData();
            MessageBox.Show("ຂໍ້ມູນຖືກບັນທຶກແລ້ວ");
            txt_ethnicId.Clear();
            txt_ethnicName.Clear();
            txt_ethnicId.Focus();
        }

        private void btn_delecte_Click(object sender, EventArgs e)
        {
            cnt.cmd = new SqlCommand("delete ethnicgroup where eid=@eid", cnt.cn);
            cnt.cmd.Parameters.AddWithValue("eid", txt_ethnicId.Text);
            cnt.cmd.Parameters.AddWithValue("ename", txt_ethnicName.Text);
            cnt.cmd.ExecuteNonQuery();
            showData();
            MessageBox.Show("ຂໍ້ມູນຖືກບັນທຶກແລ້ວ");
            txt_ethnicId.Clear();
            txt_ethnicName.Clear();
            txt_ethnicId.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            studentform stdfm=new studentform();
            stdfm.Show();
            this.Hide();
        }
    }
}
