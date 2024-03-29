﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.Classes
{
    static public class UserClass
    {
        private static int id = 0;
        private static string login = null;
        private static string full_name = null;
        private static string address = null;
        private static string phone = null;
        private static string role;
        private static bool isActive = true;
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

        public static string userFullName 
        { 
            get => full_name; 
            set => full_name = value; 
        }
        public static string userAddress 
        { 
            get => address; 
            set => address = value; 
        }
        public static string userPhone 
        { 
            get => phone; 
            set => phone = value; 
        }
        public static bool IsActive 
        { 
            get => isActive; 
            set => isActive = value; 
        }

        static public Image loadUserPicture()
        {
            byte[] getImage = new byte[0];
            SqlCommand command1 = new SqlCommand("SELECT image FROM [User] WHERE id = " + UserClass.userId, Classes.DataBaseConnectionClass.GetConnection());
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            command1.CommandType = CommandType.Text;
            DataTable table = new DataTable();
            adapter1.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (row["image"] == DBNull.Value || table == null)
                    break;
                getImage = (byte[])row["image"];
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

        internal static void clearSelectedUser()
        {
            userId = 0;
            userLogin = null;
            userRole = null;
            userFullName = null;
            userAddress = null;
            userPhone = null;
            IsActive = false;
        }
    }
}
