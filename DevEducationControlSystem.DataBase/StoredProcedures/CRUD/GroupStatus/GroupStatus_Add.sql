CREATE procedure [dbo].[GroupStatus_Add]
@Name nvarchar(100)
as
Insert into dbo.GroupStatus
(Name)
values
(@Name)
