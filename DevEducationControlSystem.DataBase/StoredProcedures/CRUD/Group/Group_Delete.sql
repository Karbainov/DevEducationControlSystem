﻿CREATE PROCEDURE Group_Delete  
	@Id int  
AS  
	DELETE FROM [Group] WHERE ID = @Id