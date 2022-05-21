using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp
{
    static public class MyUserClass
    {
        private static int id;
        private static string login;
        private static string role;

        public static int userId
        {
            get { return id; }
            set { id = value; }
        }

        public static string userLogin
        {
            get { return login; }
            set { login = value; }
        }

        public static string userRole
        {
            get { return role; }
            set { role = value; }
        }
    }
}
