using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class GroupDTO
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int CourseId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public GroupDTO()
        {

        }

        public GroupDTO(int id,
            int statusId,
            int courseId,
            int cityId,
            string name,
            DateTime startDate)
        {
            Id = id;
            StatusId = statusId;
            CourseId = courseId;
            CityId = cityId;
            Name = name;
            StartDate = startDate;
        }
    }
}
