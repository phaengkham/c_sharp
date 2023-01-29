namespace lasaCollege
{
    partial class provinceform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(provinceform));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_provinceId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_provincename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delecte = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lb_back = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Lao_Derm2_Semi-Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "ຟອມແຂວງ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_provinceId
            // 
            this.txt_provinceId.BackColor = System.Drawing.Color.White;
            this.txt_provinceId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_provinceId.Font = new System.Drawing.Font("Phetsarath OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_provinceId.ForeColor = System.Drawing.Color.Black;
            this.txt_provinceId.Location = new System.Drawing.Point(188, 98);
            this.txt_provinceId.Name = "txt_provinceId";
            this.txt_provinceId.Size = new System.Drawing.Size(284, 40);
            this.txt_provinceId.TabIndex = 0;
            this.txt_provinceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Lao_Derm2_Semi-Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "ລະຫັດແຂວງ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_provincename
            // 
            this.txt_provincename.BackColor = System.Drawing.Color.White;
            this.txt_provincename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_provincename.Font = new System.Drawing.Font("Phetsarath OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_provincename.ForeColor = System.Drawing.Color.Black;
            this.txt_provincename.Location = new System.Drawing.Point(188, 152);
            this.txt_provincename.Name = "txt_provincename";
            this.txt_provincename.Size = new System.Drawing.Size(284, 40);
            this.txt_provincename.TabIndex = 1;
            this.txt_provincename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Lao_Derm2_Semi-Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "ຊື່ແຂວງ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add.Font = new System.Drawing.Font("Lao_Derm2_Semi-Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Red;
            this.btn_add.Location = new System.Drawing.Point(14, 245);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(117, 45);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "ບັນທຶກ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_edit.Font = new System.Drawing.Font("Lao_Derm2_Semi-Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Red;
            this.btn_edit.Location = new System.Drawing.Point(137, 245);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(117, 45);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "ແກ້ໄຂ";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delecte
            // 
            this.btn_delecte.BackColor = System.Drawing.Color.Red;
            this.btn_delecte.Font = new System.Drawing.Font("Lao_Derm2_Semi-Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delecte.ForeColor = System.Drawing.Color.White;
            this.btn_delecte.Location = new System.Drawing.Point(260, 245);
            this.btn_delecte.Name = "btn_delecte";
            this.btn_delecte.Size = new System.Drawing.Size(117, 45);
            this.btn_delecte.TabIndex = 4;
            this.btn_delecte.Text = "ລຶບ";
            this.btn_delecte.UseVisualStyleBackColor = false;
            this.btn_delecte.Click += new System.EventHandler(this.btn_delecte_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(12, 296);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(554, 228);
            this.dgv.TabIndex = 5;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // lb_back
            // 
            this.lb_back.Image = ((System.Drawing.Image)(resources.GetObject("lb_back.Image")));
            this.lb_back.Location = new System.Drawing.Point(12, 9);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(35, 51);
            this.lb_back.TabIndex = 18;
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Lime;
            this.btn_back.Location = new System.Drawing.Point(380, 245);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(186, 45);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "ກັບສູ່ໜ້າຫລັກ";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // provinceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(578, 536);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_delecte);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_provincename);
            this.Controls.Add(this.txt_provinceId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "provinceform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.provinceform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_provinceId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_provincename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delecte;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lb_back;
        private System.Windows.Forms.Button btn_back;
    }
}

