USE [Examen_Canva]
GO
/****** Object:  StoredProcedure [dbo].[Get_Editorial]    Script Date: 16/02/2022 12:36:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
	EXEC [dbo].[Get_Editorial] @IdEditorial= NULL, @Nombre= 'PRUEBA 1'
*/


ALTER PROCEDURE [dbo].[Get_Editorial]
@IdEditorial INT = NULL,
@Nombre VARCHAR(50)
AS
BEGIN
	SELECT		*
	FROM		Editorial
	WHERE		(( @IdEditorial IS NOT NULL AND IdEditorial = @IdEditorial ) OR
				( @IdEditorial IS NULL AND IdEditorial IS NOT NULL))
				AND
				(( @Nombre IS NOT NULL AND NomEditorial = @Nombre ) OR
				( @Nombre IS NULL AND NomEditorial IS NOT NULL))
END