using BSM_DataService;
using BSM_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSM_BusinessDataLogic
{
    
    public class BSMService
    {

        static string adminpassword = "admin";

        public static bool ValidateAdmin(string password)
        {
            return password == adminpassword;
        }

        public static bool IsValidIndex(string input, int count, out int index)
        {
            index = -1;

            
                index = Convert.ToInt32(input);
                if (index < 0 || index >= count)
                {
                    return false;
                }
                return true;
            }
            

    }
}
