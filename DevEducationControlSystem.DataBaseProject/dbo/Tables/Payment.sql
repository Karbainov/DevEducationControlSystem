CREATE TABLE [dbo].[Payment] (
    [Id]      INT  IDENTITY (1, 1) NOT NULL,
    [UserId]  INT  NOT NULL,
    [GroupId] INT  NOT NULL,
    [Period]  INT  NOT NULL,
    [isPaId]  BIT  NOT NULL,
    [Summ]    INT  NOT NULL,
    [PayDate] DATE NOT NULL,
    CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Payment_Group] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Group] ([Id]),
    CONSTRAINT [FK_Payment_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

