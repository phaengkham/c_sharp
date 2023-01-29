namespace WindowsFormsApplication1
{
    partial class FormExchageRate
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
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncalular = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtmoneyExchage = new System.Windows.Forms.TextBox();
            this.lblExchageRate = new System.Windows.Forms.Label();
            this.rdbKIPisBATH = new System.Windows.Forms.RadioButton();
            this.rdbBATHisKIP = new System.Windows.Forms.RadioButton();
            this.rdbKIPisDollar = new System.Windows.Forms.RadioButton();
            this.rdbDollarisKip = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(212, 267);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(245, 35);
            this.txtRate.TabIndex = 21;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.White;
            this.lblRate.Location = new System.Drawing.Point(0, 270);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(115, 24);
            this.lblRate.TabIndex = 20;
            this.lblRate.Text = "ອັດຕາເລກປ່ຽນ:";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(352, 341);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(105, 39);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "ຍົກເລຶກ";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btncalular
            // 
            this.btncalular.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalular.ForeColor = System.Drawing.Color.Black;
            this.btncalular.Location = new System.Drawing.Point(212, 341);
            this.btncalular.Name = "btncalular";
            this.btncalular.Size = new System.Drawing.Size(110, 39);
            this.btncalular.TabIndex = 18;
            this.btncalular.Text = "ຄິດໄລ";
            this.btncalular.UseVisualStyleBackColor = true;
            this.btncalular.Click += new System.EventHandler(this.btncalular_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(212, 397);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(245, 35);
            this.txtResult.TabIndex = 17;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.Color.White;
            this.lblresult.Location = new System.Drawing.Point(12, 400);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(132, 24);
            this.lblresult.TabIndex = 16;
            this.lblresult.Text = "ເງິນທີ່ເລກປ່ຽນໄດ້:";
            // 
            // txtmoneyExchage
            // 
            this.txtmoneyExchage.Location = new System.Drawing.Point(212, 214);
            this.txtmoneyExchage.Name = "txtmoneyExchage";
            this.txtmoneyExchage.Size = new System.Drawing.Size(245, 35);
            this.txtmoneyExchage.TabIndex = 15;
            this.txtmoneyExchage.TextChanged += new System.EventHandler(this.txtmoneyExchage_TextChanged);
            // 
            // lblExchageRate
            // 
            this.lblExchageRate.AutoSize = true;
            this.lblExchageRate.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchageRate.ForeColor = System.Drawing.Color.White;
            this.lblExchageRate.Location = new System.Drawing.Point(0, 217);
            this.lblExchageRate.Name = "lblExchageRate";
            this.lblExchageRate.Size = new System.Drawing.Size(75, 24);
            this.lblExchageRate.TabIndex = 14;
            this.lblExchageRate.Text = "ປັອນເງີນ:";
            // 
            // rdbKIPisBATH
            // 
            this.rdbKIPisBATH.AutoSize = true;
            this.rdbKIPisBATH.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKIPisBATH.ForeColor = System.Drawing.Color.White;
            this.rdbKIPisBATH.Location = new System.Drawing.Point(223, 23);
            this.rdbKIPisBATH.Name = "rdbKIPisBATH";
            this.rdbKIPisBATH.Size = new System.Drawing.Size(157, 28);
            this.rdbKIPisBATH.TabIndex = 22;
            this.rdbKIPisBATH.TabStop = true;
            this.rdbKIPisBATH.Text = "ກີບ ປ່ຽນເປັນ ບາດ";
            this.rdbKIPisBATH.UseVisualStyleBackColor = true;
            this.rdbKIPisBATH.CheckedChanged += new System.EventHandler(this.rdbKIPisBATH_CheckedChanged);
            // 
            // rdbBATHisKIP
            // 
            this.rdbBATHisKIP.AutoSize = true;
            this.rdbBATHisKIP.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBATHisKIP.ForeColor = System.Drawing.Color.White;
            this.rdbBATHisKIP.Location = new System.Drawing.Point(223, 72);
            this.rdbBATHisKIP.Name = "rdbBATHisKIP";
            this.rdbBATHisKIP.Size = new System.Drawing.Size(157, 28);
            this.rdbBATHisKIP.TabIndex = 23;
            this.rdbBATHisKIP.TabStop = true;
            this.rdbBATHisKIP.Text = "ບາດ ປ່ຽນເປັນ ກີບ";
            this.rdbBATHisKIP.UseVisualStyleBackColor = true;
            this.rdbBATHisKIP.CheckedChanged += new System.EventHandler(this.rdbBATHisKIP_CheckedChanged);
            // 
            // rdbKIPisDollar
            // 
            this.rdbKIPisDollar.AutoSize = true;
            this.rdbKIPisDollar.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKIPisDollar.ForeColor = System.Drawing.Color.White;
            this.rdbKIPisDollar.Location = new System.Drawing.Point(223, 121);
            this.rdbKIPisDollar.Name = "rdbKIPisDollar";
            this.rdbKIPisDollar.Size = new System.Drawing.Size(167, 28);
            this.rdbKIPisDollar.TabIndex = 24;
            this.rdbKIPisDollar.TabStop = true;
            this.rdbKIPisDollar.Text = "ກີບ ປ່ຽນເປັນ ໂດລາ";
            this.rdbKIPisDollar.UseVisualStyleBackColor = true;
            this.rdbKIPisDollar.CheckedChanged += new System.EventHandler(this.rdbKIPisDollar_CheckedChanged);
            // 
            // rdbDollarisKip
            // 
            this.rdbDollarisKip.AutoSize = true;
            this.rdbDollarisKip.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDollarisKip.ForeColor = System.Drawing.Color.White;
            this.rdbDollarisKip.Location = new System.Drawing.Point(223, 167);
            this.rdbDollarisKip.Name = "rdbDollarisKip";
            this.rdbDollarisKip.Size = new System.Drawing.Size(167, 28);
            this.rdbDollarisKip.TabIndex = 25;
            this.rdbDollarisKip.TabStop = true;
            this.rdbDollarisKip.Text = "ໂດລາ ປ່ຽນເປັນ ກີບ";
            this.rdbDollarisKip.UseVisualStyleBackColor = true;
            this.rdbDollarisKip.CheckedChanged += new System.EventHandler(this.rdbDollarisKip_CheckedChanged);
            // 
            // FormExchageRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(520, 444);
            this.Controls.Add(this.rdbDollarisKip);
            this.Controls.Add(this.rdbKIPisDollar);
            this.Controls.Add(this.rdbBATHisKIP);
            this.Controls.Add(this.rdbKIPisBATH);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalular);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtmoneyExchage);
            this.Controls.Add(this.lblExchageRate);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormExchageRate";
            this.Text = "FormExchageRate";
            this.Load += new System.EventHandler(this.FormExchageRate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncalular;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtmoneyExchage;
        private System.Windows.Forms.Label lblExchageRate;
        private System.Windows.Forms.RadioButton rdbKIPisBATH;
        private System.Windows.Forms.RadioButton rdbBATHisKIP;
        private System.Windows.Forms.RadioButton rdbKIPisDollar;
        private System.Windows.Forms.RadioButton rdbDollarisKip;
    }
}