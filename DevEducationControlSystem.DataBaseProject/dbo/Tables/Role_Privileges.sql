CREATE TABLE [dbo].[Role_Privileges] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [RoleId]       INT NOT NULL,
    [PrivilegesId] INT NOT NULL,
    CONSTRAINT [PK_Role_Privileges] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Role_Privileges_Privileges] FOREIGN KEY ([PrivilegesId]) REFERENCES [dbo].[Privileges] ([Id]),
    CONSTRAINT [FK_Role_Privileges_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([Id])
);

