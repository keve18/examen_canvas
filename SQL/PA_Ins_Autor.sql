USE [Examen_Canva]
GO
/****** Object:  StoredProcedure [dbo].[Ins_Autor]    Script Date: 16/02/2022 12:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
	EXEC [dbo].[Ins_Autor] @IdAutor='0',@Nombres='jose',@Apellidos='perez'
*/


ALTER PROCEDURE [dbo].[Ins_Autor]
@IdAutor INT,
@Nombres NVARCHAR(250),
@Apellidos VARCHAR(250)
AS
BEGIN
	IF(@IdAutor = 0)
	BEGIN
		INSERT INTO Autor(Nombres,Apellidos) VALUES(UPPER(@Nombres),UPPER(@Apellidos))
	END
	ELSE
		UPDATE Autor SET Nombres=UPPER(@Nombres),Apellidos=UPPER(@Apellidos) WHERE IdAutor=@IdAutor
END