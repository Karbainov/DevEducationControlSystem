using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.StatisticsForMethodist
{
  public class CorsesinCityDTO
    {
        public string CourseName { get; set; }

        public List<GroupkandStatusInCourseDTO> GroupkandStatusInCourse { get; set; }
    }
}
