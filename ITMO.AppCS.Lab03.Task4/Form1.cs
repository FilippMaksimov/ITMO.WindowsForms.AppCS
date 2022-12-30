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
                textBox1.Text += "\n Данные о пациенте " + "\n"+ ++patient + "\r\n" + "\n Имя: " + validation2.NameF.ToString() +
                     "\r\n" + "\n Номер страхового полиса: " + validation2.PinF.ToString() + "\r\n" +
                     "\n Дата Рождения:" + validation2.DateTimeF.ToShortDateString() + "\r\n" +
                     "\n Паспортные данные:" + "\n серия" + validation2.PassId.ToString() + "\n серия" + validation2.PassNo.ToString() + "\r\n" + "\r\n";
            }
            else
            {
                MessageBox.Show("Форма не заполнена!!!");
            }
        }
    }
}