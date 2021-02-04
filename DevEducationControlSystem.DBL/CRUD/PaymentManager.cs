using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;


namespace DevEducationControlSystem.DBL.CRUD
{
    public class PaymentManager
    {
        public List<SelectPaymentInfoDTO> SelectPaymentInfo(int userId)
        {

            List<SelectPaymentInfoDTO> paymentInfoDTOs = new List<SelectPaymentInfoDTO>();
            string expr = "[SelectPaymentInfo]";
            var value = new { UserId = userId };
            using (var connection = SqlServerConnection.GetConnection())
            {
                paymentInfoDTOs = connection.Query<SelectPaymentInfoDTO, StudentPayDTO, SelectPaymentInfoDTO>(expr,
                   (info, period) =>
                   {
                       SelectPaymentInfoDTO paymentInfos = null;
                       foreach (var r in paymentInfoDTOs)
                       {
                          if (r.Id == info.Id)
                           {
                               paymentInfos = r;
                               break;
                           }
                       }
                       if (paymentInfos == null)
                       {
                           paymentInfos = info;
                           paymentInfoDTOs.Add(paymentInfos);
                       }
                       if (paymentInfos.Periods == null)
                       {
                           paymentInfos.Periods = new List<StudentPayDTO>();
                       }
                       paymentInfos.Periods.Add(period);

                       return paymentInfos;
                   },    
                    value,
                    commandType: CommandType.StoredProcedure,
                    splitOn: "Period"
                     ).AsList();
            }
            return paymentInfoDTOs;
        }

        public List<GroupPaymentDTO> GetPaymentDTOs()
        {
            List<GroupPaymentDTO> groupList = null;

            string expr = "[CountStudentsPayment]";
            using (var connection = SqlServerConnection.GetConnection())

            {
                connection.Query<GroupPaymentDTO,
                    UserPaymentDTO, PeriodDTO, GroupPaymentDTO>
                     (expr, (Group, User, Period) =>

                     {
                         if (groupList==null)
                         {
                             groupList = new List<GroupPaymentDTO>();
                         }

                         GroupPaymentDTO tmpGroup = null;
                         UserPaymentDTO tmpStudent = null;
                         

                         foreach (var g in groupList)
                         {
                             if(g.GroupName == Group.GroupName)
                             {
                                 tmpGroup = g;
                                 break;
                             }
                         }

                         if (tmpGroup == null)
                         {
                             tmpGroup = Group;
                             groupList.Add(tmpGroup);
                         }

                         if (tmpGroup.StudentList == null)
                         {
                             tmpGroup.StudentList = new List<UserPaymentDTO>();
                         }

                         foreach (var s in tmpGroup.StudentList)
                         {
                             if (s.FirstName == User.FirstName)
                             {
                                 tmpStudent = s;
                                 break;
                             }
                         }

                         if (tmpStudent == null)
                         {
                             tmpStudent = User;
                             tmpGroup.StudentList.Add(tmpStudent);
                         }

                         if (tmpStudent.Periods == null)
                         {
                             tmpStudent.Periods = new List<PeriodDTO>();
                         }

                         tmpStudent.Periods.Add(Period);

                         return null;
                     },

               commandType: CommandType.StoredProcedure, splitOn: "FirstName,PaymentId");

            }
            return groupList;
        } 
   
    
    }
}
