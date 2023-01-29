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
    public partial class listboxcombobox : Form
    {
        public listboxcombobox()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userselect =  listBox1.SelectedItem.ToString();
            MessageBox.Show(userselect, "ລາຍການທີ່ຖືກເລືອກໃນ ListBox");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userselect = comboBox1.SelectedItem.ToString();
            MessageBox.Show(userselect, "ລາຍການທີ່ຖືກເລືອກໃນ ComboBox");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ສາຂາ ໄອທີ");
            listBox1.Items.Add("ສາຂາ ການເງິນ");
            listBox1.Items.Add("ສາຂາ ບໍລິຫານ");
            listBox1.Items.Add("ສາຂາ ພາສາອັງກິດ");
            listBox1.Items.Add("ສາຂາ ພາສາຈີນ");
            //listBox1.SelectedIndex = 0;

            comboBox1.Items.Add("ສາຂາ ໄອທີ");
            comboBox1.Items.Add("ສາຂາ ການເງິນ");
            comboBox1.Items.Add("ສາຂາ ບໍລິຫານ");
            comboBox1.Items.Add("ສາຂາ ພາສາອັງກິດ");
            comboBox1.Items.Add("ສາຂາ ພາສາຈີນ");
            //comboBox1.SelectedIndex = 0;
        }
    }
}
