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

        public void removeMakeup(String id)
        {
            Makeup mu = db.Makeups.Find(Convert.ToInt32(id));
            db.Makeups.Remove(mu);
            db.SaveChanges();
        }

        public List<Makeup> getMakeupsbyBrand(String id)
        {
            return (from x in db.Makeups where x.MakeupBrandID == Convert.ToInt32(id) select x).ToList();
        }

        public List<Makeup> getMakeupsbyType(String id)
        {
            return (from x in db.Makeups where x.MakeupTypeID == Convert.ToInt32(id) select x).ToList();
        }

        public void removeMakeupsbyBrand(String id)
        {
            List<Makeup> makeup = getMakeupsbyBrand(id);
            db.Makeups.RemoveRange(makeup);
            db.SaveChanges();
        }

        public void removeMakeupsbyType(String id)
        {
            List<Makeup> makeup = getMakeupsbyType(id);
            db.Makeups.RemoveRange(makeup);
            db.SaveChanges();
        }
    }
}