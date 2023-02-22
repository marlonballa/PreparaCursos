-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.

CREATE DATABASE LocadoraVeiculos_Aula10
GO

Use LocadoraVeiculos_Aula10
Go

CREATE TABLE Funcionarios (
idFuncionario Int PRIMARY KEY,
nomeFuncionario nvarchar(100)
)

CREATE TABLE Estado (
idEstado Int PRIMARY KEY,
nomeEstado nvarchar(100)
)

CREATE TABLE Cidade (
idCidade Int PRIMARY KEY,
nomeCidade nvarchar(100),
idEstado Int,
FOREIGN KEY(idEstado) REFERENCES Estado (idEstado) ON UPDATE CASCADE
)

CREATE TABLE Clientes (
idCliente Int PRIMARY KEY,
nomeCliente nvarchar(100),
cpfCliente nvarchar(14),
telefoneCliente nvarchar(16),
numeroCasaCliente nvarchar(4),
enderecoCliente nvarchar(100),
idCidade Int,
FOREIGN KEY(idCidade) REFERENCES Cidade (idCidade) ON UPDATE CASCADE
)

CREATE TABLE Carros (
idCarro Int PRIMARY KEY,
quilometragemAtual Int,
idModeloCarro Int
)

CREATE TABLE Fabricante (
idFabricante Int PRIMARY KEY,
nomeFabricante nvarchar(100)
)

CREATE TABLE Modelo (
nomeModelo nvarchar(100),
idModeloCarro Int PRIMARY KEY,
idVersao Int,
idFabricante Int,
FOREIGN KEY(idFabricante) REFERENCES Fabricante (idFabricante) ON UPDATE CASCADE
)

CREATE TABLE Versao (
idVersao Int PRIMARY KEY,
nomeVersaoModelo nvarchar(100)
)

CREATE TABLE Aluguel (
idCliente Int,
idCarro Int,
idFuncionario Int,
idAluguel Int PRIMARY KEY,
dataRetirada datetime,
dataDevolucao datetime,
FOREIGN KEY(idCliente) REFERENCES Clientes (idCliente) ON UPDATE CASCADE,
FOREIGN KEY(idCarro) REFERENCES Carros (idCarro) ON UPDATE CASCADE,
FOREIGN KEY(idFuncionario) REFERENCES Funcionarios (idFuncionario) ON UPDATE CASCADE
)

ALTER TABLE Carros ADD FOREIGN KEY(idModeloCarro) REFERENCES Modelo (idModeloCarro) ON UPDATE CASCADE
ALTER TABLE Modelo ADD FOREIGN KEY(idVersao) REFERENCES Versao (idVersao) ON UPDATE CASCADE
