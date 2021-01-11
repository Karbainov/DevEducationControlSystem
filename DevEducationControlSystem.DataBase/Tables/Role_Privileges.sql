CREATE TABLE [Role_Privileges] 
(
  ID INT CONSTRAINT PK_Role_Privileges PRIMARY KEY IDENTITY NOT NULL,
	RoleID int NOT NULL,
	PrivilegesID int NOT NULL,
  CONSTRAINT [FK_Role_Privileges_Role] FOREIGN KEY ([RoleID]) REFERENCES [Role]([ID]),
  CONSTRAINT [FK_Role_Privileges_Privileges] FOREIGN KEY ([PrivilegesID]) REFERENCES [Privileges]([ID])
)