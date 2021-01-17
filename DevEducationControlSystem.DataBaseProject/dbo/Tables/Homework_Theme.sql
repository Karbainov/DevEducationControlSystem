CREATE TABLE [dbo].[Homework_Theme] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [HomeworkId] INT NOT NULL,
    [ThemeId]    INT NOT NULL,
    CONSTRAINT [PK_Homework_Theme] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Homework_Theme_Homework] FOREIGN KEY ([HomeworkId]) REFERENCES [dbo].[Homework] ([Id]),
    CONSTRAINT [FK_Homework_Theme_Theme] FOREIGN KEY ([ThemeId]) REFERENCES [dbo].[Theme] ([Id])
);

