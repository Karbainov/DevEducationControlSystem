CREATE TABLE [dbo].[Theme_Material]
(
	ID INT CONSTRAINT PK_Theme_Material PRIMARY KEY IDENTITY NOT NULL,
	ThemeID int NOT NULL,
	MaterialID int NOT NULL,
)
