using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.AppCS.Lab03.Task4
{
    public partial class Validation : UserControl
    {
        public Validation()
        {
            InitializeComponent();
        }

        public string NameF
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string PinF
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public DateTime DateTimeF
        {
            get { return dateTimePicker1.Value.Date; }
            set { dateTimePicker1.Value = value; }
        }
        public string PassId
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string PassNo
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBox2.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не может содержать буквы");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox1, "Must be letter");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Validation_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime DtMin = DateTime.MinValue.Date;
            DateTime DtIn = dateTimePicker1.Value.Date;
            if ((DtMin <= DtIn) && (DtIn <= DateTime.Now))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Введена несуществующая дата!");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                e.Cancel = false;
            }
            try 
            {
                double.Parse(textBox3.Text);
                e.Cancel = false;
            }
            catch
            {
                e.Cancel = true;
                MessageBox.Show("Серия паспорта должна состоять только из цифр");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text == "")
            {
                e.Cancel = false;
            }
            try
            {
                double.Parse(textBox4.Text);
                e.Cancel = false;
            }
            catch
            {
                e.Cancel = true;
                MessageBox.Show("Номер паспорта должен состоять только из цифр");
            }

        }
        
    }
}
