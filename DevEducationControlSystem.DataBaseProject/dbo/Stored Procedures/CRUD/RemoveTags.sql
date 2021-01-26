CREATE PROCEDURE [dbo].[RemoveTags]
@TagId int
AS
  ALTER TABLE [Theme_Tag]
  ADD CONSTRAINT FK_Theme_TagId
  FOREIGN KEY(TagId)
  REFERENCES [Tag] (id)
  ON DELETE CASCADE;

  delete 
  from [Tag]
  where [Tag].Id = @TagId
