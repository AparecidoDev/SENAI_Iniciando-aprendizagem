--DDL

CREATE DATABASE senai_CZBooks
GO

USE senai_CZBooks
GO

CREATE TABLE tipoUsuario
(
	idTipoUsuario			INT PRIMARY KEY IDENTITY
	,tituloTipoUsuario		VARCHAR(200) UNIQUE NOT NULL
);
GO


CREATE TABLE Usuario
(
	IdUsuario			INT PRIMARY KEY IDENTITY
	,IdTipoUsuario		INT FOREIGN KEY REFERENCES tipoUsuario(idTipoUsuario)
	,NomeUsuario		VARCHAR(200) NOT NULL
	,Email				VARCHAR(200) UNIQUE NOT NULL
	,Senha				VARCHAR(200) NOT NULL
);
GO

CREATE TABLE Autor
(
	IdAutor			  INT PRIMARY KEY IDENTITY
	,IdUsuario		  INT FOREIGN KEY REFERENCES Usuario(IdUsuario)
	,DataNascimento   DATE NOT NULL
 );
 GO

 CREATE TABLE Instituicao
 (
	IdInstituicao		INT PRIMARY KEY IDENTITY
	,NomeInstituicao	VARCHAR (200) UNIQUE NOT NULL
 );
 GO

 CREATE TABLE Livro
 (
	IdLivro				INT PRIMARY KEY IDENTITY
	,IdAutor			INT FOREIGN KEY REFERENCES Autor(IdAutor)
	,IdInstituicao		INT FOREIGN KEY REFERENCES Instituicao(IdInstituicao)
	,Titulo				VARCHAR (200) UNIQUE NOT NULL
	,Sinopse			VARCHAR (300) UNIQUE NOT NULL
	,DataPublicacao		DATE NOT NULL
	,Preco				DECIMAL
 );
 GO

 CREATE TABLE CategoriaLivro
 (
	IdCategoriaLivro	INT PRIMARY KEY IDENTITY
	,IdLivro			INT FOREIGN KEY REFERENCES Livro(IdLivro)
	,NomeCategoria		VARCHAR (200) NOT NULL
 );
 GO



