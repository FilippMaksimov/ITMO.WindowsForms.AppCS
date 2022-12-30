using MyClass;
using System.Text;

namespace ITMO.AppCS.Lab02.Task6_Task9_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��� ����
        public string Author //�����
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title //�������� 
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string PublishHouse //�������
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page //���������� ������� 
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year //��� ������� 
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber //����������� ����� 
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public int PeriodUse //���� �����������
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        public bool Existence //������� 
        {
            get { return (checkBox1.Checked); }
            set { checkBox1.Checked = value; }
        }
        public bool ReturnTime //����������� � ����
        {
            get { return (checkBox2.Checked); }
            set { checkBox2.Checked = value; }
        }
        public bool SortInvNumber //���������� 
        {
            get { return (checkBox3.Checked); }
            set { checkBox3.Checked = value; }
        }
        List<Item> its = new List<Item>();

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            // ����� ����� ��� ��������� ����� ������� �� ���������
            Author = Title = PublishHouse = " ";
            Page = PeriodUse = InvNumber = 0;
            Year = 2020;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        //��� �������� 
        public string TitleM //�������� �������
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string Volume //��� �������
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public int NumberM //����� ������� 
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public int YearM //��� ������� �������
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public int InvNumberM //����������� ����� ������� 
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }
        public bool ExistenceM //������� ������� 
        {
            get { return (checkBox4.Checked); }
            set { checkBox4.Checked = value; }
        }
        public bool Subscribtion //�������� �� ������ 
        {
            get { return (checkBox5.Checked); }
            set { checkBox5.Checked = value; }
        }
        public bool SortInvNumberM //���������� ��� ������� 
        {
            get { return (checkBox6.Checked); }
            set { checkBox6.Checked = value; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magazine mag = new Magazine(Volume, NumberM, TitleM, YearM, InvNumberM, ExistenceM);
            if (Subscribtion)
                mag.IfSubs = true;
            its.Add(mag);

            Volume = TitleM = " ";
            NumberM = YearM = InvNumberM = 0;
            ExistenceM = Subscribtion = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SortInvNumberM)
                its.Sort();
            StringBuilder sb2 = new StringBuilder();
            foreach (Item item in its)
            {
                sb2.Append("\n" + item.ToString());
            }
            richTextBox2.Text = sb2.ToString();
        }
    }
}