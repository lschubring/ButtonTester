using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
//var f2 = new CalcPanel();
//f2.Show();