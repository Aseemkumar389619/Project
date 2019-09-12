using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWin
{
    public partial class DataTypeUi : Form
    {
        public DataTypeUi()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if(itemComboBox.Text == "")
            {
                MessageBox.Show("select an item");
            }
            else
            {
                MessageBox.Show(itemComboBox.Text + " is selected");
            }
        }
    }
}
