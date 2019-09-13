using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInformationUi
{
    public partial class customerInfo : Form
    {
        int qntt;
        string add = "";
        string nm = "";
        string cntct = "";
        string ordr = "";
        int prc;


        public customerInfo()
        {
            InitializeComponent();
        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string name = customerNameTextBox.Text;
            nm = name;


        }

        private void contactNoTextBox_TextChanged(object sender, EventArgs e)
        {
            string contact = contactNoTextBox.Text;

            cntct = contact;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

            string address = addressTextBox.Text;
            add = address;


        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(quantityTextBox.Text);
            qntt = quantity;


        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {  int price = 0;
            if (orderComboBox.Text == "None")
            {
                ordr = "None";
            }

            else if (orderComboBox.Text == "Black")
            {
                ordr = "Black";
                price = 120 * qntt;
                prc = price;

            }
            else if (orderComboBox.Text == "Cold")
            {
                ordr = "Cold";
                price = 100 * qntt;
                prc = price;

            }
            else if (orderComboBox.Text == "Hot")
            {
                ordr = "Hot";
                price = 90 * qntt;
                prc = price;

            }
            else if (orderComboBox.Text == "Regular")
            {
                ordr = "Regular";
                price = 80 * qntt;
                prc = price;

            }

        } 

        

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show ("Customer Name : "+nm +"\n"+"Contact No : "+ cntct +"\n"+ "Address : " +
                add + "\n" + "Order : " +ordr +"\n"+"Quantity : "+ qntt.ToString() 
                + "\n"+"Price : "+prc.ToString());
        }

        private void showRichTextBox_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(saveButton.Text);
        }
    }
}

