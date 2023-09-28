using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View
{
    public partial class Startup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogInButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void CustomerRegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void StaffRegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterStaff.aspx");
        }
    }
}