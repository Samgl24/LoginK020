CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL identity(1,1) PRIMARY KEY,
	Username VARCHAR(50) NOT NULL,
	Password VARCHAR(50) NOT NULL,
	Nombre_Completo VARCHAR(200),
)
