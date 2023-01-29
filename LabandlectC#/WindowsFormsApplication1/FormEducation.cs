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
using DLLFile;
namespace WindowsFormsApplication1
{
    public partial class FormEducation : Form
    {
        int seach;
        public FormEducation()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        ClassConnetDatabase cd = new ClassConnetDatabase();
        //ClassconnetDatabasecs31_2 cdd = new ClassconnetDatabasecs31_2() ;
        private void FormEducation_Load(object sender, EventArgs e)
        {
            cd.connetDatabasecs31_2();
            //cdd.connetionDatabasecs31_2();
            ShowEducation();
        }
        public void ShowEducation()
        {
            da = new SqlDataAdapter("Select * from Education", cd.conn);
            da.Fill(ds, "e");
            ds.Tables[0].Clear();
            da.Fill(ds, "e");
            dgv.DataSource = ds.Tables[0];
            dgv.Refresh();
            dgv.Columns[0].HeaderText = "ລະຫັດລະດັບການສຶກສາ";
            dgv.Columns[1].HeaderText = "ຊື່ລະດັບການສຶກສາ";
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Education values(@ID,@Name)",cd.conn);
            cmd.Parameters.AddWithValue("ID", txtID.Text);
            cmd.Parameters.AddWithValue("Name", txtName.Text);
            cmd.ExecuteNonQuery();
            ShowEducation();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update  Education set EducationName=@Name where EducationID=@ID", cd.conn);
            cmd.Parameters.AddWithValue("ID", txtID.Text);
            cmd.Parameters.AddWithValue("Name", txtName.Text);
            cmd.ExecuteNonQuery();
            ShowEducation();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Delete from Education where EducationID=@ID", cd.conn);
            cmd.Parameters.AddWithValue("ID", txtID.Text);
            cmd.ExecuteNonQuery();
            ShowEducation();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seach = 4;
            try
            {
                txtID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            }catch (Exception ex)
            {

            }
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(seach != 4)
                {
                    if (txtID.Text == "")
                    {

                        ShowEducation();
                    }
                    else
                    {
                        da = new SqlDataAdapter("Select * from Education where EducationID='" + txtID.Text + "'", cd.conn);
                        da.Fill(ds, "e");
                        ds.Tables[0].Clear();
                        da.Fill(ds, "e");
                        dgv.DataSource = ds.Tables[0];
                        dgv.Refresh();
                        dgv.Columns[0].HeaderText = "ລະຫັດລະດັບການສຶກສາ";
                        dgv.Columns[1].HeaderText = "ຊື່ລະດັບການສຶກສາ";
                        dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                seach = 2;
                
            }
            catch(Exception ex)
            {

            }
        }
    }
}
