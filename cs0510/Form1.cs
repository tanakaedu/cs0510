namespace cs0510
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mybutton.Text = "押された";
            mybutton.Left = 0;
            mybutton.Visible = false;
            MessageBox.Show("こんにちは");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}