/*
	EXEC [dbo].[Get_Autor] @IdAutor=NULL,@Nombres=NULL,@Apellidos=NULL
*/


CREATE PROCEDURE [dbo].[Get_Autor]
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