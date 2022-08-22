using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp
{
    static public class OrderClass
    {
        private static int id;
        private static int table_nr;
        private static DateTime time;
        private static decimal price;
        private static bool isActive;
        private static List<int> dishesId = new List<int>();

        public static int orderId
        {
            get { return id; }
            set { id = value; }
        }
        public static int orderTableNr
        {
            get { return table_nr; }
            set { table_nr = value; }
        }
        public static DateTime orderTime
        {
            get { return time; }
            set { time = value; }
        }

        public static decimal orderPrice
        {
            get { return price; }
            set { price = value; }
        }
        public static bool orderIsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public static List<int> DishesId 
        { 
            get => dishesId; 
            set => dishesId = value; 
        }

        internal static void clearData()
        {
            orderId = 0;
            orderTableNr = 0;
            orderTime = DateTime.Now;
            orderPrice = 0;
            orderIsActive = false;
        }
    }
}
