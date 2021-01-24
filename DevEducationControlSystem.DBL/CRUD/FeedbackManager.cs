using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO.WholeCourseFeedback;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class FeedbackManager
    {
        string _connectionString;

        public FeedbackManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
        }
    }
}
