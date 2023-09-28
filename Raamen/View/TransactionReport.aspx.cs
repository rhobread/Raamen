using Raamen.Dataset;
using Raamen.Handler;
using Raamen.Model;
using Raamen.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RamenCrystalReport report = new RamenCrystalReport();
            CrystalReportViewer1.ReportSource = report;
            RamenDataSet data = GetData(TransactionReportHandler.GetHeaders());
            report.SetDataSource(data);
        }

        private RamenDataSet GetData(List<Header> headers)
        {
            RamenDataSet data = new RamenDataSet();
            var headertable = data.Headers;
            var detailtable = data.Details;

            foreach (Header t in headers)
            {
                var hrow = headertable.NewRow();
                hrow["Id"] = t.Id;
                hrow["Customerid"] = t.Customerid;
                hrow["Staffid"] = t.Staffid;
                hrow["Date"] = t.Date;

                headertable.Rows.Add(hrow);

                foreach (Detail d in GetDetailsFromHeader(t))
                {
                    var drow = detailtable.NewRow();
                    drow["Headerid"] = d.Headerid;
                    drow["Ramenid"] = d.Ramenid;
                    drow["Quantity"] = d.Quantity;
                    drow["Subtotal"] = d.Header.User.Headers.Sum(detail => detail.Detail.Quantity);
                    int totalPrice = 0;
                    foreach (Header trans in d.Header.User.Headers)
                    {
                        int quantity = trans.Detail.Quantity ?? 0;
                        int price = trans.Detail.Raman.Price != null ? Convert.ToInt32(trans.Detail.Raman.Price) : 0;
                        totalPrice += quantity * price;
                    }
                    drow["Grandtotal"] = totalPrice;
                    detailtable.Rows.Add(drow);
                }
            }

            return data;
        }

        // Helper method to retrieve the Detail objects from a Header object
        private IEnumerable<Detail> GetDetailsFromHeader(Header header)
        {
            yield return header.Detail;
        }
    }
}