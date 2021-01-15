CREATE PROCEDURE Answer_Add
	@UserID int,
	@HomeWorkID int,
    @Date Datetime,
    @Message NVARCHAR(1000),
	@StatusID int
AS
INSERT Answer (UserID, [HomeWorkID], [Date], [Message], StatusID)
VALUES(@UserID, @HomeWorkID, @Date, @Message, @StatusID)
