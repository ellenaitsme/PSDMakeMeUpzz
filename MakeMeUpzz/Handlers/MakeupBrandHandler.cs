using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handlers
{
    public class MakeupBrandHandler
    {
        MakeupBrandRepository brandRepo = new MakeupBrandRepository();

        public void DeleteMakeupBrand(String id)
        {
            MakeupBrand brand = brandRepo.getMakeupBrandbyId(id);

            if(brand != null)
            {
                return;
            }

            if(brand.Makeups.Count > 0)
            {
                MakeupRepository makeupRepo = new MakeupRepository();
                makeupRepo.removeMakeupsbyBrand(id);
            }

            brandRepo.removeMakeupBrands(id);
        }
    }
}