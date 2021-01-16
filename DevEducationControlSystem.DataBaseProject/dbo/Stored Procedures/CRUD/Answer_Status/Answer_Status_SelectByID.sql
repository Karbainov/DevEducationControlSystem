CREATE PROCEDURE [dbo].[AnswerStatus_SelectById]
    @Id int
    As
    SELECT * FROM [dbo].[AnswerStatus] WHERE [dbo].[AnswerStatus].Id = @Id