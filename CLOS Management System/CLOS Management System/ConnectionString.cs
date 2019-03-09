using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOS_Management_System
{
    class ConnectionString
    {
        public static string connection { get; set; } = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ProjectB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
