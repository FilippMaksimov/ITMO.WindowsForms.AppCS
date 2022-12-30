using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.AppCS.Lab06.Task1
{
    public partial class DialogEditForm : Form
    {
        public DialogEditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = this.Owner as Form1;
            try
            {
                frm1.a = double.Parse(textBox21.Text);
                frm1.b = double.Parse(textBox22.Text);
                frm1.DataA = textBox21.Text;
                frm1.DataB = textBox22.Text;
            }
            catch (Exception er)
            {
                MessageBox.Show("При выполнении ввода исходных данных влзникла ошибка: \n" + er.Message,
                        "Ошибка" + MessageBoxButtons.OK + MessageBoxIcon.Error);
                return;
            }
            this.Close();
            frm1.Refresh();
        }
    }
}
