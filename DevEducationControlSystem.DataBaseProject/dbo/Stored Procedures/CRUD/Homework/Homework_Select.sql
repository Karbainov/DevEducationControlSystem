﻿CREATE PROCEDURE [dbo].[Homework_Select]
	AS
	SELECT	*	FROM dbo.Homework
	where IsDeleted=0