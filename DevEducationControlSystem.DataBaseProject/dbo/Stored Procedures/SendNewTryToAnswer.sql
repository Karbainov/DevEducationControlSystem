CREATE PROCEDURE SendNewTryToAnswer
  
  @HomeworkId int,
  @NewLink nvarchar(1000),
  @NewImages nvarchar(1000)

AS
BEGIN
  UPDATE Answer SET

  Date = GETDATE() 

  WHERE Id = @HomeworkId;

  UPDATE Resource SET

  Links = @NewLink,
  Images = @NewImages

  WHERE Id = (SELECT ResourceId FROM Answer WHERE HomeworkId=@HomeworkId);
END