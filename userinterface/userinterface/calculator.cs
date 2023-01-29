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
    public partial class calculator : Form
    {
        Double resualValue = 0;
        String operatorPerformed = "";
        bool isOperatorPerformed = false;
        public calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if((txt_show.Text == "0") || (isOperatorPerformed))
            {
                txt_show.Clear();
            }
            isOperatorPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txt_show.Text.Contains(".")) {
                    txt_show.Text = txt_show.Text + button.Text;
                }
            }
            else
            {
                txt_show.Text = txt_show.Text + button.Text;
            }   
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(resualValue != 0)
            {
                btn_equal.PerformClick();
                operatorPerformed = button.Text;
                lb_show.Text = resualValue + " " + operatorPerformed;
                isOperatorPerformed = true;
            }
            else
            {
                operatorPerformed = button.Text;
                resualValue = Double.Parse(txt_show.Text);
                lb_show.Text = resualValue + " " + operatorPerformed;
                isOperatorPerformed = true;
            }
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_show.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_show.Text="0";
            resualValue=0;
        }

        private void button_equal_click(object sender, EventArgs e)
        {
            switch (operatorPerformed)
            {
                case "+":
                    txt_show.Text = (resualValue + Double.Parse(txt_show.Text)).ToString();
                    break;
                case "-":
                    txt_show.Text=(resualValue - Double.Parse(txt_show.Text)).ToString();
                    break;
                case "*":
                    txt_show.Text=(resualValue * Double.Parse(txt_show.Text)).ToString();
                    break ;
                case "/":
                    txt_show.Text=(resualValue / Double.Parse(txt_show.Text)).ToString();
                    break; ;
                default:
                    break;

            }
            resualValue = Double.Parse(txt_show.Text);
            lb_show.Text = "";
        }
    }
}
