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
    public partial class update : System.Web.UI.Page
    {
        Database1Entities db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            string idString = Request["ID"];
            int id;

            if (int.TryParse(idString, out id)) {
                if (IsPostBack == false)
                {
                    Raman r = db.Ramen.Find(id);
                    Name_box.Text = r.Name;
                    broth_box.Text = r.Borth;
                    meat_box.SelectedValue = (from meat in db.Meats where r.Meatid == meat.Id select meat.name).FirstOrDefault();
                    price_box.Text = r.Price;

                    List<string> listMeat = (from type in db.Meats select type.name).ToList();
                    meat_box.DataSource = listMeat;
                    meat_box.DataBind();
                    string meatName = (from meat in db.Meats where r.Meatid == meat.Id select meat.name).ToList().LastOrDefault();
                    meat_box.SelectedValue = meatName;
                    meat_box.DataBind();

                    // Raman r = (db.Ramen.Find(id));
                    // Name_box.Text = r.Name;

                    


                }
            }
               
        }

        protected void UpdateRamen(object sender, EventArgs e)

        {
            
            string idString = Request["ID"];
            int id;
            if (int.TryParse(idString, out id))
            {
                Raman r = db.Ramen.Find(id);
                //int meatid = (from meat in db.Meats where meat.Id == r.Meatid select meat.Id).ToList().LastOrDefault();

         
                r.Name = Name_box.Text.ToString();
                //r.Meat = new lab.model.Meat(meat_box.Text.ToString());

                r.Meatid = (from type in db.Meats
                            where type.name == meat_box.SelectedValue
                            select type.Id).ToList().LastOrDefault();
                r.Borth = broth_box.Text.ToString();
                r.Price = price_box.Text.ToString();

                
                db.SaveChanges();
            }

                Response.Redirect("manage.aspx");
        }
        protected void manage_Click(object sender, EventArgs e)
        {
            Response.Redirect("manage.aspx");
        }

        protected void meat_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
