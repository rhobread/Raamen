using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using Raamen.Model;
using Raamen.Repository;

namespace Raamen.View
{
    public partial class OrderRaamen : System.Web.UI.Page
    {
        Database1Entities db = DBSingleton.GetInstance();
        protected List<Raman> ramen;
        protected int[] quantityList;

        protected void Page_Load(object sender, EventArgs e)
        {
            ramen = db.Ramen.ToList();

            if (!IsPostBack)
            {
                ramenGridView.DataSource = ramen;
                ramenGridView.DataBind();

                quantityList = new int[ramen.Count];
                for (int i = 0; i < quantityList.Length; i++)
                {
                    quantityList[i] = 0;
                }
                ViewState["QuantityList"] = quantityList;


            }
            else
            {
                quantityList = (int[])ViewState["QuantityList"];
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            quantityList = new int[ramen.Count];

            ViewState["QuantityList"] = quantityList;

            ramenGridView.DataSource = ramen;
            ramenGridView.DataBind();

            totalLabel.Text = "0";
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            int userID = (int)Session["userID"];
            Label1.Text = userID.ToString();

            HeaderTool hd = new HeaderTool
            {
                Id = TransactionRepository.newHTID(),
                Customerid = userID,
                Date = DateTime.Now
            };

            db.HeaderTools.Add(hd);
            db.SaveChanges();

            for (int i = 0; i < ramen.Count; i++)
            {
                if (quantityList[i] == 0)
                    continue;

                DetailTool dt = new DetailTool
                {
                    DetailToolid = TransactionRepository.newDTID(),
                    Headerid = hd.Id,
                    Ramenid = ramen[i].Id,
                    Quantity = quantityList[i]
                };

                db.DetailTools.Add(dt);
                db.SaveChanges();
                
            }
            Label1.Text = "Order Successful!";
        }

        protected void ramenGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Order")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = ramenGridView.Rows[rowIndex];

                // update quantity
                Label quantityLabel = (Label)row.FindControl("quantityLabel");

                int quantity = int.Parse(quantityLabel.Text);
                quantity++;
                quantityLabel.Text = quantity.ToString();
                quantityList[rowIndex] = quantity;

                ViewState["QuantityList"] = quantityList;

                // update amount
                Label amountLabel = (Label)row.FindControl("amountLabel");
    
                TableCell priceCell = row.Cells[2];

                int price = int.Parse(priceCell.Text);
                long amount = price * quantity;
                amountLabel.Text = amount.ToString();

                // total price
                //Label totalLabel = (Label)FindControl("totalLabel");
                totalLabel.Text = GetTotalAmount().ToString();
            }
        }

        private long GetTotalAmount()
        {
            long totalAmount = 0;

            foreach (GridViewRow row in ramenGridView.Rows)
            {
                Label amountLabel = (Label)row.FindControl("amountLabel");
                long amount = long.Parse(amountLabel.Text);
                totalAmount += amount;
            }

            return totalAmount;
        }

    }
}