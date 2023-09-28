using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Raamen.Repository;

namespace Raamen.View
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userRoleID = 0;
            //int userRoleID = (int)Session["userRoleID"];

            if(userRoleID == 1)
            {
                //PlaceHolderAdmin.Visible = true;
                //lbOrderRamen.Visible = false;
            }
            else if(userRoleID == 2)
            {
                //PlaceHolderStaff.Visible = true;
                //lbOrderRamen.Visible = false;
                //lbHistory.Visible = false;
                //lbReport.Visible = false;
            }
            else if(userRoleID == 3)
            {
                //PlaceHolderMember.Visible = true;
                //lbManageRamen.Visible = false;
                //lbOrderQueue.Visible = false;
                //lbReport.Visible = false;
            }
            else
            {
                //Response.Redirect("Login.aspx");
            }
        }

        protected void lbHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void lbOrderRamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderRaamen.aspx");
        }

        protected void lbManageRamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("");
        }

        protected void lbOrderQueue_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionQueue.aspx");
        }

        protected void lbHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistory.aspx");
        }

        protected void lbReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionReport.aspx");
        }

        protected void lbProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void lbLogout_Click(object sender, EventArgs e)
        {

        }
    }
}