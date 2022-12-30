using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.AppCS.Lab04.Task4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBoxF21.Text + " " + textBoxF22.Text + " " + textBoxF23.Text;
            Form1 f1 = this.Owner as Form1;
            if (f1 != null )
            {
                f1.SolData = s;
            }
            this.Close();
        }
    }
}
