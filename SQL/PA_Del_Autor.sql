USE [Examen_Canva]
GO
/****** Object:  StoredProcedure [dbo].[Del_Autor]    Script Date: 16/02/2022 12:37:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
	EXEC [dbo].[Del_Autor] @IdAutor='1'
*/


ALTER PROCEDURE [dbo].[Del_Autor]
@IdAutor INT
AS
BEGIN
	DELETE Autor WHERE IdAutor=@IdAutor
END