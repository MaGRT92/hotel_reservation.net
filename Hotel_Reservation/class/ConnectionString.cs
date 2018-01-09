using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Hotel_Reservation
{
    static class ConnectionString
    {
        public static string GetConnectionString()
        {
            ConnectionStringSettings theConnectionString = ConfigurationManager.ConnectionStrings["hotel"];
            return theConnectionString.ConnectionString;
        }
    }
}
