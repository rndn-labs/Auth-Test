using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Auth_Test
{
    class Methods
    {
        public class GlobalVars
        {

           public struct AuthData
            {
                       
                public string login;
                public string pass;
            }
           public static AuthData[] arr = new AuthData[20];
            public static int uid = 0;
        }
    }

}