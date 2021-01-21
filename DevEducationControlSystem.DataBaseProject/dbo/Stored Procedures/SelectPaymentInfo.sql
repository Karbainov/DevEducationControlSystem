CREATE PROCEDURE [dbo].[SelectPaymentInfo]
	 @UserId nvarchar(15)

AS

BEGIN

   SELECT [Payment].Period, [Payment].IsPaid, [Payment].Sum, [Payment].PayDate, [User].[ContractNumber] FROM Payment
   LEFT JOIN [User] on [User].[Id] = [Payment].[UserId]
   WHERE UserId =@UserId;

END
