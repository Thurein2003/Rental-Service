using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalService
{
    static class GlobalData
    {
        private static string _username = "";
        private static int _userid = 0;
        public static string _Username
        {
            get { return _username; }
            
            set { _username = value; }
        }

        public static int _UserId
        {
            get { return _userid; }

            set { _userid = value; }
        }
    }
}
