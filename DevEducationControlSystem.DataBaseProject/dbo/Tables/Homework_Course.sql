CREATE TABLE [dbo].[Homework_Course] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [HomeworkId] INT NOT NULL,
    [CourseId]   INT NOT NULL,
    CONSTRAINT [PK_Homework_Course] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Homework_Course_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id]),
    CONSTRAINT [FK_Homework_Course_Homework] FOREIGN KEY ([HomeworkId]) REFERENCES [dbo].[Homework] ([Id])
);

