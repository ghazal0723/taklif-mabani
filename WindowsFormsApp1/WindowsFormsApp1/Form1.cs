using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f1 = 0, f2 = 1, f3 = 0, i = 1;
            int num =int.Parse(textBox1.Text);
            while (i < num)
            {
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;
                i++;
            }
            MessageBox.Show(f3.ToString());
            
        }
    }
}
