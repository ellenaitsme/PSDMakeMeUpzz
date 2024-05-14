using MakeMeUpzz.Factories;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories
{
    public class MakeupTypeRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();
        public List<MakeupType> getAllMakeupTypes()
        {
            return db.MakeupTypes.ToList();
        }

        public MakeupType getMakeupTypebyID(String id)
        {
            return (from x in db.MakeupTypes where x.MakeupTypeID == Convert.ToInt32(id) select x).FirstOrDefault();
        }

        public void removeMakeupTypes(String id)
        {
            MakeupType type = db.MakeupTypes.Find(Convert.ToInt32(id));
            db.MakeupTypes.Remove(type);
            db.SaveChanges();
        }
    }
}