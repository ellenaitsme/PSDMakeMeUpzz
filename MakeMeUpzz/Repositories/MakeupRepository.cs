using MakeMeUpzz.Factories;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories
{
    public class MakeupRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<Makeup> getAllMakeups()
        {
            return db.Makeups.ToList();
        }
    }
}