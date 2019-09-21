using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopUi
{
    public partial class CoffeeShop : Form
    {
        List<string> customersName = new List<string>();
        List<string> contactsNo = new List<string>();
        List<string> addresses = new List<string>();
        List<string> orders = new List<string>();
        List<int> quantitys = new List<int>();
        List<int> priceList = new List<int>();
        int prices = 0;
        public CoffeeShop()
        {

            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(quantityTextBox.Text))
                {
                    MessageBox.Show("Please Enter Quantity!");
                    return;

                }
                else
                {
                    AddCustomer(customerNameTextBox.Text, contactNoTextBox.Text, addressTextBox.Text, orderComboBox.Text, Convert.ToInt32(quantityTextBox.Text));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            CustomerInfo();
        }

        private void AddCustomerInfo()
        {
            for (int i = 0; i < contactsNo.Count(); i++)
            {
                bool n = contactsNo.Contains(contactNoTextBox.Text);
                if (n == true)
                {
                    MessageBox.Show("Already Exist This Contact No");
                }
                else
                {
                    contactsNo.Add(contactNoTextBox.Text);
                }

            }
            if (orderComboBox.Text == "Black Coffee - 120 Tk")
            {
                prices = Convert.ToInt32(quantityTextBox.Text) * 120;
            }
            if (orderComboBox.Text == "Cold Coffee - 100 Tk")
            {
                prices = Convert.ToInt32(quantityTextBox.Text) * 100;
            }
            if (orderComboBox.Text == "Hot Coffee - 90 Tk")
            {
                prices = Convert.ToInt32(quantityTextBox.Text) * 90;
            }
            if (orderComboBox.Text == "Regular Coffee - 80 Tk")
            {
                prices = Convert.ToInt32(quantityTextBox.Text) * 80;
            }


           

            for (int i = 0; i < customersName.Count(); i++)
            {
                showRichTextBox.Text += "Customer Name: " + customersName[i] + "\n" + "Conatact No: " + contactsNo[i] + "\n" + "Address: "
                    + addresses[i] + "\n" + "Order: " + order[i] + "\n" + "Quantity: " + quantity[i] + "\n" + "Price: " + priceList[i] + "\n\n";

            }
        }
            private void showButton_Click(object sender, EventArgs e)
            {
                CustomerInfo();
            }
            private void CustomerInfo()
            {
                
                int i = 0;
                while (i < customersName.Count() && customersName[i] != null)
                {
                showRichTextBox.Text = "Customer Name: " + customersName[i] + "\n" + "Conatact No: " + contactsNo[i] + "\n" + "Address: "
                        + addresses[i] + "\n" + "Order: " + orders[i] + "\n" + "Quantity: " + quantitys[i] + "\n" + "Price: "
                        + priceList[i] + "\n\n";
                    i++;
                }
                

            }
        private void AddCustomer(string name,string contact ,string address,int quantity,string order)
        {
            customersName.Add(name);
            customerNameTextBox.Text = "";
            contactsNo.Add(contact);
            contactNoTextBox.Text = "";
            addresses.Add(address);
            addressTextBox.Text = "";
            orders.Add(order);
            orderComboBox.Text = "";
            quantitys.Add(quantity);
            quantityTextBox.Text = "";
            priceList.Add(prices);
        }

    } } 

    


            
        
    
