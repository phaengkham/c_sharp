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
    public partial class tooltip : Form
    {
        public tooltip()
        {
            InitializeComponent();
        }

        private void tooltip_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txt_name, "ກະລຸນາປ້ອນຊື່ ແລະ ນາມສະກຸນ");
            toolTip1.SetToolTip(maskedTextBox1, "ກະລຸນາປ້ອນເບີໂທລະສັບ");
        }
    }
}
