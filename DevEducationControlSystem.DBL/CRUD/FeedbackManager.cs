using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using System.Data.SqlClient;
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

        Dictionary<int, WholeCourseFeedbackDTO>GetFeedbackByCourseId(int courseId)
        {
            Dictionary<int, WholeCourseFeedbackDTO> wholeCourseFeedbackDTOs = null;
            string expression = "[GetWholeCourseFeedback]";
            var parameter = new { CourseId = courseId};
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query<WholeCourseFeedbackDTO, ThemeFromCourseFeedbackDTO, WholeCourseFeedbackDTO>
                    (expression, (wholeCourseFeedback, themeFromCourseFeedback)=>
                    {
                        
                        WholeCourseFeedbackDTO wholeCourseFeedbackDTO;

                        if (wholeCourseFeedbackDTOs.TryGetValue(wholeCourseFeedback.UserId, out wholeCourseFeedbackDTO)) ;
                        {
                            wholeCourseFeedbackDTO = wholeCourseFeedback;
                            wholeCourseFeedbackDTOs.Add(wholeCourseFeedback.UserId, wholeCourseFeedbackDTO);
                        }

                        return wholeCourseFeedbackDTO;
                    }, 
                    parameter, commandType: CommandType.StoredProcedure, splitOn: "ThemeId");
            }
            return wholeCourseFeedbackDTOs;
        }
    }
}
