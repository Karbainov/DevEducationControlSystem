CREATE PROCEDURE [dbo].[SelectPaymentInfo]
	 @Login nvarchar(15)

AS
BEGIN

   SELECT [Payment].Period, [Payment].IsPaid, [Payment].Sum, [Payment].PayDate FROM Payment
   WHERE UserId =(SELECT Id From [User] WHERE [User].Login IN (@Login));

END
