﻿CREATE PROCEDURE Theme_Delete
	@Id int
AS
	DELETE FROM [Theme] WHERE ID=@Id
