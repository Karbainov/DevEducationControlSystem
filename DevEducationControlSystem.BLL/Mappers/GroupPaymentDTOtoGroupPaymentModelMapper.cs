using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.BLL;


namespace DevEducationControlSystem.BLL.Mappers
{
    public class GroupPaymentDTOtoGroupPaymentModelMapper
    {
        public List<GroupPaymentModel> Map(List<GroupPaymentDTO> groupPayments)
        {
            var modelsList = new List<GroupPaymentModel>();
            var tmpDate = DateTime.Now; 
        
            foreach (var r in groupPayments)
            {
                if (r != null)
                {
                    modelsList.Add(new GroupPaymentModel()
                    {
                        Group = r
                    });


                }
            }

            foreach (var m in modelsList )
            {
                m.CountPeriods = m.Group.DurationInWeeks / 4; // делим на 4 недели в месяце, получаем кол-во периодов


                foreach (var s in m.Group.StudentList)
                {


                    if (s.Periods != null)
                    {
                        var lastFactPeriod = s.Periods.Count; // последний период за который есть оплата
                        var diff = m.CountPeriods - lastFactPeriod;  //
                       



                        foreach (var p in s.Periods)
                        {
                            var sum = p.Sum;

                            if ((DateTime.Now > m.Group.StartDate.AddDays(m.Group.DurationInWeeks/m.CountPeriods *7 * p.PeriodNumber)
                                  && p.isPaid == false && sum < Parameters.PaymentForOnePeriod))
                            {
                                p.IsDebt = true;
                            }
                            else
                            {
                                p.IsDebt = false;
                            }
                        }

                        for (int i = 0; i < diff; i++ ) // добавляем пустые периоды
                        {
                            s.Periods.Add(new PeriodDTO()
                            {
                                PaymentId = null,
                                PeriodNumber = lastFactPeriod + i + 1,
                                Sum = 0,
                                IsDebt = null,
                                isPaid = false,
                                UserId = s.Periods[0].UserId,
                                PayDate = null

                            });

                        }
                    }
                    else
                    {
                        for (int i = 0; i < m.CountPeriods; i++) // если не было оплат вообще, то создаем все 4 периода
                        {
                            s.Periods.Add(new PeriodDTO()
                            {
                                PaymentId = null,
                                PeriodNumber = i + 1,
                                Sum = 0,
                                IsDebt = null,
                                isPaid = false,
                                UserId = s.Periods[0].UserId,
                                PayDate = null

                            });

                        }
                    }
                }
            }


            return modelsList;
        }
    }
}
