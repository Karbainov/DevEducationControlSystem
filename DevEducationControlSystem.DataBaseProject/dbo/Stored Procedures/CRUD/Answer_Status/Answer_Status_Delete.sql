CREATE PROCEDURE [dbo].[AnswerStatus_Delete]
    @Id int
    As
    DELETE [dbo].[AnswerStatus] WHERE [dbo].[AnswerStatus].Id = @Id