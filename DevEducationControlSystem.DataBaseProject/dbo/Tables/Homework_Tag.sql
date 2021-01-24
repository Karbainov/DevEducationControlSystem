CREATE TABLE [dbo].[Homework_Tag] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [HomeworkId] INT NOT NULL,
    [TagId]      INT NOT NULL,
    CONSTRAINT [PK_Homework_Tag] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Homework_Tag_Course] FOREIGN KEY ([TagId]) REFERENCES [dbo].[Tag] ([Id]),
    CONSTRAINT [FK_Homework_Tag_Homework] FOREIGN KEY ([HomeworkId]) REFERENCES [dbo].[Homework] ([Id])
);

