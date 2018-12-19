CREATE TABLE [dbo].[usuario]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [login] NCHAR(20) NOT NULL, 
    [senha] NCHAR(18) NULL
)
