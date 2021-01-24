CREATE TABLE [dbo].[Theme_Tag] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [ThemeId] INT NOT NULL,
    [TagId]      INT NOT NULL,
    CONSTRAINT [PK_Theme_Tag] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Theme_Tag_Theme] FOREIGN KEY ([ThemeId]) REFERENCES [dbo].[Theme] ([Id]),
    CONSTRAINT [FK_Theme_Tag] FOREIGN KEY ([TagId]) REFERENCES [dbo].[Tag] ([Id])
);

