using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handlers
{
    public class MakeupTypeHandler
    {
        MakeupTypeRepository typeRepo = new MakeupTypeRepository();

        public void DeleteMakeupType(String id)
        {
            MakeupType type = typeRepo.getMakeupTypebyID(id);

            if (type != null)
            {
                return;
            }

            if (type.Makeups.Count > 0)
            {
                MakeupRepository makeupRepo = new MakeupRepository();
                makeupRepo.removeMakeupsbyType(id);
            }

            typeRepo.removeMakeupTypes(id);
        }
    }
}