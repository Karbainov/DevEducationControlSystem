CREATE TABLE [dbo].[User_Role] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [UserId] INT NOT NULL,
    [RoleId] INT NOT NULL,
    CONSTRAINT [PK_User_Role] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_User_Role_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([Id]),
    CONSTRAINT [FK_User_Role_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

