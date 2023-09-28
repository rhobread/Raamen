using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Handler
{
    public class TransactionReportHandler
    {
        public static List<Header> GetHeaders()
        {
            return TransactionReportRepository.GetHeaders();
        }
    }
}