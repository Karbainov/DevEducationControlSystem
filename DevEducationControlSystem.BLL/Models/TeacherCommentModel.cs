﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
  public class TeacherCommentModel
  {
    public int CommentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CommentMessage { get; set; }
    public DateTime MessageDate { get; set; }
  }
}
