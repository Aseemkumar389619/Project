using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personalIformation
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Name : "+firstNameTextBox.Text+"\n"+"Last Name : "+lastNameTextBox.Text+"\n"+"Father Name : "+fatherNameTextBox.Text+"\n"+
                "Mother NAme : "+motherNameTextBox.Text+"\n"+"Address : "+addressTextBox.Text);
        }

        private void showAllInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name : " + firstNameTextBox.Text + lastNameTextBox.Text + "\n" + "Father Name : " + fatherNameTextBox.Text + "\n" +
                "Mother NAme : " + motherNameTextBox.Text + "\n" + "Address : " + addressTextBox.Text);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name : "+ firstNameTextBox.Text + lastNameTextBox.Text);
        }

        private void parentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Father Name : "+ fatherNameTextBox.Text + "\n" +
                "Mother NAme : " + motherNameTextBox.Text);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address : "+ addressTextBox.Text);
        }
    }
}
