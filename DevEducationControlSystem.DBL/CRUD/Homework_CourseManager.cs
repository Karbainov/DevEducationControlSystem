using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;
using Dapper;
using System.Data;

namespace DevEducationControlSystem.DBL.CRUD
{
  public class Homework_CourseManager
  {

    private static SqlConnection GetConnection()
    {
      string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
      SqlConnection connection = new SqlConnection(connectionString);
      return connection;
    }

    public List<Homework_CourseDTO> Select()
    {
      List<Homework_CourseDTO> homeworks_courses = new List<Homework_CourseDTO>();

      SqlConnection connection = GetConnection();

      try
      {
        connection.Open();
      }
      catch
      {
        connection.Close();
        throw new Exception("Connection failed");
      }

      string sqlExpression = "Homework_Course_Select";
      SqlCommand command = new SqlCommand(sqlExpression, connection)
      {
        CommandType = System.Data.CommandType.StoredProcedure
      };

      SqlDataReader reader = command.ExecuteReader();

      if (reader.HasRows) 
      {
        while (reader.Read()) 
        {

          int Id = (int)reader["Id"];
          int HomeworkId = (int)reader["HomeworkId"];
          int CourseId = (int)reader["CourseId"];
          homeworks_courses.Add(new Homework_CourseDTO(Id, HomeworkId, CourseId));
        }
      }

      reader.Close();
      connection.Close();

      return homeworks_courses; 
    }

    public Homework_CourseDTO SelectById(int id)
    {
      Homework_CourseDTO homework_course = new Homework_CourseDTO();

      SqlConnection connection = GetConnection();

      try
      {
        connection.Open();
      }
      catch
      {
        connection.Close();
        throw new Exception("Connection failed");
      }

      string sqlExpression = "Homework_Course_SelectById";
      SqlCommand command = new SqlCommand(sqlExpression, connection)
      {
        CommandType = System.Data.CommandType.StoredProcedure
      };

      SqlParameter idParameter = new SqlParameter("@Id", id);
      command.Parameters.Add(idParameter);

      SqlDataReader reader = command.ExecuteReader();
      if (reader.HasRows) 
      {
        while (reader.Read()) 
        {

          int Id = (int)reader["Id"];
          int HomeworkId = (int)reader["HomeworkId"];
          int CourseId = (int)reader["CourseId"];

          homework_course = new Homework_CourseDTO(Id, HomeworkId, CourseId);
        }
      }
      reader.Close();
      connection.Close();
      return homework_course;
    }

    public void Add(int homeworkId, int courseId)
    {
      string sqlExpression = "[Homework_Course_Add]";
      var values = new { HomeworkId = homeworkId, CourseId = courseId };

      using var connection = new SqlConnection(GetConnection().ConnectionString);
      connection.Query(sqlExpression, values, commandType: CommandType.StoredProcedure);
    }

    public void Delete(int id)
    {
      string sqlExpression = "[Homework_Course_Delete]";
      var values = new { Id = id };

      using var connection = new SqlConnection(GetConnection().ConnectionString);
      connection.Query(sqlExpression, values, commandType: CommandType.StoredProcedure);
    }

    public void Update(int id, int homeworkId, int courseId)
    {
      string sqlExpression = "[Homework_Course_Update]";
      var values = new { Id = id, HomeworkId = homeworkId, CourseId = courseId };

      using var connection = new SqlConnection(GetConnection().ConnectionString);
      connection.Query(sqlExpression, values, commandType: CommandType.StoredProcedure);
    }
  }
}

