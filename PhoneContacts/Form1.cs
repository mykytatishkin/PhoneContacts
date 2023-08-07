using Microsoft.Data.SqlClient;
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
                // No need to close the connection here
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Re-open the database connection before refreshing the DataGridView data
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                if (connection.State == ConnectionState.Open)
                    MessageBox.Show("Connection open");
                else if (connection.State == ConnectionState.Closed)
                    MessageBox.Show("Connection closed");
                else
                    MessageBox.Show("No connection");

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
                // No need to close the connection here
            }
        }

        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            string query = "exec GetAllContacts";

            // Ensure the connection is open before executing the query
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var addForm = new FormAddContact("", "", DateTime.Now))
            {
                var result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Get data from the dialog and add it to the database
                    string fullName = addForm.FullName;
                    string phoneNumber = addForm.PhoneNumber;
                    DateTime dateOfBirth = addForm.DateOfBirth;

                    try
                    {
                        // Open the connection to the database
                        using (var connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Call the stored procedure InsertContact
                            using (SqlCommand insertCommand = new SqlCommand("dbo.InsertContact", connection))
                            {
                                insertCommand.CommandType = CommandType.StoredProcedure;
                                insertCommand.Parameters.AddWithValue("@FullName", fullName);
                                insertCommand.Parameters.AddWithValue("@TelephoneNumber", phoneNumber);
                                insertCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                                insertCommand.ExecuteNonQuery();
                            }

                            // After adding, refresh the data in the DataGridView
                            DataTable data = GetDataFromTable();
                            dataGridView.DataSource = data;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Get current values from the selected row
                string fullName = selectedRow.Cells["FullName"].Value.ToString();
                string phoneNumber = selectedRow.Cells["TelephoneNumber"].Value.ToString();
                DateTime dateOfBirth = (DateTime)selectedRow.Cells["DateOfBirth"].Value;
                int contactID = (int)selectedRow.Cells["ID"].Value; // Get the ID of the selected contact

                // Open the dialog with current data for editing
                using (var editForm = new FormAddContact(fullName, phoneNumber, dateOfBirth))
                {
                    var result = editForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Get the updated data from the dialog
                        string updatedFullName = editForm.FullName;
                        string updatedPhoneNumber = editForm.PhoneNumber;
                        DateTime updatedDateOfBirth = editForm.DateOfBirth;

                        try
                        {
                            // Open the connection to the database
                            using (var connection = new SqlConnection(connectionString))
                            {
                                connection.Open();

                                // Call the stored procedure UpdateContact with the contactID parameter
                                using (SqlCommand updateCommand = new SqlCommand("dbo.UpdateContact", connection))
                                {
                                    updateCommand.CommandType = CommandType.StoredProcedure;
                                    updateCommand.Parameters.AddWithValue("@ID", contactID); // Pass the ID of the selected contact
                                    updateCommand.Parameters.AddWithValue("@NewFullName", updatedFullName);
                                    updateCommand.Parameters.AddWithValue("@NewPhoneNumber", updatedPhoneNumber);
                                    updateCommand.Parameters.AddWithValue("@NewDateOfBirth", updatedDateOfBirth);
                                    updateCommand.ExecuteNonQuery();
                                }

                                // After updating, refresh the data in the DataGridView
                                DataTable data = GetDataFromTable();
                                dataGridView.DataSource = data;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    int selectedRowID = (int)dataGridView.SelectedRows[0].Cells["ID"].Value;

                    // Call the stored procedure DeleteContact
                    using (SqlCommand deleteCommand = new SqlCommand("dbo.DeleteContact", connection))
                    {
                        deleteCommand.CommandType = CommandType.StoredProcedure;
                        deleteCommand.Parameters.AddWithValue("@ID", selectedRowID);
                        deleteCommand.ExecuteNonQuery();
                    }

                    // After deleting, refresh the data in the DataGridView
                    DataTable data = GetDataFromTable();
                    dataGridView.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // No need to close the connection here
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
