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
            string query = "exec GetAllContacts"; // Replace YourTableName with your actual table name

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
            using (var addForm = new FormAddContact("","",DateTime.Now))
            {
                var result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Получаем данные из диалогового окна и добавляем их в базу данных
                    string fullName = addForm.FullName;
                    string phoneNumber = addForm.PhoneNumber;
                    DateTime dateOfBirth = addForm.DateOfBirth;

                    try
                    {
                        // Открываем соединение с базой данных
                        using (var connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Вызываем хранимую процедуру InsertContact
                            using (SqlCommand insertCommand = new SqlCommand("dbo.InsertContact", connection))
                            {
                                insertCommand.CommandType = CommandType.StoredProcedure;
                                insertCommand.Parameters.AddWithValue("@FullName", fullName);
                                insertCommand.Parameters.AddWithValue("@TelephoneNumber", phoneNumber);
                                insertCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                                insertCommand.ExecuteNonQuery();
                            }

                            // После добавления обновляем данные в DataGridView
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

                // Получаем текущие значения из выбранной строки
                string fullName = selectedRow.Cells["FullName"].Value.ToString();
                string phoneNumber = selectedRow.Cells["TelephoneNumber"].Value.ToString();
                DateTime dateOfBirth = (DateTime)selectedRow.Cells["DateOfBirth"].Value;

                // Открываем диалоговое окно с текущими данными для редактирования
                using (var editForm = new FormAddContact(fullName, phoneNumber, dateOfBirth))
                {
                    var result = editForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Получаем измененные данные из диалогового окна
                        string updatedFullName = editForm.FullName;
                        string updatedPhoneNumber = editForm.PhoneNumber;
                        DateTime updatedDateOfBirth = editForm.DateOfBirth;

                        try
                        {
                            // Открываем соединение с базой данных
                            using (var connection = new SqlConnection(connectionString))
                            {
                                connection.Open();

                                // Вызываем хранимую процедуру UpdateContact
                                using (SqlCommand updateCommand = new SqlCommand("dbo.UpdateContact", connection))
                                {
                                    updateCommand.CommandType = CommandType.StoredProcedure;
                                    updateCommand.Parameters.AddWithValue("@OldPhoneNumber", phoneNumber); // Используем текущий номер телефона как условие для обновления
                                    updateCommand.Parameters.AddWithValue("@NewFullName", updatedFullName);
                                    updateCommand.Parameters.AddWithValue("@NewPhoneNumber", updatedPhoneNumber);
                                    updateCommand.Parameters.AddWithValue("@NewDateOfBirth", updatedDateOfBirth);
                                    updateCommand.ExecuteNonQuery();
                                }

                                // После обновления обновляем данные в DataGridView
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

                    // Вызываем хранимую процедуру DeleteContact
                    using (SqlCommand deleteCommand = new SqlCommand("dbo.DeleteContact", connection))
                    {
                        deleteCommand.CommandType = CommandType.StoredProcedure;
                        deleteCommand.Parameters.AddWithValue("@ID", selectedRowID);
                        deleteCommand.ExecuteNonQuery();
                    }

                    // После удаления обновляем данные в DataGridView
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
