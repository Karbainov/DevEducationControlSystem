CREATE TABLE [dbo].[Group_Homework] (
    [Id]         INT  IDENTITY (1, 1) NOT NULL,
    [GroupId]    INT  NOT NULL,
    [HomeworkId] INT  NOT NULL,
    [StartDate]  DATE NOT NULL,
    [DeadLine]   DATE NULL,
    CONSTRAINT [PK_Group_Homework] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Group_Homework_Group] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Group] ([Id]),
    CONSTRAINT [FK_Group_Homework_Homework] FOREIGN KEY ([HomeworkId]) REFERENCES [dbo].[Homework] ([Id])
);

