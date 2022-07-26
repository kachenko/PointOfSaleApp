using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.Classes
{
    static class DataBaseConnectionClass
    {

        public static SqlConnection GetConnection()
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["posDBConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(stringConnection);
            return sqlConnection;
        }
    }
}
