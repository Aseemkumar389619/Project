using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Home : Form
    {
        string[] name = new string[10];
        string[] contact =new string [10];
        string[] address = new string[10];
        string[] order = new string[10];
        int[] quantity = new int[10];
        int index = 0;


        public Home()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            name[index] = nameTextBox.Text;
            nameTextBox.Text = "";
            contact[index] = contactTextBox.Text;
            contactTextBox.Text = "";
            address[index] = addressTextBox.Text;
            addressTextBox.Text = "";
            quantity[index] = Int32.Parse( quantityTextBox.Text);
            quantityTextBox.Text = "";
            order[index++] = orderComboBox.Text;
            orderComboBox.Text = "";
           



        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string allIinfo = "";

            int i = 0;
            while(i < name.Length && name[i] != null)
            {
                allIinfo +="Name     : " +name[i] + "\n"+"Contact  : "+ contact[i]+"\n"+"Address  : "+address[i]+"\n"+
                    "Quntity    : "+quantity[i]+"\n"+"Order      : "+order[i]+"\n\n";
                i++;
            }

            showRichTextBox.Text = allIinfo;
        }

        }
    }
}

