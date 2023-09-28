using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class TransactionRepository
    {
        static Database1Entities db = DBSingleton.GetInstance();

        public List<Header> GetTransaction()
        {
            return (from Header in db.Headers select Header).ToList();
        }
        public Header FindById(string Id)
        {
            int parsedId = Convert.ToInt32(Id);

            return (from Header in db.Headers
                    where Header.Id == parsedId
                    select Header).FirstOrDefault();
        }

        public static int newHTID()
        {
            int num;
            if((from x in db.HeaderTools select x).Count() == 0)
            {
                num = 1;
            }
            else
            {
                num = (from x in db.HeaderTools select x).Count() + 1;
            }

            return num; 
        }

        public static int newDTID()
        {
            int num;
            if ((from x in db.DetailTools select x).Count() == 0)
            {
                num = 1;
            }
            else
            {
                num = (from x in db.DetailTools select x).Count() + 1;
            }

            return num;
        }
    }
}