namespace lasaCollege
{
    partial class occupation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(occupation));
            this.dgv_show = new System.Windows.Forms.DataGridView();
            this.btn_delecte = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_occupation = new System.Windows.Forms.TextBox();
            this.txt_occupationId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_back = new System.Windows.Forms.Label();
            this.btn_backFormMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_show
            // 
            this.dgv_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_show.BackgroundColor = System.Drawing.Color.White;
            this.dgv_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show.GridColor = System.Drawing.Color.White;
            this.dgv_show.Location = new System.Drawing.Point(12, 298);
            this.dgv_show.Name = "dgv_show";
            this.dgv_show.RowHeadersWidth = 51;
            this.dgv_show.RowTemplate.Height = 24;
            this.dgv_show.Size = new System.Drawing.Size(554, 228);
            this.dgv_show.TabIndex = 23;
            this.dgv_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_show_CellClick);
            // 
            // btn_delecte
            // 
            this.btn_delecte.BackColor = System.Drawing.Color.Red;
            this.btn_delecte.Font = new System.Drawing.Font("Lao_Modern2", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delecte.ForeColor = System.Drawing.Color.White;
            this.btn_delecte.Location = new System.Drawing.Point(258, 247);
            this.btn_delecte.Name = "btn_delecte";
            this.btn_delecte.Size = new System.Drawing.Size(117, 45);
            this.btn_delecte.TabIndex = 20;
            this.btn_delecte.Text = "ລຶບ";
            this.btn_delecte.UseVisualStyleBackColor = false;
            this.btn_delecte.Click += new System.EventHandler(this.btn_delecte_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.Font = new System.Drawing.Font("Lao_Modern2", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Red;
            this.btn_edit.Location = new System.Drawing.Point(135, 247);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(117, 45);
            this.btn_edit.TabIndex = 21;
            this.btn_edit.Text = "ແກ້ໄຂ";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Lao_Modern2", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Red;
            this.btn_add.Location = new System.Drawing.Point(12, 247);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(117, 45);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "ເພີ່ມ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Lao_Modern2", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 40);
            this.label3.TabIndex = 18;
            this.label3.Text = "ອາຊີບ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Lao_Modern2", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "ລະຫັດອາຊີບ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_occupation
            // 
            this.txt_occupation.BackColor = System.Drawing.Color.White;
            this.txt_occupation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_occupation.Font = new System.Drawing.Font("Phetsarath OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_occupation.ForeColor = System.Drawing.Color.Lime;
            this.txt_occupation.Location = new System.Drawing.Point(188, 154);
            this.txt_occupation.Name = "txt_occupation";
            this.txt_occupation.Size = new System.Drawing.Size(378, 40);
            this.txt_occupation.TabIndex = 17;
            this.txt_occupation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_occupationId
            // 
            this.txt_occupationId.BackColor = System.Drawing.Color.White;
            this.txt_occupationId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_occupationId.Font = new System.Drawing.Font("Phetsarath OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_occupationId.ForeColor = System.Drawing.Color.Lime;
            this.txt_occupationId.Location = new System.Drawing.Point(188, 100);
            this.txt_occupationId.Name = "txt_occupationId";
            this.txt_occupationId.Size = new System.Drawing.Size(378, 40);
            this.txt_occupationId.TabIndex = 15;
            this.txt_occupationId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Lao_Modern2", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 51);
            this.label1.TabIndex = 16;
            this.label1.Text = "ຟອມສະແດງອາຊີບ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_back
            // 
            this.lb_back.Image = ((System.Drawing.Image)(resources.GetObject("lb_back.Image")));
            this.lb_back.Location = new System.Drawing.Point(11, 11);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(35, 51);
            this.lb_back.TabIndex = 25;
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            // 
            // btn_backFormMain
            // 
            this.btn_backFormMain.Font = new System.Drawing.Font("Lao_Modern2", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backFormMain.ForeColor = System.Drawing.Color.Lime;
            this.btn_backFormMain.Location = new System.Drawing.Point(380, 247);
            this.btn_backFormMain.Name = "btn_backFormMain";
            this.btn_backFormMain.Size = new System.Drawing.Size(186, 45);
            this.btn_backFormMain.TabIndex = 24;
            this.btn_backFormMain.Text = "ກັບສູ່ໜ້າຫລັກ";
            this.btn_backFormMain.UseVisualStyleBackColor = true;
            // 
            // occupation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(578, 536);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.btn_backFormMain);
            this.Controls.Add(this.dgv_show);
            this.Controls.Add(this.btn_delecte);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_occupation);
            this.Controls.Add(this.txt_occupationId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "occupation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.occupation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_show;
        private System.Windows.Forms.Button btn_delecte;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_occupation;
        private System.Windows.Forms.TextBox txt_occupationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_back;
        private System.Windows.Forms.Button btn_backFormMain;
    }
}