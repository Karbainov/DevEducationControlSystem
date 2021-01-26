using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using System.Data;

namespace DevEducationControlSystem.DBL.CRUD
{
  public class CourseManager
  {
    public SqlConnection ConnectToDB()
    {
      string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
      SqlConnection connection = new SqlConnection(connectionString);
      return connection;
    }
    public List<CourseDTO> Select()
    {
      List<CourseDTO> сourses = new List<CourseDTO>();
      SqlConnection connection = ConnectToDB();
      try
      {
        connection.Open();
      }
      catch
      {
        connection.Close();
        throw new Exception("DataBase connection failed");
      }

      string sqlExpression = "Course_Select";
      SqlCommand command = new SqlCommand(sqlExpression, connection);
      command.CommandType = System.Data.CommandType.StoredProcedure;
      try
      {
        using (SqlDataReader reader = command.ExecuteReader())
        {


          if (reader.HasRows)
          {
            while (reader.Read())
            {
              int id = (int)reader["Id"];
              string name = (string)reader["Name"];
              string Description = (string)reader["Description"];
              int DurationInWeeks = (int)reader["DurationInWeeks"];
              bool IsDeleted = (bool)reader["IsDeleted"];
              сourses.Add(new CourseDTO(id, name, Description, DurationInWeeks, IsDeleted));
            }
          }
        }
      }
      finally
      {
        connection.Close();

      }
      return сourses;
    }

    public CourseDTO SelectById(int id)
    {
      CourseDTO course = new CourseDTO();
      SqlConnection connection = ConnectToDB();
      try
      {
        connection.Open();
      }
      catch
      {
        connection.Close();
        throw new Exception("DataBase connection failed");
      }

      string sqlExpression = "Course_SelectById";
      SqlCommand command = new SqlCommand(sqlExpression, connection);
      command.CommandType = System.Data.CommandType.StoredProcedure;

      SqlParameter idParameter = new SqlParameter("@Id", id);
      command.Parameters.Add(idParameter);
      try
      {
        using (SqlDataReader reader = command.ExecuteReader())
        {


          if (reader.HasRows)
          {
            while (reader.Read())
            {
              int courseid = (int)reader["Id"];
              string name = (string)reader["Name"];
              string Description = (string)reader["Description"];
              int DurationInWeeks = (int)reader["DurationInWeeks"];
              bool IsDeleted = (bool)reader["IsDeleted"];
              course = new CourseDTO(courseid, name, Description, DurationInWeeks, IsDeleted);
            }
          }
        }
      }
      finally
      {
        connection.Close();
      }
      return course;
    }

    public void Add(string name, string description, int durationInWeeks, bool isDeleted)
    {
      string expr = "[Course_Add]";
      var value = new { Name = name, Description = description, DurationInWeeks = durationInWeeks, IsDeleted = isDeleted };

      using (var connection = ConnectToDB())
      {
        connection.Query(expr, value, commandType: CommandType.StoredProcedure);
      }
    }

    public void Delete(int id)
    {
      string expr = "[Course_Delete]";
      var value = new { Id = id };

      using (var connection = ConnectToDB())
      {
        connection.Query(expr, value, commandType: CommandType.StoredProcedure);
      }
    }

    public void Update(int id, string name, string description, int durationInWeeks, bool isDeleted)
    {
      string expr = "[Course_Update]";
      var value = new { Id = id, Name = name, Description = description, DurationInWeeks = durationInWeeks, IsDeleted = isDeleted };

      using (var connection = ConnectToDB())
      {
        connection.Query(expr, value, commandType: CommandType.StoredProcedure);
      }
    }
  }
}
