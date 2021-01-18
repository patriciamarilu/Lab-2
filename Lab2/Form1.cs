//GRADIN ID: R5665. Feb 2, 2020. This program createa a simple GUI application with numeric input, calculations, and output formatting.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1; // meal price 
            double tip1; // 15% tip
            double tip2; // 18% tip
            double tip3; // 20% tip
            const double TIPRATE15 = .15; //named constants
            const double TIPRATE18 = .18;
            const double TIPRATE20 = .20;
            num1 = double.Parse(textBox1.Text); // meal price input
            tip1 = num1 * TIPRATE15; // output of the 15% tip
            tip2 = num1 * TIPRATE18; // output of the 18% tip
            tip3 = num1 * TIPRATE20; // output of the 20% tip
            label5.Text = $"${tip1:F2}"; // total tip amounts in currency
            label6.Text = $"${tip2:F2}";
            label7.Text = $"${tip3:F2}";

        }
    }
}
