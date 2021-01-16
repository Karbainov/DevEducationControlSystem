CREATE TABLE [dbo].[Feedback] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [UserId]   INT             NOT NULL,
    [LessonId] INT             NOT NULL,
    [Rate]     INT             NOT NULL,
    [Message]  NVARCHAR (1000) NULL,
    CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Feedback_Lesson] FOREIGN KEY ([LessonId]) REFERENCES [dbo].[Lesson] ([Id]),
    CONSTRAINT [FK_Feedback_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

