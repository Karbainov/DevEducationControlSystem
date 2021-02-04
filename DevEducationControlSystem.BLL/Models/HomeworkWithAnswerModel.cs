using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class HomeworkWithAnswerModel
    {
        public int HomeworkId { get; set; }
        public int AnswerId { get; set; }
        public int? HWResourceId { get; set; }
        public string HWName { get; set; }
        public string HWDescript { get; set; }
        public int AnswerResourceId { get; set; }
        public string AnswerMessage { get; set; }
        public string AnswerStatus { get; set; }
    }
}
