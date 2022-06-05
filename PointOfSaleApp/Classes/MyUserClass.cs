using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp
{
    static public class MyUserClass
    {
        private static int id;
        private static string login;
        private static string password;
        private static string full_name;
        private static bool isActive;
        private static int role_id;
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

        public static string userPassword
        {
            get { return password; }
            set { password = value; }
        }
        public static string userFullName
        {
            get { return full_name; }
            set { full_name = value; }
        }
        public static bool userIsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public static int userRoleId
        {
            get { return role_id; }
            set { role_id = value; }
        }

        public static string userRole
        {
            get { return role; }
            set { role = value; }
        }

        static public Image loadUserPicture()
        {
            byte[] getImage = new byte[0];
            SqlCommand command1 = new SqlCommand("select image from [User] where id = " + MyUserClass.userId, new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true"));
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            command1.CommandType = CommandType.Text;
            DataSet set = new DataSet();
            adapter1.Fill(set);
            foreach (DataRow dr in set.Tables[0].Rows)
            {
                getImage = (byte[])dr["image"];
            }
            byte[] imageData = getImage;
            MemoryStream memoryStream = new MemoryStream(imageData);
            return Image.FromStream(memoryStream);
        }
    }
}
