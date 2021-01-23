using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class User_GroupDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }

        public User_GroupDTO()
        {

        }

        public User_GroupDTO(int id, int userId, int courseId)
        {
            Id = id;
            UserId = userId;
            CourseId = courseId;
        }

    }

}
