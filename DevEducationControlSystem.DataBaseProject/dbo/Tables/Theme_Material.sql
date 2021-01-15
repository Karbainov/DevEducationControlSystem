CREATE TABLE [dbo].[Theme_Material] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [ThemeId]    INT NOT NULL,
    [MaterialId] INT NOT NULL,
    CONSTRAINT [PK_Theme_Material] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Theme_Material_Material] FOREIGN KEY ([MaterialId]) REFERENCES [dbo].[Material] ([Id]),
    CONSTRAINT [FK_Theme_Material_Theme] FOREIGN KEY ([ThemeId]) REFERENCES [dbo].[Theme] ([Id])
);

