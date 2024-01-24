using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jetwings
{
    internal class GetUserName
    {
        static string UserName;
        public static string username
        {
           get
           {
           return UserName;
           }

            
           set
            {
              UserName = value;
            }
        }
    }
}
