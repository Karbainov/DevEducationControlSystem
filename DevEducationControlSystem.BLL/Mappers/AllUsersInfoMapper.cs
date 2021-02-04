using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class AllUsersInfoMapper
    {
        public List<AllInfoOfUserModel> Map(List<AllInfoOfUserDTO> allInfoOfUser)
        {
            var allInfoOfUserModel = new List<AllInfoOfUserModel>();

            for(int i = 0; i< allInfoOfUser.Count;i++)
            {
                allInfoOfUserModel[i].Id = allInfoOfUser[i].Id;
                allInfoOfUserModel[i].FirstName = allInfoOfUser[i].FirstName;
                allInfoOfUserModel[i].LastName = allInfoOfUser[i].LastName;
                allInfoOfUserModel[i].BirthDate = allInfoOfUser[i].BirthDate;
                allInfoOfUserModel[i].Login = allInfoOfUser[i].Login;
                allInfoOfUserModel[i].Password = allInfoOfUser[i].Password;
                allInfoOfUserModel[i].Email = allInfoOfUser[i].Email;
                allInfoOfUserModel[i].Phone = allInfoOfUser[i].Phone;
                allInfoOfUserModel[i].ContractNumber = allInfoOfUser[i].ContractNumber;
                allInfoOfUserModel[i].ProfileImage = allInfoOfUser[i].ProfileImage;
                allInfoOfUserModel[i].StatusId = allInfoOfUser[i].StatusId;
                allInfoOfUserModel[i].Status = allInfoOfUser[i].Status;
                allInfoOfUserModel[i].Roles = allInfoOfUser[i].Roles;
                allInfoOfUserModel[i].Groups = allInfoOfUser[i].Groups;
                allInfoOfUserModel[i].Courses = allInfoOfUser[i].Courses;
            }
            return allInfoOfUserModel;
        }
    }
}
