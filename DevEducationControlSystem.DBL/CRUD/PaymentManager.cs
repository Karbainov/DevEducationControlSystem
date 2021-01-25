using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class PaymentManager
    {
        public List<SelectPaymentInfoDTO> SelectPaymentInfo(int userId)
        {

            List<SelectPaymentInfoDTO> selectPaymentInfoDTOs;
            string expr = "[SelectPaymentInfo]";
            var value = new { UserId = userId };
            using (var connection = GetConnection())
            {
                selectPaymentInfoDTOs = connection.Query<SelectPaymentInfoDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<SelectPaymentInfoDTO>();
            }
            return selectPaymentInfoDTOs;
        }


        private static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
