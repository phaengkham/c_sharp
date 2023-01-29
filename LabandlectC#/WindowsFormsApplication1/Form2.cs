using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection conn=new MySqlConnection();
        MySqlDataAdapter da;
        MySqlCommand cm;
        DataSet ds;
        string strconn = "server=localhost;user id=root;database=CSHARP2";
        private void Form2_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn = new MySqlConnection(strconn);
            conn.Open();
            loadding();
        }
        private void loadding()
        {
            ds = new DataSet();
            string sql = "Select * from tbstudent";
            da = new MySqlDataAdapter(sql, conn);
            da.Fill(ds, "S");
            dgv.DataSource = ds.Tables[0];
            dgv.Refresh();
            
            //MessageBox.Show("ok");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into tbstudent values(@ID,@Name,@Sur,@Tel)";
                cm = new MySqlCommand(sql, conn);
                cm.Parameters.AddWithValue("ID", txtid.Text);
                cm.Parameters.AddWithValue("Name", txtname.Text);
                cm.Parameters.AddWithValue("Sur", txtsur.Text);
                cm.Parameters.AddWithValue("Tel", txttel.Text);
                cm.ExecuteNonQuery();
                loadding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Update tbstudent set name=@Name,lastname=@Sur,tel=@Tel where id=@ID";
                cm = new MySqlCommand(sql, conn);
                cm.Parameters.AddWithValue("ID", txtid.Text);
                cm.Parameters.AddWithValue("Name", txtname.Text);
                cm.Parameters.AddWithValue("Sur", txtsur.Text);
                cm.Parameters.AddWithValue("Tel", txttel.Text);
                cm.ExecuteNonQuery();
                loadding();
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
                string sql = "delete from tbstudent where id=@ID";
                cm = new MySqlCommand(sql, conn);
                cm.Parameters.AddWithValue("ID", txtid.Text);
                cm.ExecuteNonQuery();
                loadding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsur.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txttel.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            try {
                ds = new DataSet();
                string sql = "Select * from tbstudent where id like @ID or name like @ID or lastname like @ID";
                cm = new MySqlCommand(sql, conn);
                cm.Parameters.AddWithValue("ID", "%" + txtseach.Text + "%");
                da = new MySqlDataAdapter(cm);
                da.Fill(ds, "S");
                dgv.DataSource = ds.Tables[0];
                dgv.Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
