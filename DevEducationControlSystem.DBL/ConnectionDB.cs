using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DevEducationControlSystem.DBL
{
    public class ConnectionDB
    {
        private string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
        private SqlConnection _connection;

        public SqlConnection GetConnection()
        {
            _connection = new SqlConnection(connectionString);
            return _connection;
        }
    }
}
