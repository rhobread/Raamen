using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Raamen.Controller;
using Raamen.Repository;
using Raamen.Handler;

namespace Raamen.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user_cookie"];

            if (cookie != null)
            {
                UsernameTextBox.Text = cookie.Values["Username"];
                PasswordTextBox.Text = cookie.Values["Password"];
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            String username = UsernameTextBox.Text;
            String password = PasswordTextBox.Text;
            bool remember = RememberCheckBox.Checked;

            ErrorLabel.Text = UserController.Login(username, password);
            if (UserHandler.CheckUserLogin(username, password) == "Successful Login")
            {
                if (remember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");

                    cookie.Values["Username"] = username;
                    cookie.Values["Password"] = password;

                    cookie.Expires = DateTime.Now.AddDays(360);

                    Response.Cookies.Add(cookie);
                }

                Session["user"] = UserRepository.getUser(username);
                Session["userID"] = UserRepository.getUserID(username);
                Session["userRoleID"] = UserRepository.getUserRoleID(username);
                Response.Redirect("Home.aspx");
            }
            
        }
    }
}