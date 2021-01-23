using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class User_GroupDTO
    {
        public int Id;
        public int UserId;
        public int GroupId;

        public User_GroupDTO(int id, int userId, int groupId)
        {
            Id = id;
            UserId = userId;
            GroupId = groupId;
        }
    }
}
