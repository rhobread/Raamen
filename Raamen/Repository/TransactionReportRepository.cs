using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class TransactionReportRepository
    {
        public static List<Header> GetHeaders()
        {
            Database1Entities db = new Database1Entities();
            return db.Headers.ToList();
        }
    }
}