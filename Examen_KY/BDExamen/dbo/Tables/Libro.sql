CREATE TABLE [dbo].[Libro] (
    [IdLibro]      INT           IDENTITY (1, 1) NOT NULL,
    [Nombre_Libro] VARCHAR (100) NOT NULL,
    [Desc_Libro]   VARCHAR (150) NULL,
    [IdAutor]      INT           NOT NULL,
    [IdEditorial]  INT           NOT NULL,
    CONSTRAINT [PK_Libro] PRIMARY KEY CLUSTERED ([IdLibro] ASC, [IdAutor] ASC, [IdEditorial] ASC)
);

