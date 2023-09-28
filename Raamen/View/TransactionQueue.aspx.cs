using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View
{
 
    public partial class TransactionQueue : System.Web.UI.Page
    {
        Database1Entities db = new Database1Entities();
        public List<HeaderTool> HeaderTools = new List<HeaderTool>();
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionQueueRepository repo = new TransactionQueueRepository();
            HeaderTools = repo.GetTransactionQueue();

        }

        protected int newId()
        {
            int id = 0;
            int currId = (from header in db.Headers select header.Id).ToList().LastOrDefault();

            id = currId + 1;
            return id;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            HeaderTool ht = new HeaderTool();
            Header head = new Header();

            head.Customerid = newId();
            if (head != null && ht != null && ht.User != null)
            {
                if (head.User == null)
                {
                    head.User = new User();
                }

                head.User.Username = ht.User.Username;
            }
            head.Date = ht.Date;

            if (head != null && ht != null && ht.DetailTool != null)
            {
                if (head.Detail == null)
                {
                    head.Detail = new Detail();
                }

                head.Detail.Quantity = ht.DetailTool.Quantity;
            }
            if (head != null && ht != null &&
                ht.DetailTool != null && ht.DetailTool.Raman != null &&
                ht.DetailTool.Raman.Meat != null && head.Detail != null &&
                head.Detail.Raman != null && head.Detail.Raman.Meat != null)
            {
                head.Detail.Raman.Name = ht.DetailTool.Raman.Name;
                head.Detail.Raman.Meat.name = ht.DetailTool.Raman.Meat.name;
                head.Detail.Raman.Borth = ht.DetailTool.Raman.Borth;
            }

            db.Headers.Add(head);
            db.HeaderTools.Attach(ht);
            db.HeaderTools.Remove(ht);
            db.SaveChanges();
        }
    }
}