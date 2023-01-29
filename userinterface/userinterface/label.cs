namespace userinterface
{
    public partial class label : Form
    {
        public label()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            label2.Text = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label form = new label();
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picturebox form2 = new picturebox();
            form2.ShowDialog();
        }
    }
}