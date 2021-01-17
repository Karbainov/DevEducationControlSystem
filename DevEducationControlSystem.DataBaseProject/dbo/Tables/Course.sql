CREATE TABLE [dbo].[Course] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (100)  NOT NULL,
    [Description]     NVARCHAR (1000) NULL,
    [DurationInWeeks] INT             NULL,
    [IsDeleted]       BIT             DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED ([Id] ASC)
);

