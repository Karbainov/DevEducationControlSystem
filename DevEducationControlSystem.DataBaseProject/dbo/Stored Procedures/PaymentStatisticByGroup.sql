CREATE PROCEDURE [dbo].[PaymentStatisticByGroup]
  AS
  BEGIN

  SELECT
  Part1.GroupId,
  Part1.GroupName,
  Part1.Period1,
  Part2.Period2,
  Part3.Period3,
  Part4.Period4
  FROM
(
  SELECT
    [Payment].[GroupId] AS GroupId, 
    [Group].[Name] AS GroupName,
    COUNT ([Payment].[UserId]) AS Period1
    FROM [Payment]
    JOIN [Group] ON [Payment].GroupId = [Group].Id AND IsPaid=1 AND [Period] = 1
    GROUP BY [Payment].[GroupId], [Group].[Name]
) AS Part1
LEFT JOIN
(
  SELECT
    [Payment].[GroupId] AS GroupId, 
    [Group].[Name] AS GroupName,
    COUNT ([Payment].[UserId]) AS Period2
    FROM [Payment]
    JOIN [Group] ON [Payment].GroupId = [Group].Id AND IsPaid=1 AND [Period] = 2
    GROUP BY [Payment].[GroupId], [Group].[Name]
) AS Part2
ON Part1.GroupId=Part2.GroupId
LEFT JOIN
(
  SELECT
    [Payment].[GroupId] AS GroupId, 
    [Group].[Name] AS GroupName,
    COUNT ([Payment].[UserId]) AS Period3
    FROM [Payment]
    JOIN [Group] ON [Payment].GroupId = [Group].Id AND IsPaid=1 AND [Period] = 3
    GROUP BY [Payment].[GroupId], [Group].[Name]
)AS Part3
ON 
Part1.GroupId=Part3.GroupId
LEFT JOIN
(
  SELECT
    [Payment].[GroupId] AS GroupId, 
    [Group].[Name] AS GroupName,
    COUNT ([Payment].[UserId]) AS Period4
    FROM [Payment]
    JOIN [Group] ON [Payment].GroupId = [Group].Id AND IsPaid=1 AND [Period] = 4
    GROUP BY [Payment].[GroupId], [Group].[Name]
)AS Part4
ON 
Part1.GroupId=Part4.GroupId

END
