CREATE TABLE [dbo].[Material_Tag] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [MaterialId] INT NOT NULL,
    [TagId]      INT NOT NULL,
    CONSTRAINT [PK_Material_Tag] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Material_Material] FOREIGN KEY ([MaterialId]) REFERENCES [dbo].[Material] ([Id]),
    CONSTRAINT [FK_Material_Tag_Tag] FOREIGN KEY ([TagId]) REFERENCES [dbo].[Tag] ([Id])
);

