using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Raamen.Model;
namespace Raamen.Repository
{
    public class UserRepository
    {
        static Database1Entities db = DBSingleton.GetInstance();

        public static User GetUserLogin(String username, String password)
        {
            return (from u in db.Users
                    where u.Password == password && u.Username == username select u).FirstOrDefault();
        }

        public static int GetUserSession(String username) 
        {
            return (int)(from u in db.Users
                    where u.Username == username
                    select u.Roleid).FirstOrDefault();
        }
        public static User GetUserRegister(String username)
        {
            return (from u in db.Users
                    where u.Username == username
                    select u).FirstOrDefault();
        }

        public static User getUser(String username)
        {
            return (from u in db.Users
                    where u.Username == username
                    select u).FirstOrDefault();
        }
        public static int getUserID(String username)
        {
            return (from u in db.Users
                    where u.Username == username
                    select u.Id).FirstOrDefault();
        }
        public static int getUserRoleID(String username)
        {
            return (from u in db.Users
                    where u.Username == username
                    select u.Role.Id).FirstOrDefault();
        }
    }
}