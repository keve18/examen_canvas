CREATE TABLE [dbo].[Autor] (
    [IdAutor]   INT           IDENTITY (1, 1) NOT NULL,
    [Nombres]   VARCHAR (250) NULL,
    [Apellidos] VARCHAR (250) NULL,
    CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED ([IdAutor] ASC)
);

