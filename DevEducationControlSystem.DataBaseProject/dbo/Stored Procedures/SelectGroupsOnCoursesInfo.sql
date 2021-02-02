CREATE PROCEDURE [dbo].[SelectGroupsOnCoursesInfo]
AS
	select cr.id as CoursrId, cr.name as CourseName, 
gr.id as GroupId, gr.name as GroupName, 
gs.id as StatusId, gs.Name as StatusName, 
c.id as CityId, c.name as CityName  
from course cr 
join [Group] gr on cr.id=gr.CourseId 
join city c on gr.cityid=c.id
join GroupStatus gs on gr.StatusId=gs.Id
