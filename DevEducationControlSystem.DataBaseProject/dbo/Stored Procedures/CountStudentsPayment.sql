CREATE PROCEDURE [dbo].[CountStudentsPayment]
  AS
  BEGIN
  SELECT
  [Group].[Name] AS GroupName, [Group].StartDate,
  Course.DurationInWeeks,
  [User].Id AS UserId, FirstName, LastName, email, Phone, ContractNumber,
  Payment.Id AS PaymentId, UserId, [Period] AS PeriodNumber,  isPaid, [Sum], PayDate
  FROM  Payment
  JOIN
  [User] ON [User].Id = Payment.UserId
  JOIN
  [Group] ON [Group].Id = Payment.GroupId
  JOIN
  Course ON Course.Id = [Group].CourseId
  END