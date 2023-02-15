using Notifications.DAL.DataBaseMainOperations;
using Notifications.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Notifications.DAL.UsersOperations
{
    public class UserRegistration
    {
        DataBaseConnection _connection = new DataBaseConnection();

        public void RegistrationUser(User userToRegister)
        {
            _connection.OpenConnaction();

            SqlCommand insertNewUser = new SqlCommand(
                "INSERT INTO [Users] (Name, Password) " +
                "VALUES (@Name, @Password)" +
                "", _connection.GetSqlConnection());

            insertNewUser.Parameters.AddWithValue("Name", userToRegister.Name);
            insertNewUser.Parameters.AddWithValue("Password", userToRegister.Password);

            int countCreations = insertNewUser.ExecuteNonQuery();

            _connection.CloseConnaction();
        }

        public bool IsUserLoginIsset(string login)
        {
            _connection.OpenConnaction();

            SqlCommand insertNewUserReader = new SqlCommand("SELECT * FROM Users", _connection.GetSqlConnection());
            SqlDataReader readerUsersInformation = insertNewUserReader.ExecuteReader();

            while (readerUsersInformation.Read())
            {
                if (readerUsersInformation["Name"].ToString() == login)
                {
                    throw new Exception("This login is instanse");
                }
            }

            _connection.CloseConnaction();
            return false;
        }
    }
}
