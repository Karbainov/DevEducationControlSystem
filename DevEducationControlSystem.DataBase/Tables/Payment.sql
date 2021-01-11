CREATE TABLE [Payment] 
(
	ID INT CONSTRAINT PK_Payment PRIMARY KEY IDENTITY NOT NULL,
	UserID int NOT NULL,
	GroupID int NOT NULL,
	Period int NOT NULL,
	isPaid bit NOT NULL,
	Summ int NOT NULL,
	PayDate date NOT NULL,
	CONSTRAINT [FK_Payment_User] FOREIGN KEY ([UserID]) REFERENCES [User]([ID]),
	CONSTRAINT [FK_Payment_Group] FOREIGN KEY ([GroupID]) REFERENCES [Group]([ID])
)
