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
    public partial class FormEmployee : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ClassConnetDatabase ccd = new ClassConnetDatabase();
        string gender="";
        string Emstatus="";
        string workType="";
        string sql;
        public FormEmployee()
        {
            InitializeComponent();


        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            txtpath.Enabled = true;
            try
            {
                ccd.connetDatabasecs31_2();
                loadprivince();
                loadEducation();
                loadDepartment();
                loadPosition();
                loadEthnic();
                loadReligion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            
        }

        //
        private void loadprivince()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from Province", ccd.conn);
            da.Fill(ds, "P");
            cmbprovince.DataSource = ds.Tables[0];
            cmbprovince.DisplayMember = "ProvinceName";
            cmbprovince.ValueMember = "ProvinceID";
            //cmbprovince.SelectedIndex = 0;
        }
        //
        private void loadEducation()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from Education", ccd.conn);
            da.Fill(ds, "E");
            cmbEducation.DataSource = ds.Tables[0];
            cmbEducation.DisplayMember = "EducationName";
            cmbEducation.ValueMember = "EducationID";
            //cmbEducation.SelectedIndex = 0;
        }
        //
        private void loadDepartment()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from Department", ccd.conn);
            da.Fill(ds, "D");
            cmbDepartment.DataSource = ds.Tables[0];
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentID";
            //cmbPosition.SelectedIndex = 0;
        }
        //
        private void loadPosition()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from Position", ccd.conn);
            da.Fill(ds, "Pt");
            cmbPosition.DataSource = ds.Tables[0];
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "PositionID";
            //cmbPosition.SelectedIndex = 0;
        }
        //
        private void loadEthnic()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from Ethnic", ccd.conn);
            da.Fill(ds, "E");
            cmbEthnic.DataSource = ds.Tables[0];
            cmbEthnic.DisplayMember = "EthnicName";
            cmbEthnic.ValueMember = "EthnicID";
            //cmbEthnic.SelectedIndex = 0;
        }
        //
        private void loadReligion()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from Religion", ccd.conn);
            da.Fill(ds, "R");
            cmbreligion.DataSource = ds.Tables[0];
            cmbreligion.DisplayMember = "ReligionName";
            cmbreligion.ValueMember = "ReligionID";
            //cmbreligion.SelectedIndex = 0;
        }
        private void cmbdistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbprovince_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //cmbprovince.SelectedIndex = 0;
                int ID = int.Parse(cmbprovince.SelectedValue.ToString());
                ds = new DataSet();
                da = new SqlDataAdapter("select * from District where ProvinceID='" + ID + "'",ccd.conn);
                da.Fill(ds, "D");
                ds.Tables[0].Clear();
                da.Fill(ds, "D");
                cmbdistrict.DataSource = ds.Tables[0];
                cmbdistrict.DisplayMember = "DistrictName";
                cmbdistrict.ValueMember = "DistrictID";
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMale.Checked==true)
            {
                gender = rdbMale.Text;

                txtWomenData.Enabled = false;
                txtWomenData.Clear();
            }
        }

        private void rdbFamale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFamale.Checked == true)
            {
                gender = rdbFamale.Text;

                txtWomenData.Enabled = true;
            }
        }

        private void rdbsingle_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbsingle.Checked == true)
            {
                Emstatus = rdbsingle.Text;

                txtchildNo.Text = "0";
                txtchildNo.ReadOnly = true;

                txtSpouse.Text = "";
                txtSpouseSur.Text = "";
                txttxtSpousePlace.Text = "";
                txttxtSpousePlace.ReadOnly = true;
                txtSpouse.ReadOnly =true;
                txtSpouseSur.ReadOnly = true;
                workType = "";
                groupBox4.Enabled = false;
            }
        }

        private void rdbmarried_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbmarried.Checked == true)
            {
                Emstatus = rdbmarried.Text;

                txtchildNo.Text = "";
                txtchildNo.ReadOnly = false;

                txtSpouse.Text = "";
                txtSpouseSur.Text = "";
                txttxtSpousePlace.Text = "";
                txttxtSpousePlace.ReadOnly = false;
                txtSpouse.ReadOnly = false;
                txtSpouseSur.ReadOnly = false;
                groupBox4.Enabled = true;
            }
        }

        private void rdbDivorfe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDivorfe.Checked == true)
            {
                Emstatus = rdbDivorfe.Text;

                txtchildNo.Text = "";
                txtchildNo.ReadOnly = false;

                txtSpouse.Text = "";
                txtSpouseSur.Text = "";
                txttxtSpousePlace.Text = "";
                txttxtSpousePlace.ReadOnly = false;
                txtSpouse.ReadOnly = false;
                txtSpouseSur.ReadOnly = false;
                groupBox4.Enabled = true;
            }
        }

        private void rdbwidow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbwidow.Checked == true)
            {
                Emstatus = rdbwidow.Text;

                txtchildNo.Text = "";
                txtchildNo.ReadOnly = false;

                txtSpouse.Text = "";
                txtSpouseSur.Text = "";
                txttxtSpousePlace.Text = "";
                txttxtSpousePlace.ReadOnly = false;
                txtSpouse.ReadOnly = false;
                txtSpouseSur.ReadOnly = false;
                groupBox4.Enabled = true;
            }
        }

        private void rdbGoverment_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGoverment.Checked == true)
            {
                workType = rdbGoverment.Text;
            }
        }

        private void rdbsemiGoverment_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbsemiGoverment.Checked == true)
            {
                workType = rdbsemiGoverment.Text;
            }
        }

        private void rdbPrivate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPrivate.Checked == true)
            {
                workType = rdbPrivate.Text;
            }
        }

        private void rdbOrganization_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOrganization.Checked == true)
            {
                workType = rdbOrganization.Text;
            }
        }

        private void rdbBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBusiness.Checked == true)
            {
                workType = rdbBusiness.Text;
            }
        }

        private void rdbOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOther.Checked == true)
            {
                workType = rdbOther.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                txtpath.Text = openFileDialog1.FileName;
                pic.Image = Image.FromFile(txtpath.Text);
            }catch(Exception ex)
            {
                //MessageBox.Show("" + ex.Message);
            }
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string gender="",Emstatus="",Spworktype="";
                if (rdbMale.Checked==true)
                {
                    gender = rdbMale.Text;
                }else if (rdbFamale.Checked == true)
                {
                    gender = rdbFamale.Text;
                }
                if(rdbsingle.Checked == true)
                {
                    Emstatus = rdbsingle.Text;
                }else if (rdbmarried.Checked == true)
                {
                    Emstatus = rdbmarried.Text;
                }else if (rdbDivorfe.Checked == true)
                {
                    Emstatus = rdbDivorfe.Text;
                }else if (rdbwidow.Checked == true)
                {
                    Emstatus = rdbwidow.Text;
                }
                if (rdbGoverment.Checked == true)
                {
                    Spworktype = rdbGoverment.Text;
                }else if (rdbsemiGoverment.Checked == true)
                {
                    Spworktype = rdbsemiGoverment.Text;
                } else if (rdbPrivate.Checked == true)
                {
                    Spworktype = rdbPrivate.Text;
                }else if (rdbOrganization.Checked == true)
                {
                    Spworktype = rdbOrganization.Text;
                }else if (rdbBusiness.Checked == true)
                {
                    Spworktype = rdbBusiness.Text;
                }else if (rdbOther.Checked == true)
                {
                    Spworktype = rdbOther.Text;
                }
                //if (rdbMale.Checked == true)
                //{
                //    sql = "insert into Employee values(@EmID,@EmName,@SurName,@Gender,@Embirthday,@Village,@DtID,@ETID,@RLID,@DPID,@PSTID,@EDID,"
                //    + "@workdate,@Emstatus,@ChildNumber,@SpName,@SPSur,@Spworktype,@Spworkplace,@Youthdate,@welfaredate,@Partydate,@Photopath)";
                //}else if (rdbsingle.Checked == true && rdbMale.Checked == true)
                //{
                //    sql = "insert into Employee values(@EmID,@EmName,@SurName,@Gender,@Embirthday,@Village,@DtID,@ETID,@RLID,@DPID,@PSTID,@EDID,"
                //    + "@workdate,@Emstatus,@ChildNumber,@Youthdate,@welfaredate,@Partydate,@Photopath)";
                //}else if (rdbsingle.Checked == true && rdbFamale.Checked == true)
                //{
                //    sql = "insert into Employee values(@EmID,@EmName,@SurName,@Gender,@Embirthday,@Village,@DtID,@ETID,@RLID,@DPID,@PSTID,@EDID,"
                //    + "@workdate,@Emstatus,@ChildNumber,@Youthdate,@wamendate,@welfaredate,@Partydate,@Photopath)";
                //}
                //else
                //{
                //    sql = "insert into Employee values(@EmID,@EmName,@SurName,@Gender,@Embirthday,@Village,@DtID,@ETID,@RLID,@DPID,@PSTID,@EDID,"
                //    + "@workdate,@Emstatus,@ChildNumber,@SpName,@SPSur,@Spworktype,@Spworkplace,@Youthdate,@wamendate,@welfaredate,@Partydate,@Photopath)";
                //}
                sql = "insert into Employee values(@EmID,@EmName,@SurName)";//,@Gender,@Embirthday,@Village,@DtID,@ETID,@RLID,@DPID,@PSTID,@EDID,"
                //+ "@workdate,@Emstatus,@ChildNumber,@SpName,@SPSur,@Spworktype,@Spworkplace,@Youthdate,@wamendate,@welfaredate,@Partydate,@Photopath)";
                ccd.cmd = new SqlCommand(sql, ccd.conn);
                ccd.cmd.Parameters.AddWithValue("EmID", txtEm_ID);
                ccd.cmd.Parameters.AddWithValue("EmName", txtEm_Name);
                ccd.cmd.Parameters.AddWithValue("SurName", txtEm_Surname);
                //ccd.cmd.Parameters.AddWithValue("Gender", gender);
                //DateTime Embirthday = DateTime.Parse(txtdatebithday.Text);
                //ccd.cmd.Parameters.AddWithValue("Embirthday", Embirthday);
                //ccd.cmd.Parameters.AddWithValue("Village", txtvillage.Text);
                //ccd.cmd.Parameters.AddWithValue("DtID", cmbdistrict.SelectedValue);
                //ccd.cmd.Parameters.AddWithValue("ETID", cmbEthnic.SelectedValue);
                //ccd.cmd.Parameters.AddWithValue("RLID", cmbreligion.SelectedValue);
                //ccd.cmd.Parameters.AddWithValue("DPID", cmbDepartment.SelectedValue);
                //ccd.cmd.Parameters.AddWithValue("PSTID", cmbPosition.SelectedValue);
                //ccd.cmd.Parameters.AddWithValue("EDID", cmbEducation.SelectedValue);
                //DateTime workdate = DateTime.Parse(txtworkdate.Text);
                //ccd.cmd.Parameters.AddWithValue("workdate", workdate);
                //ccd.cmd.Parameters.AddWithValue("Emstatus", Emstatus);
                //int childNO = int.Parse(txtchildNo.Text);
                //ccd.cmd.Parameters.AddWithValue("ChildNumber", childNO);
                //ccd.cmd.Parameters.AddWithValue("SpName", txtSpouse.Text);
                //ccd.cmd.Parameters.AddWithValue("SPSur", txtSpouseSur.Text);
                //ccd.cmd.Parameters.AddWithValue("Spworktype", Spworktype);
                //ccd.cmd.Parameters.AddWithValue("Spworkplace", Spworktype);
                //ccd.cmd.Parameters.AddWithValue("Youthdate", txtyouthday.Text);
                //ccd.cmd.Parameters.AddWithValue("wamendate", txtWomenData.Text);
                //ccd.cmd.Parameters.AddWithValue("welfaredate", txtWelfareDate.Text);
                //ccd.cmd.Parameters.AddWithValue("Partydate", txtPartyData.Text);
                //ccd.cmd.Parameters.AddWithValue("Photopath", txtpath.Text);
                ccd.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void txtchildNo_TextChanged(object sender, EventArgs e)
        {
            if (txtchildNo.Text == "")
            {

            }
            else
            {
                int num;
                bool isnum = int.TryParse(txtchildNo.Text, out num);
                if (isnum == false)
                {
                    MessageBox.Show("ກະລຸນາປ້ອນຈໍານວນລູກເປັນຕົວເລກ");
                    txtchildNo.Clear();
                    txtchildNo.Focus();
                }
            }
            
        }
    }
}
