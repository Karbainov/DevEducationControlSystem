using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
   public class StudentPaymentInfoMapper
    {
        public StudentPaymentInfoModel Map(UserDTO user, List<SelectPaymentInfoDTO> paymentInfos)
        {
            StudentPaymentInfoModel model = new StudentPaymentInfoModel()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthDate = user.BirthDate,
                Email = user.email,
                Phone = user.Phone,
                ContractNumber = user.ContractNumber,
                ProfileImage = user.ProfileImage,
                Id = user.Id
            };
            model.Periods = new List<PeriodPayModel>();       
            foreach(var p in paymentInfos)
            {
                if(p!=null)
                {
                    foreach (var s in p.Periods)
                    {
                        if (s!=null)
                        model.Periods.Add(new PeriodPayModel(s)); 
                    }
                }
            }
            return model;
        }
    }
}
