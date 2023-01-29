namespace userinterface
{
    partial class richtexbox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.chb_bold = new System.Windows.Forms.CheckBox();
            this.chb_italic = new System.Windows.Forms.CheckBox();
            this.chb_underlin = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_pick = new System.Windows.Forms.RadioButton();
            this.rdb_white = new System.Windows.Forms.RadioButton();
            this.rdb_red = new System.Windows.Forms.RadioButton();
            this.rt_message = new System.Windows.Forms.RichTextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.lb_show = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ຊື່ ແລະ ນາມສະກຸນ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "ສະແດງຄໍາຄິດເຫັນ:";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(248, 21);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(410, 45);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chb_bold
            // 
            this.chb_bold.AutoSize = true;
            this.chb_bold.ForeColor = System.Drawing.Color.White;
            this.chb_bold.Location = new System.Drawing.Point(21, 51);
            this.chb_bold.Name = "chb_bold";
            this.chb_bold.Size = new System.Drawing.Size(123, 47);
            this.chb_bold.TabIndex = 2;
            this.chb_bold.Text = "BOLD";
            this.chb_bold.UseVisualStyleBackColor = true;
            // 
            // chb_italic
            // 
            this.chb_italic.AutoSize = true;
            this.chb_italic.Location = new System.Drawing.Point(21, 104);
            this.chb_italic.Name = "chb_italic";
            this.chb_italic.Size = new System.Drawing.Size(134, 47);
            this.chb_italic.TabIndex = 2;
            this.chb_italic.Text = "ITALIC";
            this.chb_italic.UseVisualStyleBackColor = true;
            // 
            // chb_underlin
            // 
            this.chb_underlin.AutoSize = true;
            this.chb_underlin.Location = new System.Drawing.Point(21, 157);
            this.chb_underlin.Name = "chb_underlin";
            this.chb_underlin.Size = new System.Drawing.Size(216, 47);
            this.chb_underlin.TabIndex = 2;
            this.chb_underlin.Text = "UNDERLINE";
            this.chb_underlin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Red;
            this.groupBox1.Controls.Add(this.chb_bold);
            this.groupBox1.Controls.Add(this.chb_underlin);
            this.groupBox1.Controls.Add(this.chb_italic);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 229);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ຕົວອັກສອນ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Red;
            this.groupBox2.Controls.Add(this.rdb_pick);
            this.groupBox2.Controls.Add(this.rdb_white);
            this.groupBox2.Controls.Add(this.rdb_red);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(338, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 229);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ສີຕົວອັກສອນ";
            // 
            // rdb_pick
            // 
            this.rdb_pick.AutoSize = true;
            this.rdb_pick.Font = new System.Drawing.Font("Phetsarath OT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_pick.Location = new System.Drawing.Point(20, 156);
            this.rdb_pick.Name = "rdb_pick";
            this.rdb_pick.Size = new System.Drawing.Size(97, 47);
            this.rdb_pick.TabIndex = 4;
            this.rdb_pick.TabStop = true;
            this.rdb_pick.Text = "ສີບົວ";
            this.rdb_pick.UseVisualStyleBackColor = true;
            // 
            // rdb_white
            // 
            this.rdb_white.AutoSize = true;
            this.rdb_white.Font = new System.Drawing.Font("Phetsarath OT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_white.Location = new System.Drawing.Point(20, 103);
            this.rdb_white.Name = "rdb_white";
            this.rdb_white.Size = new System.Drawing.Size(108, 47);
            this.rdb_white.TabIndex = 4;
            this.rdb_white.TabStop = true;
            this.rdb_white.Text = "ສີຂາວ";
            this.rdb_white.UseVisualStyleBackColor = true;
            // 
            // rdb_red
            // 
            this.rdb_red.AutoSize = true;
            this.rdb_red.Font = new System.Drawing.Font("Phetsarath OT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_red.Location = new System.Drawing.Point(20, 50);
            this.rdb_red.Name = "rdb_red";
            this.rdb_red.Size = new System.Drawing.Size(107, 47);
            this.rdb_red.TabIndex = 4;
            this.rdb_red.TabStop = true;
            this.rdb_red.Text = "ສີແດງ";
            this.rdb_red.UseVisualStyleBackColor = true;
            // 
            // rt_message
            // 
            this.rt_message.BackColor = System.Drawing.Color.White;
            this.rt_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rt_message.ForeColor = System.Drawing.Color.Black;
            this.rt_message.Location = new System.Drawing.Point(235, 314);
            this.rt_message.Name = "rt_message";
            this.rt_message.Size = new System.Drawing.Size(423, 144);
            this.rt_message.TabIndex = 4;
            this.rt_message.Text = "";
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.Cyan;
            this.btn_show.ForeColor = System.Drawing.Color.Black;
            this.btn_show.Location = new System.Drawing.Point(12, 360);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(217, 98);
            this.btn_show.TabIndex = 5;
            this.btn_show.Text = "ສະແດງຂໍ້ຄວາມ";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // lb_show
            // 
            this.lb_show.BackColor = System.Drawing.Color.Blue;
            this.lb_show.ForeColor = System.Drawing.Color.Black;
            this.lb_show.Location = new System.Drawing.Point(12, 473);
            this.lb_show.Name = "lb_show";
            this.lb_show.Size = new System.Drawing.Size(648, 179);
            this.lb_show.TabIndex = 6;
            // 
            // richtexbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(672, 661);
            this.Controls.Add(this.lb_show);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.rt_message);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Phetsarath OT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "richtexbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "richtexbox";
            this.Load += new System.EventHandler(this.richtexbox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_name;
        private CheckBox chb_bold;
        private CheckBox chb_italic;
        private CheckBox chb_underlin;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rdb_pick;
        private RadioButton rdb_white;
        private RadioButton rdb_red;
        private RichTextBox rt_message;
        private Button btn_show;
        private Label lb_show;
    }
}