
USE Locadora;

CREATE TABLE Empresa
(
	IdEmpresa INT PRIMARY KEY IDENTITY
	,Nome VARCHAR (200)
);


CREATE TABLE Marca
(
	IdMarca INT PRIMARY KEY IDENTITY
	,Nome VARCHAR (200)
);


CREATE TABLE Cliente
(
	IdCliente INT PRIMARY KEY IDENTITY
	,Nome VARCHAR (200) 
	,CPF CHAR(17)
);


CREATE TABLE Modelo
(
	IdModelo INT PRIMARY KEY IDENTITY
	,IdMarca INT FOREIGN KEY REFERENCES Marca(IdMarca)
	,Descricao VARCHAR(200)
);

CREATE TABLE Veiculo
(
	IdVeiculo  INT PRIMARY KEY IDENTITY 
	,IdEmpresa INT FOREIGN KEY REFERENCES Empresa (IdEmpresa)
	,IdModelo  INT FOREIGN KEY REFERENCES Modelo (IdModelo) 
	,IdMarca   INT FOREIGN KEY REFERENCES Marca (IdMarca)
	,Placa VARCHAR (200)
);


CREATE TABLE Aluguel
(
	IdAluguel INT PRIMARY KEY IDENTITY
	,IdVeiculo INT FOREIGN KEY REFERENCES Veiculo(IdVeiculo)
	,IdCliente INT FOREIGN KEY REFERENCES Cliente(IdCliente)
	,DataInicio DATE
	,DataFim DATE
);




