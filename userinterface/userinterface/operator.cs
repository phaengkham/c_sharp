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
    public partial class @operator : Form
    {
        public @operator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            x=int.Parse(txt_if.Text);
            if (x == 5)
            {
                lb_show_if.Text ="ທ່ານເດົາຖືກແລ້ວໄດ້ກິນເບຍ";
            }
            else { lb_show_if.Text = "ໂຕເລກໃຫ້ເດົາແມ່ນ 0-9";
            }
        }

        private void btn_grade_Click(object sender, EventArgs e)
        {
            double score;
            score=double.Parse(txt_grade.Text);
            if (score >= 80)
            {
                lb_grade.Text = "ເສັງຜ່ານໄດ້ເກຣດ A";
            }
            else if (score >= 75) { 
                lb_grade.Text = "ເສັງຜ່ານໄດ້ເກຣດ B+"; 
            }
            else if(score >= 70)
            {
                lb_grade.Text = "ເສັງຜ່ານໄດ້ເກຣດ B";
            }else if(score >= 65)
            {
                lb_grade.Text = "ເສັງຜ່ານໄດ້ເກຣດ C+";
            }
            else if (score >= 60)
            {
                lb_grade.Text = "ເສັງຜ່ານໄດ້ເກຣດ C";
            }
            else if (score >= 55)
            {
                lb_grade.Text = "ເສັງຜ່ານໄດ້ເກຣດ D+";
            }
            else if (score >= 50)
            {
                lb_grade.Text = "ເສັງຜ່ານໄດ້ເກຣດ D";
            }
            else
            {
                lb_grade.Text = "ເສັງຕົກໄດ້ເກຣດ F";
            }

        }

        private void btn_s_grade_Click(object sender, EventArgs e)
        {
            double score;
            score = double.Parse(txt_s_grade.Text);
            switch (score)
            {
                case 80:
                    lb_s_grade.Text = "ເສັງຜ່ານໄດ້ເກຣດ A";
                    break;
                case 70:
                    lb_s_grade.Text = "ເສັງຜ່ານໄດ້ເກຣດ B";
                    break;
                case 60:
                    lb_s_grade.Text = "ເສັງຜ່ານໄດ້ເກຣດ C";
                    break;
                case 50:
                    lb_s_grade.Text = "ເສັງຜ່ານໄດ້ເກຣດ D";
                    break;
                case 40:
                    lb_s_grade.Text = "ເສັງຕົກໄດ້ເກຣດ F";
                    break;
                case 30:
                    lb_s_grade.Text = "ເສັງຕົກໄດ້ເກຣດ F";
                    break;
                case 20:
                    lb_s_grade.Text = "ເສັງຕົກໄດ້ເກຣດ F";
                    break;
                case 10:
                    lb_s_grade.Text = "ເສັງຕົກກັບໄປຮຽນຄື່ນ";
                    break;
                case 0:
                    lb_s_grade.Text = "ເສັງຕົກກັບໄປຮຽນຄື່ນ";
                    break;
                default:
                    lb_s_grade.Text = "ປ້ອນໄດ້ແຕ່ເລກຖ້ວນສິບ";
                    break;

            }
        }
        private void btn_select_Click(object sender, EventArgs e)
        {
            string selected;
            selected = txt_select.Text;
            switch (selected)
            {
                case "a":
                    lb_selected.Text = "ໄດ້ຄົບແຟນເກົ່າອີກ";
                    break;
                case "b":
                    lb_selected.Text = "ໄດ້ເປັນສ່ວນເກີນ";
                    break;
                case "c":
                    lb_selected.Text = "ໄດ້ແຟນໜ້າຕາດີ";
                    break;
                case "d":
                    lb_selected.Text = "ໄດ້ແຟນມັກຫຼີ້ນດົນຕຣີ";
                    break;
                case "e":
                    lb_selected.Text = "ຖືກແຟນເກົ່າມອງຂ້າມ";
                    break;
                case "f":
                    lb_selected.Text = "ໄດ້ຜົວເປັນຄົນຈົນ";
                    break;
                case "g":
                    lb_selected.Text = "ໂສດຕະຫຼອດຊີວິດ";
                    break;
                case "h":
                    lb_selected.Text = "ມີຄົນຫລົງຮັກ";
                    break;
                case "i":
                    lb_selected.Text = "ຫລົງຮັກແຟນເຂົາ";
                    break;
                case "j":
                    lb_selected.Text = "ໄດ້ເປັນມືທີສາມ";
                    break;
                case "k":
                    lb_selected.Text = "ໄດ້ຄົບແຟນສອງຄົນ";
                    break;
                default:
                    lb_selected.Text = "ໃຫ້ເລື່ອກຕົວອັກສອນ a - k";
                    break;

            }
        }

        private void operator_Load(object sender, EventArgs e)
        {

        }
    }
}
