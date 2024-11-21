using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_13
{
    public static class Conection
    {
        public static string ConnectionString { get; set; }

        static Conection()
        {
            ConnectionString = @"Server=DESKTOP-03R7JG5\SQLEXPRESS;Database=northWiiind;Integrated Security=True;TrustServerCertificate=True;";
        }
    }
}
