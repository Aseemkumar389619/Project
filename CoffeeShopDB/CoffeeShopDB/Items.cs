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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }
        private void AddCustomer()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"INSERT INTO Items(Name,Price) VALUES ('" + nameTextBox.Text + "'," + priceTextBox.Text + ")";
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

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowItems();
        }
        private void ShowItems()
        { 
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"SELECT * FROM Items";
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
            DeleteItems();
        }
        private void DeleteItems()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"DELETE FROM Items WHERE ID=" + idTextBox.Text + "";
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
            UpdateItems();
        }
        private void UpdateItems()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"UPDATE Items SET Name='" + nameTextBox.Text + "',Price=" + priceTextBox.Text + " WHERE ID=" + idTextBox.Text + "";
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

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
        private void SearchItems()
        {
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"SELECT * FROM Items WHERE ID=" + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                showDataGridView.DataSource = dataTable;
            }
            catch(Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }
        }
    }
}
