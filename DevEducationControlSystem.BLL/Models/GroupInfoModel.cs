using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class GroupInfoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public int StatusId { get; set; }
        public string Status { get; set; }

        public int CityId { get; set; }
        public string City { get; set; }

        public int CourseId { get; set; }
        public string Course { get; set; }

        public List<HomeworkInfoModel> Homeworks { get; set; }

        public List<MaterialInfoModel> Materials { get; set; }

        public List<UserWithRoleModel> UserWithRoles { get; set; }
    }
}
