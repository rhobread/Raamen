using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raamen.Model;
using Raamen.Repository;

namespace Raamen.Handler
{
    public class UserHandler
    {
        public static String CheckUserLogin(String username, String password)
        {
            if (UserRepository.GetUserLogin(username,password) != null)
            {
                return "Successful Login";
            }
            else
            {
                return "User Doesn't Exist";
            }
        }

        public static String CheckUserRegister(String username)
        {
            if (UserRepository.GetUserRegister(username) == null)
            {
                return "Successful Register";
            }
            else
            {
                return "User Exists";
            }
        }
    }
}