using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class User_RoleDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public User_RoleDTO()
        {

        }
        public User_RoleDTO(User_RoleDTO dto)
        {
            this.Id = dto.Id;
            this.UserId = dto.UserId;
            this.RoleId = dto.RoleId;
        }
    }
}