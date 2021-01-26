using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DevEducationControlSystem.DBL
{
    public static class SqlServerConnection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11");
            return connection;
        }
    }
}