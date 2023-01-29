namespace userinterface
{
    partial class treeview
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ລາຍຊື່ຄູອາຈານ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ລາຍຊື່ນັກສຶກສາ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ຮູບພາບ");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("ໜ້າຫຼັກ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ສາຂາ ການເງິນ");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ສາຂາ ການຈັດການ");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ສາຂາ ໄອທີ");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("ສາຂາວິຊາ", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "ລາຍຊື່ຄູອາຈານ";
            treeNode2.Name = "Node2";
            treeNode2.Text = "ລາຍຊື່ນັກສຶກສາ";
            treeNode3.Name = "Node3";
            treeNode3.Text = "ຮູບພາບ";
            treeNode4.Name = "Node0";
            treeNode4.Text = "ໜ້າຫຼັກ";
            treeNode5.Name = "Node5";
            treeNode5.Text = "ສາຂາ ການເງິນ";
            treeNode6.Name = "Node6";
            treeNode6.Text = "ສາຂາ ການຈັດການ";
            treeNode7.Name = "Node7";
            treeNode7.Text = "ສາຂາ ໄອທີ";
            treeNode8.Name = "Node4";
            treeNode8.Text = "ສາຂາວິຊາ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(635, 381);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 405);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Phetsarath OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "treeview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "treeview";
            this.Load += new System.EventHandler(this.treeview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView treeView1;
    }
}