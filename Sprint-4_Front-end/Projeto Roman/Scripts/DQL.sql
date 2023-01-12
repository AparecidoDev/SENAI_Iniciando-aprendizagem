--DQL

USE Roman
--Tudo sobre Tipos de Usuarios
SELECT * FROM TipoUsuario

--Tudo sobre Usuarios
SELECT * FROM Usuario

--Tudo sobre Usuários com suas equipes
SELECT *FROM Usuario 
INNER JOIN Equipe 
ON Usuario.IdEquipe = Equipe.IdEquipe

--Tudo sobre Equipes
SELECT * FROM Equipe

--Tudo sobre Temas
SELECT * FROM Tema

--Tudo sobre Projetos
SELECT *FROM Projeto

--Tudo sobre com seu temas
SELECT NomeProjeto,NomeTema,Descricao FROM Projeto
INNER JOIN Tema
ON Projeto.IdTema = Tema.IdTema
