USE SP_Medical_Group;
GO

SELECT * FROM TiposUsuarios;

SELECT * FROM Usuarios;

SELECT * FROM Pacientes;

SELECT * FROM Clinicas;

SELECT * FROM Especialidades;

SELECT * FROM Medicos;

SELECT * FROM Situacoes;

SELECT * FROM Consultas;

-- N?mero de usu?rios
SELECT COUNT(IdUsuario) FROM Usuarios;

-- Usu?rios
SELECT IdUsuario, TU.Titulo AS Tipo, Email FROM Usuarios U
INNER JOIN TiposUsuarios TU
ON U.IdTipoUsuario = TU.IdTipoUsuario;

-- Infoma??es completas de Pacientes
SELECT 
	IdPaciente, 
	Nome, 
	U.Email,
	DATEDIFF(year, DataNascimento, GETDATE()) AS [Idade],
	FORMAT(DataNascimento, 'd', 'pt-bt') AS [Data de Nascimento],
	Telefone,
	RG,
	CPF,
	CEP,
	Endereco
FROM Pacientes P
INNER JOIN Usuarios U
ON P.IdUsuario = U.IdUsuario;

-- Infoma??es completas da Cl?nica
SELECT 
	IdClinica,
	Nome,
	CNPJ,
	RazaoSocial,
	CONVERT(VARCHAR(5), HorarioAbertura, 108) AS [Hor?rio de Abertura],
	CONVERT(VARCHAR(5), HorarioFechamento, 108) AS [Hor?rio de Fechamento],
	Endereco
FROM Clinicas;

-- Infoma??es completas dos M?dicos da Cl?nica
SELECT 
	IdMedico,
	M.Nome,
	U.Email,
	CRM,
	Estado,
	E.Titulo AS Especialidade,
	C.Nome AS [Cl?nica]
FROM Medicos M
INNER JOIN Usuarios U
ON M.IdUsuario = U.IdUsuario
INNER JOIN Clinicas C
ON M.IdClinica = C.IdClinica
INNER JOIN Especialidades E
ON M.IdEspecialidade = E.IdEspecialidade;

-- Consultas de pacientes
SELECT
	IdConsulta,
	P.Nome AS Paciente,
	M.Nome AS [M?dico],
	S.Titulo AS [Situa??o],
	FORMAT(DataAgendamento, 'd', 'pt-bt') AS [Data de Agendamento],
	FORMAT(DataAgendamento, 'hh:mm') AS [Hor?rio],
	Descricao
FROM Consultas C
INNER JOIN Pacientes P
ON C.IdPaciente = P.IdPaciente
INNER JOIN Medicos M
ON C.IdMedico = M.IdMedico
INNER JOIN Situacoes S
ON C.IdSituacao = S.IdSituacao;

-- Quantidade de m?dicos em determinada especialidade
SELECT dbo.QuantidadeDeMedicos('Psiquiatria') AS [Quantidade de M?dicos];

-- Nome e idade de um paciente de acordo com email
EXEC BuscaIdade 'mariana@gmail.com'
