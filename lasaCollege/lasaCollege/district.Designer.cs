namespace lasaCollege
{
    partial class district
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(district));
            this.dgv_show = new System.Windows.Forms.DataGridView();
            this.btn_delecte = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_districtName = new System.Windows.Forms.TextBox();
            this.txt_districtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addProvince = new System.Windows.Forms.Button();
            this.cbb_province = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_show
            // 
            this.dgv_show.AllowUserToAddRows = false;
            this.dgv_show.AllowUserToDeleteRows = false;
            this.dgv_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_show.BackgroundColor = System.Drawing.Color.White;
            this.dgv_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show.GridColor = System.Drawing.Color.White;
            this.dgv_show.Location = new System.Drawing.Point(12, 332);
            this.dgv_show.Name = "dgv_show";
            this.dgv_show.ReadOnly = true;
            this.dgv_show.RowHeadersWidth = 51;
            this.dgv_show.RowTemplate.Height = 24;
            this.dgv_show.Size = new System.Drawing.Size(554, 228);
            this.dgv_show.TabIndex = 14;
            this.dgv_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_show_CellClick);
            // 
            // btn_delecte
            // 
            this.btn_delecte.BackColor = System.Drawing.Color.Red;
            this.btn_delecte.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delecte.ForeColor = System.Drawing.Color.White;
            this.btn_delecte.Location = new System.Drawing.Point(258, 281);
            this.btn_delecte.Name = "btn_delecte";
            this.btn_delecte.Size = new System.Drawing.Size(117, 45);
            this.btn_delecte.TabIndex = 11;
            this.btn_delecte.Text = "ລຶບ";
            this.btn_delecte.UseVisualStyleBackColor = false;
            this.btn_delecte.Click += new System.EventHandler(this.btn_delecte_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Red;
            this.btn_edit.Location = new System.Drawing.Point(135, 281);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(117, 45);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "ແກ້ໄຂ";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Red;
            this.btn_add.Location = new System.Drawing.Point(12, 281);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(117, 45);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "ເພີ່ມ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("BoonHome", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "ຊື່ເມືອງ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("BoonHome", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "ລະຫັດເມືອງ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_districtName
            // 
            this.txt_districtName.BackColor = System.Drawing.Color.White;
            this.txt_districtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_districtName.Font = new System.Drawing.Font("Phetsarath OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_districtName.ForeColor = System.Drawing.Color.Black;
            this.txt_districtName.Location = new System.Drawing.Point(188, 154);
            this.txt_districtName.Name = "txt_districtName";
            this.txt_districtName.Size = new System.Drawing.Size(378, 40);
            this.txt_districtName.TabIndex = 8;
            this.txt_districtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_districtId
            // 
            this.txt_districtId.BackColor = System.Drawing.Color.White;
            this.txt_districtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_districtId.Font = new System.Drawing.Font("Phetsarath OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_districtId.ForeColor = System.Drawing.Color.Black;
            this.txt_districtId.Location = new System.Drawing.Point(188, 100);
            this.txt_districtId.Name = "txt_districtId";
            this.txt_districtId.Size = new System.Drawing.Size(378, 40);
            this.txt_districtId.TabIndex = 6;
            this.txt_districtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "ຟອມເມືອງ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("BoonHome", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "ແຂວງ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_addProvince
            // 
            this.btn_addProvince.BackColor = System.Drawing.Color.White;
            this.btn_addProvince.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProvince.ForeColor = System.Drawing.Color.Red;
            this.btn_addProvince.Location = new System.Drawing.Point(453, 206);
            this.btn_addProvince.Name = "btn_addProvince";
            this.btn_addProvince.Size = new System.Drawing.Size(113, 47);
            this.btn_addProvince.TabIndex = 13;
            this.btn_addProvince.Text = "ເພີ່ມແຂວງ";
            this.btn_addProvince.UseVisualStyleBackColor = false;
            this.btn_addProvince.Click += new System.EventHandler(this.btn_addProvince_Click);
            // 
            // cbb_province
            // 
            this.cbb_province.Font = new System.Drawing.Font("Phetsarath OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_province.FormattingEnabled = true;
            this.cbb_province.Location = new System.Drawing.Point(188, 206);
            this.cbb_province.Name = "cbb_province";
            this.cbb_province.Size = new System.Drawing.Size(259, 47);
            this.cbb_province.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 51);
            this.label5.TabIndex = 18;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(381, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "ກັບສູ່ໜ້າຫລັກ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // district
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(578, 568);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbb_province);
            this.Controls.Add(this.dgv_show);
            this.Controls.Add(this.btn_delecte);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_addProvince);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_districtName);
            this.Controls.Add(this.txt_districtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "district";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.district_Load);
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
        private System.Windows.Forms.TextBox txt_districtName;
        private System.Windows.Forms.TextBox txt_districtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addProvince;
        private System.Windows.Forms.ComboBox cbb_province;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}