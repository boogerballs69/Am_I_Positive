using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Am_I_Positive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numInput.Text);
            if (num > 0)
            {
                posnegOutput.Text = $"{num} is positive";
            }
            
            if (num < 0)
            {
                posnegOutput.Text = $"{num} is negative";
            }

            if (num == 0)
            {
                posnegOutput.Text = $"{num} is neither positive nor negative";
            }

            if (num % 7 == 0)
            {
                div7Output.Text = $"{num} is divisible by 7";
            }
            else
            {
                div7Output.Text = $"{num} is not divisible by 7";
            }
        }
    }
}
