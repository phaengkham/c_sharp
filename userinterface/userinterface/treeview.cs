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
    public partial class treeview : Form
    {
        public treeview()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if((e.Action == TreeViewAction.ByMouse))
            {
                string userSecleted = "";
                userSecleted = e.Node.FullPath;
                MessageBox.Show(userSecleted, "ລາຍການທີ່ຖືກເລືອກ", MessageBoxButtons.YesNo);
            }
        }

        private void treeview_Load(object sender, EventArgs e)
        {

        }
    }
}
