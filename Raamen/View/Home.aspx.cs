using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Raamen.Model;
using Raamen.Repository;

namespace Raamen.View
{
    public partial class Home : System.Web.UI.Page
    {
        Database1Entities db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookies"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else {
                User user;
                
                if(Session["user"] == null)
                {
                    var id = Request.Cookies["user_cookies"].Value;
                    user = (from x in db.Users where x.Id.Equals(id) select x).FirstOrDefault();
                    Session["user"] = user;
                }
                else
                {
                    user = (User) Session["user"];
                }

                int userRoleID = (int)Session["userRoleID"];
                if (userRoleID == 3){
                    lblRole.Text = "Member!";
                    lblList.Visible = false;
                    listUser.Visible = false;
                }
                else if (userRoleID == 2)
                {
                    lblRole.Text = "Staff!";
                    lblList.Text = "List Customer Data";

                    var users = (from x in db.Users where x.Role.Id == 3 select x);

                    foreach (var x in users)
                    {
                        listUser.Items.Add(x.Username);
                    }
                }else if(userRoleID == 1)
                {
                    lblRole.Text = "Admin!";
                    lblList.Text = "List Staff Data";

                    var users = (from x in db.Users where x.Role.Id == 2 select x);

                    foreach (var x in users)
                    {
                        listUser.Items.Add(x.Username);
                    }
                }
            }
        }
    }
}