CREATE TABLE [dbo].[Comment] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [UserId]     INT             NOT NULL,
    [AnswerId]   INT             NOT NULL,
    [ResourceId] INT             NULL,
    [Date]       DATETIME        NOT NULL,
    [Message]    NVARCHAR (1000) NULL,
    CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comment_Answer] FOREIGN KEY ([AnswerId]) REFERENCES [dbo].[Answer] ([Id]),
    CONSTRAINT [FK_Comment_Resources] FOREIGN KEY ([ResourceId]) REFERENCES [dbo].[Resource] ([Id]),
    CONSTRAINT [FK_Comment_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

