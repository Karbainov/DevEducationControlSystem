CREATE PROCEDURE [dbo].[SelectMaterialsByCourse]
	@CourseId int
AS
 select cm.CourseId as CourseID , m.Id as MaterislID, m.Name as MaterialName, m.UserId as UserID, m.ResourceId as ResourceID, r.Links as Links,  r.Images as ImageLinks, m.Message as MaterialMassage, m.IsDeleted as MaterialIsDeleted
 from Material m 
 left join Course_Material cm on m.id=cm.MaterialId 
 left join Resource r on m.ResourceId=r.Id
 where cm.CourseId=@CourseId
