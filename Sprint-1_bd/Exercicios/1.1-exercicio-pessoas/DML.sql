USE Pessoas;
GO

INSERT INTO Pessoas	( Nome)
VALUES				(	'Saulo')
					,(	'Caique');


INSERT INTO Telefones ( IdPessoa, Descricao)
VALUES				  (1,'99999999')
					  ,(1,'88888888')
					  ,(2,'77777777');

INSERT INTO  Email  (Descricao , IdPessoa)
VALUES				('s.santos@email.com' ,1)
					,('c.zaneti@email.com',2);

INSERT INTO CNHS (Descricao , IdPessoa)
VALUES			 ('1324', 1)
				,('4332', 2);