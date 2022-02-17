/*
	EXEC [dbo].[Get_Libro] @IdLibro= NULL,@Nombre_Libro=NULL,@Autor=NULL
*/


CREATE PROCEDURE [dbo].[Get_Libro]
@IdLibro INT = NULL,
@Nombre_Libro VARCHAR(100),
@Autor VARCHAR(250)
AS
BEGIN
	SELECT		L.IdLibro,L.Nombre_Libro,L.Desc_Libro,(A.Nombres +' '+A.Apellidos) AS Autor,E.NomEditorial
	FROM		Libro L
	INNER JOIN	Autor A
	ON			A.IdAutor=L.IdAutor
	INNER JOIN	Editorial E
	ON			E.IdEditorial=L.IdEditorial
	WHERE		( @IdLibro IS NOT NULL AND l.IdLibro = @IdLibro ) OR
				( @IdLibro IS NULL AND l.IdLibro IS NOT NULL)
				AND
				( @Nombre_Libro IS NOT NULL AND l.Nombre_Libro = @Nombre_Libro ) OR
				( @Nombre_Libro IS NULL AND l.Nombre_Libro IS NOT NULL)
				AND
				( @Autor IS NOT NULL AND A.Nombres = @Autor ) OR
				( @Autor IS NULL AND A.Nombres IS NOT NULL)
				AND
				( @Autor IS NOT NULL AND A.Apellidos = @Autor ) OR
				( @Autor IS NULL AND A.Apellidos IS NOT NULL)
END