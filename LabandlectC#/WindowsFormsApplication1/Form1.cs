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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showdata();
        }
        SqlConnection conn =new SqlConnection() ;
        SqlDataAdapter da;
        DataSet ds;
        string sql;
        SqlCommand cm;
        string strcon = @"Data Source=hp;Initial Catalog=Labvc;User=sa; pwd=1234";
        private void showdata()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.ConnectionString = strcon;
            conn.Open();
            // MessageBox.Show("connetion already");
            ds = new DataSet();
            sql = "select * from Employee";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "E");
            ds.Tables[0].Clear();
            da.Fill(ds, "E");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            dataGridView1.Columns[0].HeaderText = "ລະຫັດພະນັກງານ";
            dataGridView1.Columns[1].HeaderText = "ຊື່";
            dataGridView1.Columns[2].HeaderText = "ນາມສະກຸນ";
            dataGridView1.Columns[3].HeaderText = "ທີ່ຢູ່";
            dataGridView1.Columns[4].HeaderText = "ເບີໂທ";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            sql = "insert into employee values(@ID,@Name,@Sur,@Address,@Tel)";
            cm = new SqlCommand(sql, conn);
            cm.Parameters.AddWithValue("ID", txtId.Text);
            cm.Parameters.AddWithValue("Name", txtName.Text);
            cm.Parameters.AddWithValue("Sur", txtSur.Text);
            cm.Parameters.AddWithValue("Address", txtaddress.Text);
            cm.Parameters.AddWithValue("Tel", txttel.Text);
            cm.ExecuteNonQuery();
            showdata();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            sql = "Update Employee set Name=@Name,SurName=@Sur,Address=@Address,Tel=@Tel where ID = @ID";
            cm = new SqlCommand(sql, conn);
            cm.Parameters.AddWithValue("ID", txtId.Text);
            cm.Parameters.AddWithValue("Name", txtName.Text);
            cm.Parameters.AddWithValue("Sur", txtSur.Text);
            cm.Parameters.AddWithValue("Address", txtaddress.Text);
            cm.Parameters.AddWithValue("Tel", txttel.Text);
            cm.ExecuteNonQuery();
            showdata();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            sql = "Delete from Employee where ID = @ID";
            cm = new SqlCommand(sql, conn);
            cm.Parameters.AddWithValue("ID", txtId.Text);
            cm.ExecuteNonQuery();
            showdata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSur.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
