using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inversa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            string text = textBoxReverse.Text;
            string[] reversenumbers = text.Split(',');

            Array.Reverse(reversenumbers);

            labelReverse.Text = string.Join(", ", reversenumbers);
        }
    }
}
