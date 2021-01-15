CREATE TABLE [dbo].[Group_Material] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [GroupId]    INT NOT NULL,
    [MaterialId] INT NOT NULL,
    CONSTRAINT [PK_Group_Material] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Group_Material_Group] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Group] ([Id]),
    CONSTRAINT [FK_Group_Material_Material] FOREIGN KEY ([MaterialId]) REFERENCES [dbo].[Material] ([Id])
);

