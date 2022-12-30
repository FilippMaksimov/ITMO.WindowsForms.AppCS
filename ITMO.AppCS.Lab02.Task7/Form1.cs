namespace ITMO.AppCS.Lab02.Task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(26, 96);
                lbl.Size = new System.Drawing.Size(40, 23);
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(120, 92);
                txt.Size = new System.Drawing.Size(215, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
            }
            else
            {
                int lcv;
                lcv = groupBox1.Controls.Count; //������������� ���������� ��������� 
                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv-1);
                    lcv -= 1;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("���� PIN �� ����� ��������� �����");
            //}
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                errorProvider1.SetError(textBox1, "Musr be letter");
            }
            if (!char.IsDigit(e.KeyChar))
                errorProvider1.Clear();
            
            //if (char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //    //MessageBox.Show("���� Name �� ����� ��������� �����");
            //    errorProvider1.SetError(textBox1, "Must be letter");

            //}
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
                    e.Cancel=true;
                    MessageBox.Show("���� PIN �� ����� ��������� �����");
                }
            }
        }
    }
}