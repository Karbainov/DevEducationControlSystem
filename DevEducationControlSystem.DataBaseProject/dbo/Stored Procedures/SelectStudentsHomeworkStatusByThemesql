--CREATE PROCEDURE [dbo].[SelectStudentsHomeworkStatus]
--as
--select

--[Group].Id,
--[Group].name as Groupname,
--City.Id,
--City.name as Cityname,
--Homework.Id, 
--Homework.name  as Homeworkname,
--count(distinct [AnswerStatus].[Id]) as DoneHomework,
--count(distinct [Homework].IsSolutionRequired) as NotDoneHomework,
--count(distinct [AnswerStatus].[id]) as DoneHomeworkOnTime,
--count(distinct [AnswerStatus].[id]) as LateDoneHomework

--from [Group]
--left join City on ([Group].CityId=city.id)
--left join Group_Homework on ([Group].id = Group_Homework.GroupId)
--left join Homework on (Group_Homework.HomeworkId = Homework.Id)
--left join Answer on (Homework.Id = Answer.HomeworkId)
--left join AnswerStatus on (Answer.StatusId = AnswerStatus.Id)

--WHERE [AnswerStatus].[id]= 5 or [AnswerStatus].[id] = 6 and  [Homework].IsSolutionRequired = false and [AnswerStatus].[id] = 5 and [AnswerStatus].[id] = 6
