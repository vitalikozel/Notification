using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications.DAL.DataBaseMainOperations
{
    public class DataBaseConnection
    {
        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\programs\\visualStudio\\Projects\\Notifications\\Notifications\\Notifications.mdf;Integrated Security=True";

        private SqlConnection _connection;

        public void CreateConnection()
        {
            _connection = new SqlConnection(_connectionString);
        }

        public void OpenConnaction()
        {
            if(_connection == null )
            {
                CreateConnection();
            }

            _connection.Open();
        }

        public void CloseConnaction()
        {
            _connection.Close();
        }

        public SqlConnection GetSqlConnection()
        {
            return _connection;
        }
    }
}
