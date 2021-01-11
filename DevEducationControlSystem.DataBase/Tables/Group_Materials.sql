CREATE TABLE [Group_Material] 
(
	ID INT CONSTRAINT PK_Group_Material PRIMARY KEY IDENTITY NOT NULL,
	GroupID int NOT NULL,
	MaterialID int NOT NULL,
	CONSTRAINT [FK_Group_Material_Group] FOREIGN KEY ([GroupID]) REFERENCES [Group]([ID]),
	CONSTRAINT [FK_Group_Material_Material] FOREIGN KEY ([MaterialID]) REFERENCES [Material]([ID])
)
