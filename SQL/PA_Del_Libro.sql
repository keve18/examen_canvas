USE [Examen_Canva]
GO
/****** Object:  StoredProcedure [dbo].[Del_Libro]    Script Date: 16/02/2022 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
	EXEC [dbo].[Del_Libro] @IdLibro='1'
*/


ALTER PROCEDURE [dbo].[Del_Libro]
@IdLibro INT
AS
BEGIN
	DELETE Libro WHERE IdLibro=@IdLibro
END