using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLFile;

namespace WindowsFormsApplication1
{
    public partial class FormExchageRate : Form
    {
        public FormExchageRate()
        {
            InitializeComponent();
            rdbKIPisBATH.Checked = true;
        }
        ExchageRate ER = new ExchageRate();
        private void FormExchageRate_Load(object sender, EventArgs e)
        {

        }

        private void btncalular_Click(object sender, EventArgs e)
        {
            if(rdbKIPisBATH.Checked == true)
            {
                double k, b;
                k = double.Parse(txtmoneyExchage.Text);
                b = double.Parse(txtRate.Text);
                txtResult.Text = ER.KipchageBath(k, b).ToString("#,###.00");
            }else if(rdbBATHisKIP.Checked == true)
            {
                double k, b;
                b = double.Parse(txtmoneyExchage.Text);
                k = double.Parse(txtRate.Text);
                txtResult.Text = ER.BathchageKip(b, k).ToString("#,###.00");
            }else if(rdbKIPisDollar.Checked == true)
            {
                double k, d;
                k = double.Parse(txtmoneyExchage.Text);
                d = double.Parse(txtRate.Text);
                txtResult.Text = ER.KipchageDollar(k, d).ToString("#,###.00");
            }
            else if (rdbDollarisKip.Checked == true)
            {
                double k, d;
                d = double.Parse(txtmoneyExchage.Text);
                k = double.Parse(txtRate.Text);
                txtResult.Text = ER.DollarchageKip(d, k).ToString("#,###.00");
            }
        }

        private void rdbKIPisBATH_CheckedChanged(object sender, EventArgs e)
        {
            lblExchageRate.Text = "ປັອນເງີນກີບ ປ່ຽນເປັນ ບາດ:";
            lblresult.Text = "ເງິນທີ່ເລກປ່ຽນໄດ້ເງິນບາດ:";
            lblRate.Text = "ປ້ອນອັດຕາເລກປ່ຽນເງິນບາດ:";
        }

        private void rdbBATHisKIP_CheckedChanged(object sender, EventArgs e)
        {
            lblExchageRate.Text = "ປັອນເງີນບາດ ປ່ຽນເປັນ ກີບ:";
            lblresult.Text = "ເງິນທີ່ເລກປ່ຽນໄດ້ເງິນກີບ:";
            lblRate.Text = "ປ້ອນອັດຕາເລກປ່ຽນເງິນບາດ:";
        }

        private void rdbKIPisDollar_CheckedChanged(object sender, EventArgs e)
        {
            lblExchageRate.Text = "ປັອນເງີນກີບ ປ່ຽນເປັນ ໂດລາ:";
            lblresult.Text = "ເງິນທີ່ເລກປ່ຽນໄດ້ເງິນໂດລາ:";
            lblRate.Text = "ປ້ອນອັດຕາເລກປ່ຽນເງິນໂດລາ:";
        }

        private void rdbDollarisKip_CheckedChanged(object sender, EventArgs e)
        {
            lblExchageRate.Text = "ປັອນເງີນໂດລາ ປ່ຽນເປັນ ກີບ:";
            lblresult.Text = "ເງິນທີ່ເລກປ່ຽນໄດ້ເງິນກີບ:";
            lblRate.Text = "ປ້ອນອັດຕາເລກປ່ຽນເງິນໂດລາ:";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            txtmoneyExchage.Clear();
            txtRate.Clear();
            txtResult.Clear();
        }

        private void txtmoneyExchage_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
