/*
	EXEC [dbo].[Ins_Editorial] @IdEditorial='0',@NomEditorial='prueba 1'
*/


CREATE PROCEDURE [dbo].[Ins_Editorial]
@IdEditorial INT,
@NomEditorial NVARCHAR(50)
AS
BEGIN
	IF(@IdEditorial = 0)
	BEGIN
		INSERT INTO Editorial(NomEditorial) VALUES(UPPER(@NomEditorial))
	END
	ELSE
		UPDATE Editorial SET NomEditorial=@NomEditorial WHERE IdEditorial=@IdEditorial
END