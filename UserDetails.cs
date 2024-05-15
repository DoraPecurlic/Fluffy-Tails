using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsni_rad
{
    public class UserDetails
    {
        private static string _username;
        private static int _userID;
        public static string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public static int UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }

    }
}
