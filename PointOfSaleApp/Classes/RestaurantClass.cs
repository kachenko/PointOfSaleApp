using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.Classes
{
    class RestaurantClass
    {
        private static string name = null;
        private static string address = null;

        public static string Name { get => name; set => name = value; }
        public static string Address { get => address; set => address = value; }
    }
}
