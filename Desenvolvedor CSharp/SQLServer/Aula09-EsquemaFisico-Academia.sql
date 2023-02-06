-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.

CREATE DATABASE AcademiaAula09
Go

Use AcademiaAula09
Go

CREATE TABLE Estado (
idEstado Int PRIMARY KEY,
nomeEstado nvarchar(60),
UF nvarchar(2)
)

CREATE TABLE Cidades (
idCidade Int PRIMARY KEY,
nomeCidade nvarchar(60),
idEstado Int,
FOREIGN KEY(idEstado) REFERENCES Estado (idEstado) ON UPDATE CASCADE
)

CREATE TABLE Aluno (
idAluno Int PRIMARY KEY,
nomeAluno nvarchar(60),
nascimentoAluno datetime,
enderecoAluno nvarchar(100),
numeroCasaAluno nvarchar(5),
telefoneAluno nvarchar(16),
bairroAluno nvarchar(40),
idCidade Int,
FOREIGN KEY(idCidade) REFERENCES Cidades (idCidade) ON UPDATE CASCADE
)

CREATE TABLE Turma (
idTurma Int PRIMARY KEY,
qtdVagas Int,
nomeTurma nvarchar(40)
)

CREATE TABLE Matrícula (
idTurma Int,
idAluno Int,
idMatricula Int PRIMARY KEY,
situacaoMatricula Int,
FOREIGN KEY(idTurma) REFERENCES Turma (idTurma) ON UPDATE CASCADE ON DELETE CASCADE,
FOREIGN KEY(idAluno) REFERENCES Aluno (idAluno) ON UPDATE CASCADE ON DELETE CASCADE
)

