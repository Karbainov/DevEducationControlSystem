CREATE TABLE [dbo].[Material_Tag]
(
	ID INT CONSTRAINT PK_Material_Tag PRIMARY KEY IDENTITY NOT NULL,
	MaterialID int NOT NULL,
	TagID int NOT NULL,
	CONSTRAINT [FK_Material_Material] FOREIGN KEY ([MaterialID]) REFERENCES [Material]([ID]),
    CONSTRAINT [FK_Material_Tag_Tag] FOREIGN KEY ([TagID]) REFERENCES [Tag]([ID]),
)
