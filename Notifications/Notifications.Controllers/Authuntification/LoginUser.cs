using Notifications.DAL.UsersOperations;
using Notifications.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications.Controllers.Authuntification
{
    public class LoginUser
    {
        public bool IsEnteredCurrectData(User userToLogin)
        {
            if(userToLogin.Name == string.Empty)
            {
                return false;
            }

            if (userToLogin.Password == string.Empty)
            {
                return false;
            }

            UserAuthtorization loginDAL = new UserAuthtorization();

            if (loginDAL.IsEnterCurrectLoginData(userToLogin) == true)
            {
                return true;
            }
      
            return false;
        }
    }
}
