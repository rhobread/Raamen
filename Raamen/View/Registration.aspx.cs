using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Raamen.Controller;
using Raamen.Model;
using Raamen.Repository;

namespace Raamen.View
{
    public partial class Registration : System.Web.UI.Page
    {
        Database1Entities db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected int newId() 
        {
            int id = 0;
            int currid = (from user in db.Users select user.Id).ToList().LastOrDefault();

            id = currid + 1;
            return id;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            String username = UsernameRegisterTextBox.Text;
            String email = EmailRegisterTextBox.Text;
            String gender = GenderList.SelectedValue;
            String password = PasswordRegisterTextBox.Text;
            String cpassword = ConfirmPassTextBox.Text;

            ErrorLabel.Text = UserController.Register(username, email, gender, password, cpassword);

            if (ErrorLabel.Text.Equals("Register Successful")) 
            {
                User u = new User();
                u.Id = newId();
                u.Roleid = 2;
                u.Username = UsernameRegisterTextBox.Text.ToString();
                u.Email = EmailRegisterTextBox.Text.ToString();
                u.Gender = GenderList.SelectedValue;
                u.Password = PasswordRegisterTextBox.Text.ToString();

                db.Users.Add(u);
                db.SaveChanges();
            }
        }
    }
}