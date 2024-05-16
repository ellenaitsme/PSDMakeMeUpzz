using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controllers
{
    public class MakeupController
    {
        public bool validateName(String name)
        {
            if (name.Length < 1 || name.Length > 99)
            {
                return true;
            }
            else return false;
        }

        public bool validate(String name, int price, int weight)
        {
            if (validateName(name) || price < 1 || weight > 1500)
            {
                return false;
            }
            else return true;
        }
    }
}