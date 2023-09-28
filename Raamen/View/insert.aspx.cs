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
    public partial class insert : System.Web.UI.Page
    {
        Database1Entities db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            //   if (IsPostBack == false)
            //   {
            //      List<string> listType = (from type in db.guitar_types select type.name).ToList();
            //
            //               DropDownList1.DataSource = listType;
            //             DropDownList1.DataBind();
            //       }

            /*if (IsPostBack == false)
            {
                string id = Request["ID"];
                Raman r = (db.Ramen.Find(id));
                Name_box.Text = r.Name;
            }*/

            if (IsPostBack == false)
            {
                List<string> listType = (from type in db.Meats select type.name).ToList();

                meat_box.DataSource = listType;
                meat_box.DataBind();
            }
            
        }

        protected int newId()
        {
            int id = 0;
            int currId = (from ramen in db.Ramen select ramen.Id).ToList().LastOrDefault();

            id = currId + 1;
            return id;
        }

        protected void InsertRamen(object sender, EventArgs e)
        {

            // Ketika submitted

            Raman r = new Raman();
            r.Id = newId();
            r.Name = Name_box.Text.ToString();
           
            
            //r.Meat = new lab.model.Meat(meat_box.Text.ToString());
            r.Meatid = (from type in db.Meats
                        where type.name == meat_box.SelectedValue
                        select type.Id).ToList().LastOrDefault();
            r.Borth = broth_box.Text.ToString();
            r.Price = price_box.Text.ToString();


            if (!Name_box.Text.ToString().Contains("ramen"))
            {
                Name_Error.Text = "must contain the word ramen in it";
                return;
            }
            else
            {
                Name_Error.Text = "";
            }
            if (broth_box.Text == "")
            {
                Broth_Error.Text = "Broth can't be empty";
                return;
            }
            else
            {
                Broth_Error.Text = "";
            }

            if (int.Parse(price_box.Text.ToString()) < 3000)
            {
                Price_Error.Text = "Price must at leats be 3000";
                return;
            }
            else
            {
                Price_Error.Text = "";
            }

            db.Ramen.Add(r);
            db.SaveChanges();

            

            Response.Redirect("manage.aspx");
        }
        protected void manage_Click(object sender, EventArgs e)
        {
            Response.Redirect("manage.aspx");
        }
    }
}