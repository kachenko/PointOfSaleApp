using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.Classes
{
    class CategoryClass
    {
        private static int id = 0;
        private static string name = null;
        private static string description = null;

        public static int categoryId
        {
            get { return id; }
            set { id = value; }
        }

        public static string categoryName
        {
            get { return name; }
            set { name = value; }
        }

        public static string categoryDescription
        {
            get { return description; }
            set { description = value; }
        }

        internal static void сlearCategory()
        {
            categoryId = 0;
            categoryName = null;
            categoryDescription = null;
        }
    }
}
