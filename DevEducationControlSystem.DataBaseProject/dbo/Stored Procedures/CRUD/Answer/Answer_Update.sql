CREATE PROCEDURE Answer_Update
	@ID int,
	@UserID int,
	@HomeWorkID int,
    @Date Datetime,
    @Message NVARCHAR(1000),
	@StatusID int
AS
UPDATE Answer 
SET 
UserID = @UserID, 
[HomeWorkID] = @HomeWorkID,
[Date] = @Date,
[Message] = @Message,
StatusID = @StatusID
WHERE Answer.ID = @ID