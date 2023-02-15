using Notifications.DAL.DataBaseMainOperations;
using Notifications.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notifications.DAL.UsersOperations
{
    public class UserAuthtorization
    {
        DataBaseConnection _connection = new DataBaseConnection();

        public bool IsEnterCurrectLoginData(User userToLogin)
        {
            _connection.OpenConnaction();

            SqlCommand insertNewUserReader = new SqlCommand("SELECT Name, Password FROM Users", _connection.GetSqlConnection());
            SqlDataReader readerUsersInformation = insertNewUserReader.ExecuteReader();

            while (readerUsersInformation.Read())
            {
                if (Convert.ToString(readerUsersInformation["Name"]) != userToLogin.Name)
                {
                    continue;
                }

                if (Convert.ToString(readerUsersInformation["Password"]) != userToLogin.Password)
                {
                    continue;
                }

                _connection.CloseConnaction();
                return true;
            }

            return false;
        }
    }
}
