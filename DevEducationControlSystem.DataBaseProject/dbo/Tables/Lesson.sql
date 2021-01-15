CREATE TABLE [dbo].[Lesson] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [GroupId]    INT             NOT NULL,
    [Name]       NVARCHAR (100)  NULL,
    [LessonDate] DATE            NOT NULL,
    [Comments]   NVARCHAR (1000) NULL,
    CONSTRAINT [PK_Lesson] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Lesson_Group] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Group] ([Id])
);

