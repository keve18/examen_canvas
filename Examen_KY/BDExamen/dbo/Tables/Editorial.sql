CREATE TABLE [dbo].[Editorial] (
    [IdEditorial]  INT          IDENTITY (1, 1) NOT NULL,
    [NomEditorial] VARCHAR (50) NULL,
    CONSTRAINT [PK_Editorial] PRIMARY KEY CLUSTERED ([IdEditorial] ASC)
);

