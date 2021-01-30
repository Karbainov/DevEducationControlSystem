Create Procedure [dbo].[CountStudentsTeachersTutorsByGroup]
  AS
  BEGIN
  SELECT
  Part1.GroupId,
  Part1.GroupName,
  Part1.Student,
  Part2.Teacher,
  Part3.Tutor 
FROM
(
  SELECT
    [User_Group].[GroupId] AS GroupId, 
    [Group].[Name] AS GroupName,
    COUNT (User_Group.UserId) AS Student

    FROM [User_Group]

    JOIN [Group] ON [User_Group].GroupId = [Group].Id
    JOIN [User_Role] ON [User_Role].UserId = [User_Group].UserId AND RoleId=2

    GROUP BY [User_Group].[GroupId], [Group].[Name]
) AS Part1
LEFT JOIN
(
  SELECT
    [User_Group].[GroupId] AS GroupId, 
    [Group].[Name] AS GroupName,
    COUNT (User_Group.UserId) AS Teacher

    FROM [User_Group]

    JOIN [Group] ON [User_Group].GroupId = [Group].Id
    JOIN [User_Role] ON [User_Role].UserId = [User_Group].UserId AND RoleId=1

    GROUP BY [User_Group].[GroupId], [Group].[Name]
) AS Part2
ON
Part1.GroupId=Part2.GroupId
LEFT JOIN
(
  SELECT
    [User_Group].[GroupId] AS GroupId, 
    [Group].[Name] AS GroupName,
    COUNT (User_Group.UserId) AS Tutor

    FROM [User_Group]

    JOIN [Group] ON [User_Group].GroupId = [Group].Id
    JOIN [User_Role] ON [User_Role].UserId = [User_Group].UserId AND RoleId=5

    GROUP BY [User_Group].[GroupId], [Group].[Name]
) AS Part3
ON
Part1.GroupId=Part3.GroupId

END