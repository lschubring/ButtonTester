using System;
using System.Windows.Forms;

namespace ButtonTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var f2 = new Form1();
            f2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dies ist der Test eines Buttons!");

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var f2 = new Form1();
            f2.Show();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dies ist der Test eines Buttons!");
        }
    }
}
//var f2 = new CalcPanel();
//f2.Show();