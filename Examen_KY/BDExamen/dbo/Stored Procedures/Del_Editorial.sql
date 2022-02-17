/*
	EXEC [dbo].[Del_Editorial] @IdEditorial='1'
*/


CREATE PROCEDURE [dbo].[Del_Editorial]
@IdEditorial INT
AS
BEGIN
	DELETE Editorial WHERE IdEditorial=@IdEditorial
END