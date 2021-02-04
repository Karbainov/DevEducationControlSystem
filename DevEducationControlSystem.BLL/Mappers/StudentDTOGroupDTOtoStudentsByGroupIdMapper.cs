using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Mappers
{
  public class StudentDTOGroupDTOtoStudentsByGroupIdMapper
  {
    public List<StudentModel> Map(List<StudentDTO> students)
    {
      var resultList = new List<StudentModel>();
      foreach (var dtoModel in students)
      {
        var model = new StudentModel()
        {
          Id = dtoModel.Id,
          FullName = dtoModel.FullName,
          BirthDate = dtoModel.BirthDate,
          Email = dtoModel.Email,
          Login = dtoModel.Login,
          Password = dtoModel.Password,
          Phone = dtoModel.Phone
        };

        resultList.Add(model);
      }
      return resultList;
    }
  }
}
