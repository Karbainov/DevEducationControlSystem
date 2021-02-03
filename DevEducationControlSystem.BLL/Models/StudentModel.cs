using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
  public class StudentModel
  {
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
  }
}

