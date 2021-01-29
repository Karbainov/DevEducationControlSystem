CREATE PROCEDURE [dbo].[SelectCourseGeneralInfoByStudentId]
@UserId INT
AS
BEGIN
DECLARE @GroupId INT;
SET @GroupId=(SELECT GroupId FROM User_Group WHERE UserId=@UserId);

SELECT 
Course.Id AS CourseId, Course.[Name] AS CourseName, [Group].StartDate AS CourseStartDate, Course.DurationInWeeks AS DurationInWeeks,
[Group].Id AS GroupId, [Group].[Name] AS GroupName,
C.Id AS TeacherId, C.FirstName AS TeacherFirstName, C.LastName AS TeacherLastName,
A.Id AS TutorId, A.FirstName AS TutorFirstName, A.LastName AS TutorLastName,
B.Id AS StudenId, B.FirstName AS StudentFirstName, B.LastName AS StudenLastName
FROM Course
JOIN [Group] ON Course.Id=[Group].CourseId
JOIN (SELECT * FROM User_Group WHERE User_Group.GroupId=@GroupId) AS D ON D.GroupId=[Group].Id
JOIN 
(SELECT [User].Id, FirstName, LastName, GroupId FROM [User]
	JOIN User_Role ON [User].Id=User_Role.UserId
	JOIN User_Group ON [User].Id=User_Group.UserId
	WHERE [User_Group].GroupId=@GroupId AND User_Role.RoleId=1) AS C ON C.Id=D.UserId
JOIN
(SELECT [User].Id, FirstName, LastName, GroupId FROM [User]
	JOIN User_Role ON [User].Id=User_Role.UserId
	JOIN User_Group ON [User].Id=User_Group.UserId
	WHERE [User_Group].GroupId=@GroupId AND User_Role.RoleId=5) AS A ON C.GroupId=A.GroupId
JOIN
(SELECT [User].Id, FirstName, LastName, GroupId FROM [User]
	JOIN User_Role ON [User].Id=User_Role.UserId
	JOIN User_Group ON [User].Id=User_Group.UserId
	WHERE [User_Group].GroupId=@GroupId AND User_Role.RoleId=2) AS B ON A.GroupId=B.GroupId
END