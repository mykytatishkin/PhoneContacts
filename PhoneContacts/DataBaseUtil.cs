using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PhoneContacts
{
    internal class DataBaseUtil
    {
        public string _connectionString;

        public DataBaseUtil(string? connectionString)
        {
            _connectionString = connectionString;
            MessageBox.Show(_connectionString);
        }

       

        //public DataGridView GetAllCountries()
        //{
        //    var query = @"select * from Coutry";
        //    using var connection = new SqlConnection(_connectionString);
        //    connection.Open();
        //    using var command = new SqlCommand(query, connection);
        //    using var reader = command.ExecuteReader();
        //    return dataGridView(reader);
        //}
    }
}
