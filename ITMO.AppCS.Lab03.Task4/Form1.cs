using System.Reflection;

namespace ITMO.AppCS.Lab03.Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int patient = 0;
        private void validation2_DoubleClick(object sender, EventArgs e)
        {
            if ((validation2.NameF != "") && (validation2.PinF != "") && (validation2.PassNo != "") && (validation2.PassId != ""))
            {
                textBox1.Text += "\n ������ � �������� " + "\n"+ ++patient + "\r\n" + "\n ���: " + validation2.NameF.ToString() +
                     "\r\n" + "\n ����� ���������� ������: " + validation2.PinF.ToString() + "\r\n" +
                     "\n ���� ��������:" + validation2.DateTimeF.ToShortDateString() + "\r\n" +
                     "\n ���������� ������:" + "\n �����" + validation2.PassId.ToString() + "\n �����" + validation2.PassNo.ToString() + "\r\n" + "\r\n";
            }
            else
            {
                MessageBox.Show("����� �� ���������!!!");
            }
        }
    }
}