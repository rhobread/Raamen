using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View
{
    public partial class TransactionDetails : System.Web.UI.Page
    {
        public Model.Header Head = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionRepository repo = new TransactionRepository();

            string Id = Request.QueryString["Id"];

            Head = repo.FindById(Id);

            if (Id == null || Head == null)
            {
                Response.Redirect("/View/TransactionHistory");
            }

        }
    }
}