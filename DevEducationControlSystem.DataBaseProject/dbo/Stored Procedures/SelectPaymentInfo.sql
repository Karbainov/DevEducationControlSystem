CREATE PROCEDURE [dbo].[SelectPaymentInfo]
	 @UserId nvarchar(15)

AS

BEGIN

   SELECT [User].Id,[User].[ContractNumber],
   [Payment].Period, [Payment].isPaid, [Payment].Sum, [Payment].PayDate FROM Payment
   LEFT JOIN [User] on [User].[Id] = [Payment].[UserId]
   WHERE UserId =@UserId;

END
