CREATE TABLE [dbo].[Homework] (
    [Id]                 INT             IDENTITY (1, 1) NOT NULL,
    [ResourceId]         INT             NULL,
    [Name]               NVARCHAR (100)  NOT NULL,
    [Description]        NVARCHAR (1000) NULL,
    [IsDeleted]          BIT             DEFAULT ('0') NOT NULL,
    [IsSolutionRequired] BIT             NOT NULL,
    CONSTRAINT [PK_Homework] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Homework_Resources] FOREIGN KEY ([ResourceId]) REFERENCES [dbo].[Resource] ([Id])
);

