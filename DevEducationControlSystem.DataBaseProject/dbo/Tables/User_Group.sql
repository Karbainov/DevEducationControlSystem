CREATE TABLE [dbo].[User_Group] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [UserId]  INT NOT NULL,
    [GroupId] INT NOT NULL,
    CONSTRAINT [PK_User_Group] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_User_Group_Group] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Group] ([Id]),
    CONSTRAINT [FK_User_Group_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

