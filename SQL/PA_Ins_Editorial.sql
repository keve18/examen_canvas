USE [Examen_Canva]
GO
/****** Object:  StoredProcedure [dbo].[Ins_Editorial]    Script Date: 16/02/2022 12:36:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
	EXEC [dbo].[Ins_Editorial] @IdEditorial='0',@NomEditorial='prueba 1'
*/


ALTER PROCEDURE [dbo].[Ins_Editorial]
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