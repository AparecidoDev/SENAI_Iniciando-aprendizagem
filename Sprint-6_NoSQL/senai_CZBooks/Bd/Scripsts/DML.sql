--DML

USE senai_CZBooks
GO

INSERT INTO tipoUsuario ( tituloTipoUsuario)
VALUES					('Administrador')
						,('Cliente')
						,('Autor');
GO

INSERT INTO Usuario		(idTipoUsuario,		nomeUsuario,		  email ,			      senha)
VALUES					 (	1,				'Saulo',			  'Saulo@adm.com',       1234)
						,(  1,				'Caique',			  'Caique@adm.com',      1234)
						,(	2,				'Aparecido',		  'Aparecido@email.com', 1234)
						,(	3,				'Suzanne Collins',	  'Suzane@email.com',    1234)
						,(	3,				'J. R. R. Tolkien.',  'Tolkien@email.com',	 1234)
						,(	3,				'Jane Austen',		   'Jane@emal.com',      1234)
						,(	3,				'Stephen King',		   'Stephen@email.com',  1234);
GO

INSERT INTO Autor		(IdUsuario ,   DataNascimento)
VALUES					( 4,			'10/08/1962' )
						,(5,			'03/01/1892' )
						,(6,			'16/12/1775' )
						,(7,			'21/09/1947' );
GO

INSERT INTO		Instituicao (NomeInstituicao)
VALUES						('CZBooks');
GO



INSERT INTO Livro  (IdAutor,  IdInstituicao,  Titulo,						Sinopse,														DataPublicacao,      Preco)
VALUES				( 1,			1,		 'jogos vorazes',				'A jovem Katniss Everdeen, do Distrito 12,',						'14/09/2008',	'35.73')
					,(2,			1,		 'senhor dos aneis',			'O Senhor dos Anéis é um livro de alta fantasia,',					'29/07/1954',	'51.92')
					,(3,			1,		 'Orgulho e preconceito',		'Jane Austen faz também uma crítica feroz à futilidade',			'28/01/1813',	'13.89')
					,(4,			1,		 'O cemiterio ',				'Pet Sematary é um romance de terror escrito por Stephen King',		'14/11/1983',	'30.77');
		
GO