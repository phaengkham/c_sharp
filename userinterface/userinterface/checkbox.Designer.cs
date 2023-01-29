namespace userinterface
{
    partial class checkbox
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
            this.chb_c = new System.Windows.Forms.CheckBox();
            this.chb_csharp = new System.Windows.Forms.CheckBox();
            this.chb_java = new System.Windows.Forms.CheckBox();
            this.chb_html = new System.Windows.Forms.CheckBox();
            this.chb_sql = new System.Windows.Forms.CheckBox();
            this.chb_css = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chb_c
            // 
            this.chb_c.AutoSize = true;
            this.chb_c.Location = new System.Drawing.Point(70, 18);
            this.chb_c.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chb_c.Name = "chb_c";
            this.chb_c.Size = new System.Drawing.Size(178, 47);
            this.chb_c.TabIndex = 0;
            this.chb_c.Text = "ຮຽນພາສາ C";
            this.chb_c.UseVisualStyleBackColor = true;
            // 
            // chb_csharp
            // 
            this.chb_csharp.AutoSize = true;
            this.chb_csharp.Location = new System.Drawing.Point(70, 75);
            this.chb_csharp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chb_csharp.Name = "chb_csharp";
            this.chb_csharp.Size = new System.Drawing.Size(200, 47);
            this.chb_csharp.TabIndex = 0;
            this.chb_csharp.Text = "ຮຽນພາສາ C#";
            this.chb_csharp.UseVisualStyleBackColor = true;
            // 
            // chb_java
            // 
            this.chb_java.AutoSize = true;
            this.chb_java.Location = new System.Drawing.Point(70, 133);
            this.chb_java.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chb_java.Name = "chb_java";
            this.chb_java.Size = new System.Drawing.Size(220, 47);
            this.chb_java.TabIndex = 0;
            this.chb_java.Text = "ຮຽນພາສາ Java";
            this.chb_java.UseVisualStyleBackColor = true;
            // 
            // chb_html
            // 
            this.chb_html.AutoSize = true;
            this.chb_html.Location = new System.Drawing.Point(70, 192);
            this.chb_html.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chb_html.Name = "chb_html";
            this.chb_html.Size = new System.Drawing.Size(238, 47);
            this.chb_html.TabIndex = 0;
            this.chb_html.Text = "ຮຽນພາສາ HTML";
            this.chb_html.UseVisualStyleBackColor = true;
            // 
            // chb_sql
            // 
            this.chb_sql.AutoSize = true;
            this.chb_sql.Location = new System.Drawing.Point(70, 307);
            this.chb_sql.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chb_sql.Name = "chb_sql";
            this.chb_sql.Size = new System.Drawing.Size(314, 47);
            this.chb_sql.TabIndex = 0;
            this.chb_sql.Text = "ຮຽນພາສາ SQL Server";
            this.chb_sql.UseVisualStyleBackColor = true;
            // 
            // chb_css
            // 
            this.chb_css.AutoSize = true;
            this.chb_css.Location = new System.Drawing.Point(70, 249);
            this.chb_css.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chb_css.Name = "chb_css";
            this.chb_css.Size = new System.Drawing.Size(218, 47);
            this.chb_css.TabIndex = 0;
            this.chb_css.Text = "ຮຽນພາສາ CSS";
            this.chb_css.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(70, 387);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "ສະແດງພາສາທີ່ເລືອກຮຽນ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(-3, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 194);
            this.label1.TabIndex = 2;
            this.label1.Text = "ສະແດງວິຊາທີ່ເລືອກຮຽນ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chb_css);
            this.Controls.Add(this.chb_sql);
            this.Controls.Add(this.chb_html);
            this.Controls.Add(this.chb_java);
            this.Controls.Add(this.chb_csharp);
            this.Controls.Add(this.chb_c);
            this.Font = new System.Drawing.Font("Phetsarath OT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "checkbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chb_c;
        private CheckBox chb_csharp;
        private CheckBox chb_java;
        private CheckBox chb_html;
        private CheckBox chb_sql;
        private CheckBox chb_css;
        private Button button1;
        private Label label1;
    }
}