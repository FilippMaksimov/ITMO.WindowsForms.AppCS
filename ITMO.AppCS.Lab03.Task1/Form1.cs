namespace ITMO.AppCS.Lab03.Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControlTimer1.TimeEnabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControlTimer1.TimeEnabled = true;
        }
    }
}