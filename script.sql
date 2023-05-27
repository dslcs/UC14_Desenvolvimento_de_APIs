CREATE DATABASE Chapter
GO

USE Chapter
GO

CREATE TABLE Livros
(
	Id int PRIMARY KEY IDENTITY,
	Titutlo VARCHAR(150) NOT NULL,
	QuantidadePaginas int,
	Disponivel bit
)
GO

INSERT INTO Livros 
VALUES ('Titulo1',150,1)
GO
INSERT INTO Livros
VALUES ('Titulo2',50,0)
GO

SELECT * FROM Livros
GO