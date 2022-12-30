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
        //ДЛЯ КНИГ
        public string Author //Автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title //Название 
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string PublishHouse //Издание
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page //Количество страниц 
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year //Год издания 
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber //Инвентарный номер 
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public int PeriodUse //Срок пользования
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        public bool Existence //Наличие 
        {
            get { return (checkBox1.Checked); }
            set { checkBox1.Checked = value; }
        }
        public bool ReturnTime //Возвращение в срок
        {
            get { return (checkBox2.Checked); }
            set { checkBox2.Checked = value; }
        }
        public bool SortInvNumber //Сортировка 
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
            // После клика эти параметры будут очищены по умолчанию
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

        //ДЛЯ ЖУРНАЛОВ 
        public string TitleM //Название журнала
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string Volume //Том журнала
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public int NumberM //Номер журнала 
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public int YearM //Год издания журнала
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public int InvNumberM //Инвентарный номер журнала 
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }
        public bool ExistenceM //Наличие журнала 
        {
            get { return (checkBox4.Checked); }
            set { checkBox4.Checked = value; }
        }
        public bool Subscribtion //Подписка на журнал 
        {
            get { return (checkBox5.Checked); }
            set { checkBox5.Checked = value; }
        }
        public bool SortInvNumberM //Сортировка для журнала 
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