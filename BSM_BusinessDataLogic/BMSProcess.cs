using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSM_BusinessDataLogic
{

    public class BMSProcess
    {
        static string adminpassword = "admin";

        public static bool ValidateAdmin(string password)
        {
            return password == adminpassword;
        }





    }
}
