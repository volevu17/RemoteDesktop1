namespace server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            new Form2(int.Parse(txtPort.Text)).Show();
            btnListen.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}