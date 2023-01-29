using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userinterface
{
    public partial class checklist : Form
    {
        public checklist()
        {
            InitializeComponent();
        }

        private void checklist_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("ສາຂາ ໄອທີ",false);
            checkedListBox1.Items.Add("ສາຂາ ການເງິນ", false);
            checkedListBox1.Items.Add("ສາຂາ ພາສາອັງກິດ",false);
            checkedListBox1.Items.Add("ສາຂາ ພາສາຈີນ", false);
            checkedListBox1.Items.Add("ສາຂາ ພາສາຝຣັ່ງ", false);
            checkedListBox1.Items.Add("ສາຂາ ພາສາຢີປຸ່ນ", false);
            checkedListBox1.Items.Add("ສາຂາ ການຄຸ່ມຄອງ", false);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = "";
            foreach (string str in checkedListBox1.CheckedItems)
            {
                select = select + str + Environment.NewLine;
            }
            //MessageBox.Show(select, "ຜົນຂອງການກວດສອບ");
            richTextBox1.Text = select;
        }

        private void btn_showphone_Click(object sender, EventArgs e)
        {
            string number = maskedTextBox1.Text;
            txt_showphone.Text = number;
            label2.Text = number;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
