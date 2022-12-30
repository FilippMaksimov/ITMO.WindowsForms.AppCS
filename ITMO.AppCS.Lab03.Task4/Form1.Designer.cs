namespace ITMO.AppCS.Lab03.Task4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.validation2 = new ITMO.AppCS.Lab03.Task4.Validation();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(372, 413);
            this.textBox1.TabIndex = 0;
            // 
            // validation2
            // 
            this.validation2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.validation2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.validation2.DateTimeF = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            this.validation2.Location = new System.Drawing.Point(12, 63);
            this.validation2.Name = "validation2";
            this.validation2.NameF = "";
            this.validation2.PassId = "";
            this.validation2.PassNo = "";
            this.validation2.PinF = "";
            this.validation2.Size = new System.Drawing.Size(387, 326);
            this.validation2.TabIndex = 1;
            this.validation2.DoubleClick += new System.EventHandler(this.validation2_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validation2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Validation validation1;
        private Validation validation2;
    }
}