CREATE TABLE [dbo].[Theme_Material]
(
	ID INT CONSTRAINT PK_Theme_Material PRIMARY KEY IDENTITY NOT NULL,
	ThemeID int NOT NULL,
	MaterialID int NOT NULL,
    CONSTRAINT [FK_Theme_Material_Theme] FOREIGN KEY ([ThemeID]) REFERENCES [Tag]([ID]),
	CONSTRAINT [FK_Theme_Material_Material] FOREIGN KEY ([MaterialID]) REFERENCES [Material]([ID]),
)
