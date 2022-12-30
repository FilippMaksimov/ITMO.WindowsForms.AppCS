namespace ITMO.AppCS.Lab04.Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string SolData
        {
            get { return textBoxF1.Text;}
            set { textBoxF1.Text = value;}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show(this);
        }
    }
}