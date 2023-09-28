using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Raamen.Model;
using Raamen.Repository;

namespace Raamen.view
{
    
     partial class manage : System.Web.UI.Page
    {
        Database1Entities db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                
                List<Raman> ramenList = (db.Ramen).ToList();

                GridView1.DataSource = ramenList;
                GridView1.DataBind();
            }
        }

        
        protected void insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("insert.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.NewEditIndex];
            string idString = row.Cells[0].Text;
            //int id;

            if (int.TryParse(idString, out int id))
            {
                Response.Redirect("update.aspx?ID=" + id);
            }
            
            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            string idString = row.Cells[0].Text.ToString();
            if (int.TryParse(idString, out int id))
            {
                Raman r = (db.Ramen.Find(id));
                db.Ramen.Remove(r);
                db.SaveChanges();

                GridView1.DataSource = db.Ramen.ToList();
                GridView1.DataBind();
            }
            
        }
    }
}