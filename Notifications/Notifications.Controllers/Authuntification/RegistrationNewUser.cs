using Notifications.DAL.UsersOperations;
using Notifications.Domain.Users;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications.Controllers.Authuntification
{
    public class RegistrationNewUser
    {
        public void Registration(User userToRegister)
        {
            UserRegistration registration = new UserRegistration();

            if(userToRegister.Name == string.Empty)
            {
                return; //here i must return exeption but i not found information about it
            }
            
            if(userToRegister.Password == string.Empty)
            {
                return; //here i must return exeption but i not found information about it
            }

            if (registration.IsUserLoginIsset(userToRegister.Name) == true)
            {
                return; //user already isset
            }

            registration.RegistrationUser(userToRegister);
        }
    }
}
