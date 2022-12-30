namespace ITMO.AppCS.Lab01.Task5.Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            txtDta.Text = lblData.Text;
        }
    }
}