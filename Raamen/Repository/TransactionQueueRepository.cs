using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class TransactionQueueRepository
    {
         Database1Entities db = DBSingleton.GetInstance();

        public List<HeaderTool> GetTransactionQueue()
        {
            return (from x in db.HeaderTools select x).ToList();
        }

  
        public List<HeaderTool> FindById(string Id)
        {
            int parsedId = Convert.ToInt32(Id);

            return (from x in db.HeaderTools where x.Customerid.Equals(Id) select x).ToList();
        }

        public int HandleOrder(List<HeaderTool> list)
        {
            db.HeaderTools.RemoveRange(list);
            return db.SaveChanges();
        }
    }
}