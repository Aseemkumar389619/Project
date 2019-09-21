using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class StudentUi : Form
    {
        List<string> ids = new List<string> { };
        List<string> names = new List<string> { };
        List<string> mobiles = new List<string> { };
        List<int> ages = new List<int> { };
        List<string> addresses = new List<string> { };
        List<double> cgpa = new List<double> { };

        

        public StudentUi()
        {
            InitializeComponent();
        }



        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            idTextBox.MaxLength = 4;

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.MaxLength = 30;
        }

        private void mobileTextBox_TextChanged(object sender, EventArgs e)
        {
            mobileTextBox.MaxLength = 11;
        }
        private void gpaTextBox_TextChanged(object sender, EventArgs e)
        {
            gpaTextBox.MaxLength = 4;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "" || nameTextBox.Text == "" || mobileTextBox.Text == "")
            {
                MessageBox.Show("enter your id name and contact number first.");
               
            }
            else
            {
                if (idTextBox.Text.Length < 4)
                {
                    MessageBox.Show("minimum 4 digit");
                }
                else
                {
                    if (nameTextBox.Text.Length > 30)
                    {
                        MessageBox.Show("maximum 30 digits");
                    }
                    else
                    {
                        if(mobileTextBox.Text.Length <11)
                        {
                            MessageBox.Show("enter your 11 digit phone number");
                        }
                        else
                        {
                            if(ageTextBox.Text=="")
                            {
                                MessageBox.Show("enter age");
                                
                            }
                            else
                            {
                                int i;
                                if (!int.TryParse(ageTextBox.Text, out i))
                                {
                                    MessageBox.Show("This is a number only field");
                                    return;
                                }
                            }
                            if(gpaTextBox.Text=="")
                            {
                                MessageBox.Show("enter your gpa");
                            }
                            else
                            {
                                int q;
                                if (!int.TryParse(gpaTextBox.Text, out q))
                                {
                                    MessageBox.Show("This is a number only field");
                                    return;
                                }
                                else
                                {
                                    foreach(string id in ids)
                                    {
                                        if (id == idTextBox.Text)
                                        {
                                            MessageBox.Show("dublicate id");
                                            return;
                                        }
                                    }
                                    foreach(string mobile in mobiles)
                                    {
                                        if(mobile==mobileTextBox.Text)
                                        {
                                            MessageBox.Show("dublicate contact number");
                                            return;
                                        }
                                    }
                                    AddStudent(idTextBox.Text,nameTextBox.Text,mobileTextBox.Text,Convert.ToInt32(ageTextBox.Text),
                                        addressTextBox.Text, Convert.ToInt32(gpaTextBox.Text));
                                    MessageBox.Show("Data Saved Successfully!!!");
                                    ShowCurrentStuData(idTextBox.Text, nameTextBox.Text, mobileTextBox.Text, Convert.ToInt32(ageTextBox.Text),
                                        addressTextBox.Text, Convert.ToInt32(gpaTextBox.Text));
                                }

                            }
                            
                            
                            
                                
                            
                        }
                    }
                }
            }
        }
        private void AddStudent(string id, string name, string mobile,int age,string address,double gpa )
        {
           
            ids.Add(id);
            names.Add(name);
            mobiles.Add(mobile);
            ages.Add(age);
            addresses.Add(address);
            cgpa.Add(gpa);
        }
        private void ShowCurrentStuData(string id, string name, string mobile, int age, string address, double gpa)
        {
            string message;
            message = "Id:\t" + id + "\nName:\t" + name + "\nMobile:\t" + mobile + "\nAge:\t" + age + "\nAddress:\t" + address + "\nGPA:\t" + gpa;
            stuInforichTextBox.Text = message;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            stuInforichTextBox.Text = "";
            string message="";
            
            for (int i=0;i<ids.Count();i++)
            {

                message += "Id:\t" + ids[i] + "\nName:\t" + names[i] + "\nMobile:\t" + mobiles[i] + "\nAge:\t" + ages[i] + "\nAddress:\t" +
                    addresses[i] + "\nGPA:\t" + cgpa[i]+"\n\n\n";

            }
            stuInforichTextBox.Text += message;
            
            CaculateTotalGpa();
            MaxGpa();

        }
        private void CaculateTotalGpa()
        {
            double counter = 0;
            double sum = 0;
            double ans = 0;
            for (int i=0;i<cgpa.Count();i++)
            {
                sum +=cgpa[i];
                counter++;
            }
            ans = sum / counter;
            aveTextBox.Text = ans.ToString();
            totalStuTextBox.Text = sum.ToString();
            
        }
        private void MaxGpa()
        {
            double maxValue = cgpa.Max();
            int index = cgpa.IndexOf(maxValue);
            double minValue = cgpa.Min();
            int index1 = cgpa.IndexOf(minValue);

            maxNameTextBox.AppendText(names[index]);
            minNameTextBox.AppendText(names[index1]);
            maxTextBox.Text = maxValue.ToString();
            minTextBox.Text = minValue.ToString();
        }

        private void Show()
        {
           // stuInforichTextBox.Text = "";
            string message = "";

            for (int i = 0; i < ids.Count(); i++)
            {

                message += "Id:\t" + ids[i] + "\nName:\t" + names[i] + "\nMobile:\t" + mobiles[i] + "\nAge:\t" + ages[i] + 
                    "\nAddress:\t" + addresses[i] + "\nGPA:\t" + cgpa[i] + "\n\n\n";

            }
            stuInforichTextBox.Text += message;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            stuInforichTextBox.Text = "";
            if (idRadioButton.Checked == true)
            {
                if (ids.Contains(idTextBox.Text))
                {
                    int index = ids.IndexOf(idTextBox.Text);

                    stuInforichTextBox.Text=("Id: " + ids[index]+"\n" + "Name:"+ names[index]+"\n"+"Mobile: "+mobiles[index]+"\n"+"Age: "+"\n"+"Address: "+
                        addresses+"\n"+"Gpa: "+cgpa+"\n");
                }
                if  (names.Contains(nameRadioButton.Text))
                {
                    int index = names.IndexOf(nameRadioButton.Text);
                    stuInforichTextBox.Text= ("Id: " + ids[index] + "\n" + "Name:" + names[index] + "\n" + "Mobile: " + mobiles[index] + "\n" + "Age: " + "\n" + 
                        "Address: " + addresses + "\n" + "Gpa: " + cgpa + "\n");
                }
                if (mobiles.Contains(mobileRadioButton.Text))
                {
                    int index = mobiles.IndexOf(mobileTextBox.Text);
                    stuInforichTextBox.Text = ("Id: " + ids[index] + "\n" + "Name:" + names[index] + "\n" + "Mobile: " + mobiles[index] + "\n" + "Age: " + "\n"
                        + "Address: " +addresses + "\n" + "Gpa: " + cgpa + "\n");

                }
            }
            else
            {
                MessageBox.Show("Please Select Radio Button For Search...!");
            }
        }
    }
}
