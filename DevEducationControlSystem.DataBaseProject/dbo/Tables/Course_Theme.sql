CREATE TABLE [dbo].[Course_Theme] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [CourseId] INT NOT NULL,
    [ThemeId]  INT NOT NULL,
    CONSTRAINT [PK_Course_Theme] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Course_Theme_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id]),
    CONSTRAINT [FK_Course_Theme_Theme] FOREIGN KEY ([ThemeId]) REFERENCES [dbo].[Theme] ([Id])
);

