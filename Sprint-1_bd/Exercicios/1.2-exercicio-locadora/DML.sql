--DML
INSERT INTO Empresa(Nome)
VALUES				('Unidas')
					,('Localiza');
GO

INSERT INTO Marca(Nome)
VALUES			('Ford')
				,('GM')
				,('Fiat')
GO

INSERT INTO Cliente  (Nome			,CPF)
VALUES				 ('Saulo'  ,'99999999999999')
					,('caique' ,'88888888888888');
GO

INSERT INTO Modelo ( Descricao,IdMarca)
VALUES				('Fiesta' ,	 1	  )
					,('Onix'  ,  2	  )
					,('Ford'  ,  3	  );
GO 


INSERT INTO Veiculo		(Placa			,IdMarca	,IdEmpresa	,IdModelo)
VALUES					 ('HEL1805'			,1			,1			,1  )
						,('FER1010'			,2			,1			,2  )
						,('POR1978'			,3			,2			,3  )
						,('LEM9876'			,1			,2			,1  );
GO

INSERT INTO Aluguel (IdCliente	,IdVeiculo	,DataInicio		   ,DataFim  )
VALUES				 (1				,1		,'19/01/2019'	,'20/01/2019')
					,(1				,2		,'20/01/2019'	,'21/01/2019')
					,(2				,3		,'21/01/2019'	,'21/01/2019')
					,(2				,2		,'22/01/2019'	,'22/01/2019');															   
GO

