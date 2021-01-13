CREATE procedure [dbo].[Material_SoftDelete]
@IsDeleted bit,
@Id int
as
update Material
set IsDeleted = @IsDeleted
where ID = @Id
