CREATE TABLE [dbo].[Material] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [UserId]     INT             NOT NULL,
    [ResourceId] INT             NULL,
    [Name]       NVARCHAR (100)  NOT NULL,
    [Message]    NVARCHAR (1000) NULL,
    [IsDeleted]  BIT             DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Material_Resource] FOREIGN KEY ([ResourceId]) REFERENCES [dbo].[Resource] ([Id]),
    CONSTRAINT [FK_Material_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

