using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ITMO.AppCS.Lab04.Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            if (fm2.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            double a = Math.Round(fm2.LeftV, 2);
            double b = Math.Round(fm2.RightV, 2);
            double res;
            label2.Text = "Левая граница: " + a.ToString() + ", правая граница: " + b.ToString();
            for (double i = a; i < Math.Round(b, 1); i+=0.1)
            {
                res = Math.Round(Math.Sin(i), 2);
                richTextBox1.Text += Math.Round(i, 1).ToString() + ": " + res.ToString() + "\r\n";
            }
        }
    }
}