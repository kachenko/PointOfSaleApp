using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.Classes
{
    static public class SelectedUserClass
    {
        private static int id;
        private static string login;
        private static string password;
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
        public static string userPassword
        {
            get { return password; }
            set { password = value; }
        }
    }
}
