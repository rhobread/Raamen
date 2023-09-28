using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raamen.Model;

namespace Raamen.Repository
{
    public class DBSingleton 
    {
        //private constructor
        //private static tipedata object
        //TipeData GetInstance() -> Static

        private static Database1Entities db = null;

        private DBSingleton()
        {

        }

        public static Database1Entities GetInstance()
        {
            if (db == null)
            {
                db = new Database1Entities();
            }
            return db;
        }

        //Database1Entities1 db = DBSingleton.GetInstance(); (klo mo panggil)

    }
}
