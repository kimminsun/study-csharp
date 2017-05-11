using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetMVC01_1.Models
{
    public class CInstance
    {
        public static CUserManager theUserManager;
        public static int blnit = 0;

        public static void Initialize()
        {
            if(blnit==0)
            {
                theUserManager = new CUserManager();
            }
            blnit = 1;
        }
    }
}