CREATE TABLE [dbo].[Answer] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [UserId]     INT             NOT NULL,
    [ResourceId] INT             NULL,
    [HomeworkId] INT             NOT NULL,
    [Date]       DATETIME        NOT NULL,
    [Message]    NVARCHAR (1000) NULL,
    [StatusId]   INT             NOT NULL,
    CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Answer_AnswerStatus] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[AnswerStatus] ([Id]),
    CONSTRAINT [FK_Answer_Homework] FOREIGN KEY ([HomeworkId]) REFERENCES [dbo].[Homework] ([Id]),
    CONSTRAINT [FK_Answer_Resources] FOREIGN KEY ([ResourceId]) REFERENCES [dbo].[Resource] ([Id]),
    CONSTRAINT [FK_Answer_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

