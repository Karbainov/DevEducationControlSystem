using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class UnlockedMaterialsWithTagsByUserIdAndTagDTO
    {
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string Message { get; set; }
        public string Links { get; set; }
        public string Images { get; set; }
        public List<string> TagName { get; set; }
    }
}