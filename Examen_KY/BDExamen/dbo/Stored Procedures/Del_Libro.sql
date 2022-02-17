/*
	EXEC [dbo].[Del_Libro] @IdLibro='1'
*/


CREATE PROCEDURE [dbo].[Del_Libro]
@IdLibro INT
AS
BEGIN
	DELETE Libro WHERE IdLibro=@IdLibro
END