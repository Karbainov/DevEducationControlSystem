CREATE TABLE [dbo].[Attendance] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [UserId]    INT NOT NULL,
    [LessonId]  INT NOT NULL,
    [IsPresent] BIT NOT NULL,
    CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Attendance_Lesson] FOREIGN KEY ([LessonId]) REFERENCES [dbo].[Lesson] ([Id]),
    CONSTRAINT [FK_Attendance_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

