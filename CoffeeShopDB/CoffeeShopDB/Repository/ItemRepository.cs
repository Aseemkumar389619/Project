using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopDB.Repository
{
    public class ItemRepository
    {
        public bool Add(string name, double price)
        {
            bool isAdded = false;
            try
            {
                string connectionString = @"server =DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"INSERT INTO Items(Name,Price) VALUES ('" + name + "'," + price + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }
                sqlConnection.Close();
            }
            catch (Exception Exception)
            {
                //MessageBox.Show(Exception.Message);
            }
            return isAdded;
        }
        public bool IsNameExists(string name)
        {
            bool exists = false;
            try
            {

                string connectionString = @"Server=DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"SELECT * FROM Items WHERE Name='" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }
        public bool Delete(int id)
        {
            try
            {

                string connectionString = @"Server=DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"DELETE FROM Items WHERE ID = " + id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                // MessageBox.Show(exeption.Message);
            }

            return false;
        }
        public DataTable Display()
        {

            
            string connectionString = @"Server=DESKTOP-61R9QU6; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT * FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;

        }
    }
}
