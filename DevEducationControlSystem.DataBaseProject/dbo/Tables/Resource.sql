CREATE TABLE [dbo].[Resource] (
    [Id]     INT             IDENTITY (1, 1) NOT NULL,
    [Links]  NVARCHAR (1000) NULL,
    [Images] NVARCHAR (1000) NULL,
    CONSTRAINT [PK_Resource] PRIMARY KEY CLUSTERED ([Id] ASC)
);

