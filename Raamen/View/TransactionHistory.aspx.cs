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
    public partial class TransactionHistory : System.Web.UI.Page
    {
        public List<Header> Headers = new List<Header>();
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionRepository repo = new TransactionRepository();
            Headers = repo.GetTransaction();

        }
    }
}