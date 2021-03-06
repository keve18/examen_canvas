USE [Examen_Canva]
GO
/****** Object:  StoredProcedure [dbo].[Ins_Libro]    Script Date: 16/02/2022 12:37:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
	EXEC [dbo].[Ins_Libro] @IdLibro='0',@NomLibro='Libro01',@DesLibro='',@IdAutor=1,@IdEditorial=1
*/


ALTER PROCEDURE [dbo].[Ins_Libro]
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