/*
	EXEC [dbo].[Ins_Libro] @IdLibro='0',@NomLibro='Libro01',@DesLibro='',@IdAutor=1,@IdEditorial=1
*/


CREATE PROCEDURE [dbo].[Ins_Libro]
@IdLibro INT,
@NomLibro NVARCHAR(100),
@DesLibro VARCHAR(150),
@IdAutor INT,
@IdEditorial INT
AS
BEGIN
	IF(@IdLibro = 0)
	BEGIN
		INSERT INTO Libro(Nombre_Libro,Desc_Libro,IdAutor,IdEditorial) VALUES(UPPER(@NomLibro),UPPER(@DesLibro),@IdAutor,@IdEditorial)
	END
	ELSE
		UPDATE Libro SET Nombre_Libro=UPPER(@NomLibro),Desc_Libro=UPPER(@DesLibro),IdAutor=@IdAutor,IdEditorial=@IdEditorial WHERE IdLibro=@IdLibro
END