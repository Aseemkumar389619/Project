using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorUi : Form
    {
        public CalculatorUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            resultTextBox.Text = (Convert.ToInt32(firstNumberTextBox.Text) + Convert.ToInt32(secondTextBox.Text)).ToString();
  
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = (Convert.ToInt32(firstNumberTextBox.Text) - Convert.ToInt32(secondTextBox.Text)).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = (Convert.ToInt32(firstNumberTextBox.Text) * Convert.ToInt32(secondTextBox.Text)).ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = (Convert.ToInt32(firstNumberTextBox.Text) / Convert.ToInt32(secondTextBox.Text)).ToString();
        }
    }
}
