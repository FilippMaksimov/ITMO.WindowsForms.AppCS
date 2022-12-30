using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.AppCS.Lab04.Task5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public double LeftV
        {
            get { return (double)numericUpDown1.Value; }
            set { numericUpDown1.Value = (decimal)value; }
        }
        public double RightV
        {
            get { return (double)numericUpDown2.Value; }
            set { numericUpDown2.Value = (decimal)value; }
        }
    }
}
