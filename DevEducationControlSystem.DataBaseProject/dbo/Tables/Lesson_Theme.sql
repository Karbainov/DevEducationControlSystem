CREATE TABLE [dbo].[Lesson_Theme] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [LessonId] INT NOT NULL,
    [ThemeId]  INT NOT NULL,
    CONSTRAINT [PK_Lesson_Theme] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Lesson_Theme_Lesson] FOREIGN KEY ([LessonId]) REFERENCES [dbo].[Lesson] ([Id]),
    CONSTRAINT [FK_Lesson_Theme_Theme] FOREIGN KEY ([ThemeId]) REFERENCES [dbo].[Theme] ([Id])
);

