﻿using System;
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
    public partial class mothcalendar : Form
    {
        public mothcalendar()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startdate = "";
            startdate = monthCalendar1.SelectionStart.ToLongDateString();
            string enddate = "";
            enddate = monthCalendar1.SelectionEnd.ToLongDateString();
            richTextBox1.Text = "ວັນເລີ່ມກອງປະຊຸ່ມ"+ startdate + Environment.NewLine + "ວັນປິດກອງປະຊຸ່ມ:" + enddate;
        }
    }
}
