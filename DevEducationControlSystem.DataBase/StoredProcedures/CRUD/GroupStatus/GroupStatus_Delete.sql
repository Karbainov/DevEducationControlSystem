CREATE procedure [dbo].[GroupStatus_Delete]
@Id int
as
delete GroupStatus
where ID = @Id