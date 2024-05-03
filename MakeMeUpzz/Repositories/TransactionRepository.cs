using MakeMeUpzz.Factories;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace MakeMeUpzz.Repositories
{
    public class TransactionRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<TransactionHeader> getAllUnhandledTransaction()
        {
            return (from t in db.TransactionHeaders where t.Status == "Unhandled" select t).ToList();
        }

    }
}