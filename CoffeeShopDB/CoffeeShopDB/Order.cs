using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopDB
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }
       
        private void showButton_Click(object sender, EventArgs e)
        {
            ShowCustomers();
        }
        
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteCustomers();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateCustomers();
        }
        

        private void searchButton_Click(object sender, EventArgs e)
        
        {
            SearchCustomers();
        }
            
        private void AddCustomer()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                string commandString = @"INSERT INTO Orders(Customer,Item,Quantity,Price) VALUES ('" + customerTextBox.Text + "','" + itemTextBox.Text + "'," + quantityTextBox.Text + "," + priceTextBox.Text + ")";
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
        private void ShowCustomers()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"SELECT * FROM Orders";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                showDataGridView.DataSource = dataTable;

                sqlConnection.Close();
            }
            catch (Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }
        }
        private void DeleteCustomers()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"DELETE FROM Orders WHERE ID=" + idTextBox.Text + "";
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
        private void UpdateCustomers()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"UPDATE Customers SET Customer='" + customerTextBox.Text + "',Item='" + itemTextBox.Text + "',Quantity=" + quantityTextBox.Text + "," + priceTextBox.Text + " WHERE ID=" + idTextBox.Text + "";
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
        private void SearchCustomers()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"SELECT * FROM Orders WHERE ID=" + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                showDataGridView.DataSource = dataTable;

                sqlConnection.Close();
            }
            catch (Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }
        }
    }
    }

