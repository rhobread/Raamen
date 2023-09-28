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
    public partial class RegisterStaff : System.Web.UI.Page
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
            String username = UsernameStaffRegisterTextBox.Text;
            String email = EmailStaffRegisterTextBox.Text;
            String gender = GenderStaffList.SelectedValue;
            String password = PasswordStaffRegisterTextBox.Text;
            String cpassword = ConfirmPassStaffTextBox.Text;

            ErrorStaffLabel.Text = UserController.Register(username, email, gender, password, cpassword);
                
            if(ErrorStaffLabel.Text.Equals("Register Successful"))
            {
                User u = new User();
                u.Id = newId();
                u.Roleid = 1;
                u.Username = UsernameStaffRegisterTextBox.Text.ToString();
                u.Email = EmailStaffRegisterTextBox.Text.ToString();
                u.Gender = GenderStaffList.SelectedValue;
                u.Password = PasswordStaffRegisterTextBox.Text.ToString();

                db.Users.Add(u);
                db.SaveChanges();
            }

            
            
        }
    }
}