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
            button1.Text = "�����ꂽ";
            button1.Left = 0;
            button1.Visible = false;
            MessageBox.Show("����ɂ���");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}