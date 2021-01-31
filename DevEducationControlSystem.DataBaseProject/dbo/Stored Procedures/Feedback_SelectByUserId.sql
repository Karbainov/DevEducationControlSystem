CREATE PROCEDURE Feedback_SelectByUserId
  @UserId INT
  AS
  BEGIN
  SELECT * FROM Feedback WHERE UserId=@UserId
  END