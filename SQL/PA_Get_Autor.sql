USE [Examen_Canva]
GO
/****** Object:  StoredProcedure [dbo].[Get_Autor]    Script Date: 16/02/2022 12:35:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
	EXEC [dbo].[Get_Autor] @IdAutor=NULL,@Nombres=NULL,@Apellidos=NULL
*/


ALTER PROCEDURE [dbo].[Get_Autor]
@IdAutor INT = NULL,
@Nombres VARCHAR(250),
@Apellidos VARCHAR(250)
AS
BEGIN
	SELECT		*
	FROM		Autor
	WHERE		(( @IdAutor IS NOT NULL AND IdAutor = @IdAutor ) OR
				( @IdAutor IS NULL AND IdAutor IS NOT NULL))
				AND
				(( @Nombres IS NOT NULL AND Nombres = @Nombres ) OR
				( @Nombres IS NULL AND Nombres IS NOT NULL))
				AND
				(( @Apellidos IS NOT NULL AND Apellidos = @Apellidos ) OR
				( @Apellidos IS NULL AND Apellidos IS NOT NULL))
END