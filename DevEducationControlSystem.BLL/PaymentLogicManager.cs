using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL
{
    public class PaymentLogicManager
    {
        public List<GroupPaymentModel> GetGroupPaymentInfo()
        {
          
            var mapper = new GroupPaymentDTOtoGroupPaymentModelMapper();
            return mapper.Map(new PaymentManager().GetPaymentDTOs());
        }
    }
}
