CREATE TABLE [Payment] (
	ID int NOT NULL,
	UserID int NOT NULL,
	GroupID int NOT NULL,
	Period int NOT NULL,
	isPaid bit NOT NULL,
	Sum int NOT NULL,
	PayDate date NOT NULL,
  CONSTRAINT [PK_PAYMENT] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)