using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PhoneContacts
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public string connectionString = "Data Source = OTISHKIN-NAS\\DEVELOP_2019; Initial Catalog = PhoneContacts; User ID = db_admin; Password =Qwerty.1; TrustServerCertificate = True";

        public Form1()
        {
            InitializeComponent();
            
            try
            {
                // Open the database connection before populating the DataGridView
                connection = new SqlConnection(connectionString);
                connection.Open();

                DataTable data = GetDataFromTable();
                dataGridView.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Make sure to close the connection after use
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Re-open the database connection before refreshing the DataGridView data
                if (connection != null && connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                        MessageBox.Show("Connection open");
                    else if (connection.State == ConnectionState.Closed)
                        MessageBox.Show("Connection closed");
                    else
                        MessageBox.Show("No connection");
                    
                }

                // Call the method to refresh the DataGridView data
                DataTable data = GetDataFromTable();
                dataGridView.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Make sure to close the connection after use
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Contacts"; // Replace YourTableName with your actual table name

            // Ensure the connection is open before executing the query
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
