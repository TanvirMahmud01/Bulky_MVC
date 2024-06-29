using System;
using System.Data;
using Microsoft.SqlServer.Management.Smo;

namespace SqlServerInstances
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable servers = SmoApplication.EnumAvailableSqlServers();
            foreach (DataRow server in servers.Rows)
            {
                Console.WriteLine(server["Name"]);
            }
        }
    }
}
