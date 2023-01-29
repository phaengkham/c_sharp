namespace babyShop
{
    partial class showForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showForm));
            this.lb_exit = new System.Windows.Forms.Label();
            this.lb_back = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_exit
            // 
            this.lb_exit.Image = ((System.Drawing.Image)(resources.GetObject("lb_exit.Image")));
            this.lb_exit.Location = new System.Drawing.Point(455, 9);
            this.lb_exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(21, 34);
            this.lb_exit.TabIndex = 11;
            this.lb_exit.Click += new System.EventHandler(this.lb_exit_Click);
            // 
            // lb_back
            // 
            this.lb_back.Image = ((System.Drawing.Image)(resources.GetObject("lb_back.Image")));
            this.lb_back.Location = new System.Drawing.Point(12, 10);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(44, 33);
            this.lb_back.TabIndex = 12;
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // showForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 743);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.lb_exit);
            this.Font = new System.Drawing.Font("LAO THAT PHON", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "showForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_exit;
        private System.Windows.Forms.Label lb_back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}