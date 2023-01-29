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
    public partial class listview : Form
    {
        public listview()
        {
            InitializeComponent();
        }

        private void listview_Load(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            listView1.View = View.Details;
            listView1.Columns.Add("ລະຫັດສິນຄ້າ", 150);
            listView1.Columns.Add("ຊື່ສິນຄ້າ", 300);
            listView1.Columns.Add("ລາຄາ", 150);

            lvi = listView1.Items.Add("002");
            lvi.SubItems.Add("ປື້ມໃຫ້ແຮງບັນດາໃຈ");
            lvi.SubItems.Add("140.000 ກີບ");

            lvi = listView1.Items.Add("003");
            lvi.SubItems.Add("ປື້ມກ່ຽວກັບທຸລະກິດ");
            lvi.SubItems.Add("160.000 ກີບ");

            lvi = listView1.Items.Add("004");
            lvi.SubItems.Add("ປື້ມກົດໝາຍອາຍາ");
            lvi.SubItems.Add("180.000 ກີບ");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";
            ListViewItem lvi = default(ListViewItem);
            if(listView1.SelectedItems.Count > 0)
            {
               lvi = listView1.SelectedItems[0];
                str = "ລະຫັດສິນຄ້າ:" + lvi.Text + Environment.NewLine
                + "ຊື່ສິນຄ້າ:" + lvi.SubItems[1].Text + Environment.NewLine
                + "ລາຄາ:" + lvi.SubItems[2].Text + Environment.NewLine;
                MessageBox.Show(str, "ລາຍການທີ່ຖືກເລືອກ");
            }

        }
    }
}
