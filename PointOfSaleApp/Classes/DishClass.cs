using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.Classes
{
    class DishClass
    {
        private static int id = 0;
        private static string name = null;
        private static string full_name = null;
        private static double price = 0.0;
        private static string description = null;

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

        public static void clearDish()
        {
            dishId = 0;
            dishName = null;
            dishFullName = null;
            dishPrice = 0.0;
            description = null;
        }
    }
}
