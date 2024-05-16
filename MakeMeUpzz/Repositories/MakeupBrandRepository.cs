using MakeMeUpzz.Factories;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories
{
    public class MakeupBrandRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();
        public void removeMakeupBrands(String id)
        {
            MakeupBrand brand = db.MakeupBrands.Find(Convert.ToInt32(id));
            db.MakeupBrands.Remove(brand);
            db.SaveChanges();
        }

        public MakeupBrand getMakeupBrandbyId(String id)
        {
            return (from x in db.MakeupBrands where id.Equals(Convert.ToInt32(id)) select x).FirstOrDefault();
        }

        public List<MakeupBrand> GetMakeupBrands()
        {
            return db.MakeupBrands.ToList();
        }

        public List<MakeupBrand> makeupBrandsDesc()
        {
            return db.MakeupBrands.OrderByDescending(rating => rating.MakeupBrandRating).ToList();
        }
    }
}