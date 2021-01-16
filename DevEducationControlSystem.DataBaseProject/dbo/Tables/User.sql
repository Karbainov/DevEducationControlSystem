CREATE TABLE [dbo].[User] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [StatusId]       INT             NOT NULL,
    [FirstName]      NVARCHAR (100)  NULL,
    [LastName]       NVARCHAR (100)  NULL,
    [BirthDate]      DATE            NULL,
    [Login]          NVARCHAR (100)  NOT NULL,
    [Password]       NVARCHAR (100)  NOT NULL,
    [email]          NVARCHAR (100)  NULL,
    [Phone]          NVARCHAR (20)   NULL,
    [ContractNumber] NVARCHAR (63)   NULL,
    [ProfileImage]   NVARCHAR (1000) NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_User_UserStatus] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[UserStatus] ([Id]),
    UNIQUE NONCLUSTERED ([Login] ASC)
);

