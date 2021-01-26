CREATE PROCEDURE [dbo].[RemoveTags]
	@TagId int
AS
  alter table [Theme_Tag]
  ADD CONSTRAINT FK_TagId
  FOREIGN KEY(TagId)
  REFERENCES [Tag] (id)
  on delete cascade;
   
   delete 
  from [Tag]
  where [Tag].Id = @TagId