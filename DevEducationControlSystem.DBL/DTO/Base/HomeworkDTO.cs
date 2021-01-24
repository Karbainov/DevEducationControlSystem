using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class HomeworkDTO
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IsDeleted { get; set; }
        public string IsSolutionRequired { get; set; }

        public HomeworkDTO()
        {

        }
        public HomeworkDTO(int Id, int ResourceId, string Name, string Description, string IsDeleted, string IsSolutionRequired)
        {
            this.Id = Id;
            this.ResourceId = ResourceId;
            this.Name = Name;
            this.Description = Description;
            this.Description = Description;
            this.IsDeleted = IsDeleted;
            this.IsSolutionRequired = IsSolutionRequired;
        }
    }
}