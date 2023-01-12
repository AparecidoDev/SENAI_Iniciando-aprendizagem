INSERT INTO Clinica(RazaoSocail		,CNPJ						,Endereco		  )
VALUES				('Meu Pimpão'	,'99999999999999'		,'Av. Barão de Limeira, 539');
GO

INSERT INTO TipoPet(Descricao)
VALUES				('Cachorro')
					,('Gato')
GO

INSERT INTO Dono(Nome)
VALUES		('Paulo')
			,('Odierlei')
GO

INSERT INTO Raca (Descricao,IdTipoPet)
VALUES			 (' Poodle	' ,  1   )
				 ,(' Labrador' , 1   )
				 ,(' SRD	' ,  1	 )
				 ,(' Siamês	' ,  2   ) ;
GO

INSERT INTO Pet(  Nome		,DataNascimento ,IdRaca ,IdDono )
VALUES		     ('Junior'	,'10/10/2018'	 ,1		  ,1	)
				,('Loli	 '	,'18/05/2017'	 ,4		  ,1	)
				,('Sammy '	,'16/06/2016'	 ,1		  ,2	);
GO

INSERT INTO Veterinario( Nome		  ,CRMV	   ,IdClinica)
VALUES					 ('Saulo'    ,'432551'	  ,1	 )
						,('Caique'   ,'653655'	  ,1	 );
GO

INSERT INTO Atendimento(Descricao					,DataAtendimento	,IdVeterinario	,IdPet)
VALUES				  ('Restam 10 dias de vida'		  ,'22/01/2019'			,2				,1)
				 	 ,(	'O paciente está ok'		  ,'21/01/2019'			,3				,2)
				     ,('O paciente está ok'			  ,'22/01/2019'			,3				,1);
GO 
																							  