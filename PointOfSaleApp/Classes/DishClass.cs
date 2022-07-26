using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.Classes
{
    class DishClass
    {
        private static int id;
        private static string name;
        private static string full_name;
        private static double price;
        private static string description;

        public static int dishId
        {
            get { return id; }
            set { id = value; }
        }

        public static string dishName
        {
            get { return name; }
            set { name = value; }
        }

        public static string dishFullName
        {
            get { return full_name; }
            set { full_name = value; }
        }

        public static double dishPrice 
        {
            get { return price; }
            set { price = value; }
        }

        public static string dishDescription 
        {
            get { return description; }
            set { description = value; }
        }
    }
}
