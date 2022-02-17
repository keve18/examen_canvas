/*
	EXEC [dbo].[Del_Autor] @IdAutor='1'
*/


CREATE PROCEDURE [dbo].[Del_Autor]
@IdAutor INT
AS
BEGIN
	DELETE Autor WHERE IdAutor=@IdAutor
END