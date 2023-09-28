using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Raamen.Model;
using Raamen.Repository;

namespace Raamen.View
{
    public partial class Profile : System.Web.UI.Page
    {
        Database1Entities db = DBSingleton.GetInstance();
        //User user = UserRepository.GetUserLogin();
        User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            // ambil id user
            //user = db.Users.Find(3);
            user = (User)Session["user"];

            if (!IsPostBack)
            {         
                tbUsername.Text = user.Username;
                tbEmail.Text = user.Email;
                ddlGender.SelectedValue = user.Gender;
                tbPassword.Text = user.Password;
            }
            else
            {
                Session["user"] = user;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            User u = (db.Users.Find(user.Id));

            bool isValid = Regex.IsMatch(tbUsername.Text, "^[a-zA-Z]{5,15}$");
            if (tbUsername.Text.Length < 5 || tbUsername.Text.Length > 15 || isValid == false)
            {
                lblError.Text = "Length must be between 5 and 15 with alphabet only";
            }
            else if (!tbEmail.Text.EndsWith(".com"))
            {
                lblError.Text = "Must ends with '.com'";
            }
            else if (ddlGender.SelectedValue == null)
            {
                lblError.Text = "Gender Must be chosen";
            }
            else if (tbPassword.Text == "" || tbPassword.Text != u.Password)
            {
                lblError.Text = "Must be the same with the current password";
            }
            else
            {
                u.Username = tbUsername.Text;
                u.Email = tbEmail.Text;
                u.Gender = ddlGender.SelectedValue;
                u.Password = tbPassword.Text;

                db.SaveChanges();
                Response.Redirect("~/View/Profile.aspx");
            }
        }
    }
}