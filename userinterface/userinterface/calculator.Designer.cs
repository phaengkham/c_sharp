namespace userinterface
{
    partial class calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.txt_show = new System.Windows.Forms.TextBox();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.lb_show = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_show
            // 
            this.txt_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_show.Location = new System.Drawing.Point(11, 44);
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(419, 45);
            this.txt_show.TabIndex = 0;
            this.txt_show.Text = "0";
            this.txt_show.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(11, 93);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(79, 70);
            this.btn_one.TabIndex = 1;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.button_click);
            // 
            // btn_two
            // 
            this.btn_two.Location = new System.Drawing.Point(96, 93);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(79, 70);
            this.btn_two.TabIndex = 1;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.button_click);
            // 
            // btn_three
            // 
            this.btn_three.Location = new System.Drawing.Point(181, 93);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(79, 70);
            this.btn_three.TabIndex = 1;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.button_click);
            // 
            // btn_four
            // 
            this.btn_four.Location = new System.Drawing.Point(11, 169);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(79, 70);
            this.btn_four.TabIndex = 1;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.button_click);
            // 
            // btn_five
            // 
            this.btn_five.Location = new System.Drawing.Point(96, 169);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(79, 70);
            this.btn_five.TabIndex = 1;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.button_click);
            // 
            // btn_six
            // 
            this.btn_six.Location = new System.Drawing.Point(181, 169);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(79, 70);
            this.btn_six.TabIndex = 1;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.button_click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(266, 93);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(79, 70);
            this.btn_divide.TabIndex = 1;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(266, 169);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(79, 70);
            this.btn_multiply.TabIndex = 1;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(351, 93);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(79, 70);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "CE";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(351, 169);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(79, 70);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.Location = new System.Drawing.Point(11, 245);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(79, 70);
            this.btn_seven.TabIndex = 1;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.button_click);
            // 
            // btn_eight
            // 
            this.btn_eight.Location = new System.Drawing.Point(96, 245);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(79, 70);
            this.btn_eight.TabIndex = 1;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.button_click);
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(11, 321);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(164, 70);
            this.btn_zero.TabIndex = 1;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.button_click);
            // 
            // btn_nine
            // 
            this.btn_nine.Location = new System.Drawing.Point(181, 245);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(79, 70);
            this.btn_nine.TabIndex = 1;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.button_click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(266, 245);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(79, 70);
            this.btn_minus.TabIndex = 1;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_dot
            // 
            this.btn_dot.Location = new System.Drawing.Point(181, 321);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(79, 70);
            this.btn_dot.TabIndex = 1;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.button_click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(266, 321);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(79, 70);
            this.btn_plus.TabIndex = 1;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(351, 245);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(79, 146);
            this.btn_equal.TabIndex = 1;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.button_equal_click);
            // 
            // lb_show
            // 
            this.lb_show.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_show.Font = new System.Drawing.Font("Noto Sans Lao", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_show.ForeColor = System.Drawing.Color.Black;
            this.lb_show.Location = new System.Drawing.Point(11, 12);
            this.lb_show.Name = "lb_show";
            this.lb_show.Size = new System.Drawing.Size(164, 29);
            this.lb_show.TabIndex = 2;
            this.lb_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Noto Sans Lao", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Noto Sans Lao", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 29);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(442, 400);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_show);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_seven);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.txt_show);
            this.Font = new System.Drawing.Font("Noto Sans Lao", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_show;
        private Button btn_one;
        private Button btn_two;
        private Button btn_three;
        private Button btn_four;
        private Button btn_five;
        private Button btn_six;
        private Button btn_divide;
        private Button btn_multiply;
        private Button btn_cancel;
        private Button btn_clear;
        private Button btn_seven;
        private Button btn_eight;
        private Button btn_zero;
        private Button btn_nine;
        private Button btn_minus;
        private Button btn_dot;
        private Button btn_plus;
        private Button btn_equal;
        private Label lb_show;
        private DateTimePicker dateTimePicker1;
    }
}