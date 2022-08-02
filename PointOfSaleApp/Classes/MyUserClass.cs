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
        private static string address;
        private static string phone;
        private static int role_id;
        private static string role;
        private static bool isActive;


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

        public static string userAddress 
        {
            get { return address; }
            set { address = value; }
        }
        public static string userPhone 
        {
            get { return phone; }
            set { phone = value; }
        }

        static public Image loadUserImage()
        {
            byte[] getImage = new byte[0];
            int myUserId = MyUserClass.userId;
            string query = "select image from [User] where id = " + myUserId;
            SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandType = CommandType.Text;
            DataSet set = new DataSet();
            adapter.Fill(set);
            foreach (DataRow dr in set.Tables[0].Rows)
            {
                if (!dr["image"].Equals(System.DBNull.Value))
                    getImage = (byte[])dr["image"];
                else
                    continue;
            }
            if (getImage != null && getImage.Length > 0)
            {
                byte[] imageData = getImage;
                MemoryStream memoryStream = new MemoryStream(imageData);
                return Image.FromStream(memoryStream);
            }
            else
            {
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                return Image.FromFile(projectDirectory + "/PointOfSaleApp/Resources/profile.png");
            }
        }

        internal static void ClearMyUser()
        {
            userId = 0;
            userLogin = string.Empty;
            userPassword = string.Empty;
            userFullName = string.Empty;
            userAddress = string.Empty;
            userPhone = string.Empty;
            userRoleId = 0;
            userRole = string.Empty;
            userIsActive = false;
        }
    }
}
