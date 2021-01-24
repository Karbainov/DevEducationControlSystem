CREATE TABLE [dbo].[Course_Material] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [CourseId]   INT NOT NULL,
    [MaterialId] INT NOT NULL,
    CONSTRAINT [PK_Course_Material] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Course_Material_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id]),
    CONSTRAINT [FK_Course_Material_Material] FOREIGN KEY ([MaterialId]) REFERENCES [dbo].[Material] ([Id])
);

