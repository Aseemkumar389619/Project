using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopDB
{
    public partial class CoffeeShopUiDB : Form
    {
        List<string> names = new List<string>();
        public CoffeeShopUiDB()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }
        private void AddCustomer()
        {
            try {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                

                string commandString = @"INSERT INTO Customers(Name,Address,Contact) VALUES ('" + nameTextBox.Text + "','" + addressTextBox.Text + "',"+contactTextBox.Text+")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                foreach (string name in names)
                //{
                //    if (name == nameTextBox.Text)
                //    {
                //        MessageBox.Show("dublicate id");
                //        return;
                //    }
                //}

                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowCustomers();
        }
        private void ShowCustomers()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"SELECT * FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                showDataGridView.DataSource = dataTable;

                sqlConnection.Close();
            }
            catch(Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteCustomers();

        }

        private void DeleteCustomers()
        { 
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"DELETE FROM Customers WHERE ID=" + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch(Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateCustomers();
        }
        private void UpdateCustomers()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"UPDATE Customers SET Name='" + nameTextBox.Text + "',Address='" + addressTextBox.Text + "',Contact="+contactTextBox.Text+" WHERE ID=" + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch (Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchCustomers();
        }
        private void SearchCustomers()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"SELECT * FROM Customers WHERE ID=" + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                showDataGridView.DataSource = dataTable;

                sqlConnection.Close();
            }
            catch(Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }
        }
    }
}
