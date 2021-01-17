CREATE TABLE [dbo].[Group] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [StatusId]  INT            NOT NULL,
    [CourseId]  INT            NOT NULL,
    [CityId]    INT            NOT NULL,
    [Name]      NVARCHAR (100) NOT NULL,
    [StartDate] DATE           NULL,
    CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Group_City] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([Id]),
    CONSTRAINT [FK_Group_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id]),
    CONSTRAINT [FK_Group_GroupStatus] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[GroupStatus] ([Id])
);

