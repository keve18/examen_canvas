USE [Examen_Canva]
GO
/****** Object:  StoredProcedure [dbo].[Del_Editorial]    Script Date: 16/02/2022 12:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
	EXEC [dbo].[Del_Editorial] @IdEditorial='1'
*/


ALTER PROCEDURE [dbo].[Del_Editorial]
@IdEditorial INT
AS
BEGIN
	DELETE Editorial WHERE IdEditorial=@IdEditorial
END