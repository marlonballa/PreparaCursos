-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



CREATE TABLE Funcionario (
idFuncao INTEGER,
nomeFuncionario VARCHAR(100),
idFuncionario INTEGER PRIMARY KEY,
cpfFuncionario VARCHAR(11),
idLogradouro INTEGER,
idInformacoesContato INTEGER
)

CREATE TABLE Estado (
idEstado INTEGER PRIMARY KEY,
nomeEstado VARCHAR(100),
ufEstado VARCHAR(2)
)

CREATE TABLE Logradouro (
idEstado INTEGER,
logradouro VARCHAR(100),
bairroLogradouro VARCHAR(100),
idLogradouro INTEGER PRIMARY KEY,
CEPLogradouro VARCHAR(100),
numeroLogradouro VARCHAR(100),
FOREIGN KEY(idEstado) REFERENCES Estado (idEstado)
)

CREATE TABLE InformacoesContato (
telefoneFixo VARCHAR(100),
telefoneCelular VARCHAR(100),
email VARCHAR(100),
numeroWhatsapp VARCHAR(100),
linkSite VARCHAR(200),
idDDD INTEGER,
idDDI INTEGER,
idInformacoesContato INTEGER PRIMARY KEY
)

CREATE TABLE DDD (
numeroDDD INTEGER,
idDDD INTEGER PRIMARY KEY,
regiaoDDD VARCHAR(100)
)

CREATE TABLE DDI (
numeroDDI INTEGER,
idDDI INTEGER PRIMARY KEY,
regiaoDDI VARCHAR(100)
)

CREATE TABLE Funcao (
idFuncao INTEGER PRIMARY KEY,
nomeFuncao VARCHAR(100),
descricaoFuncao VARCHAR(100)
)

CREATE TABLE Unidade (
idUnidade INTEGER PRIMARY KEY,
idFranqueado INTEGER,
descricaoUnidade VARCHAR(200),
idLogradouro INTEGER,
idInformacoesContato INTEGER,
FOREIGN KEY(idLogradouro) REFERENCES Logradouro (idLogradouro) ON UPDATE CASCADE ON DELETE CASCADE,
FOREIGN KEY(idInformacoesContato) REFERENCES InformacoesContato (idInformacoesContato) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE Franqueado (
idFranqueado INTEGER PRIMARY KEY,
nomeFranqueado VARCHAR(100),
idLogradouro INTEGER,
idInformacoesContato INTEGER,
FOREIGN KEY(idLogradouro) REFERENCES Logradouro (idLogradouro) ON UPDATE CASCADE ON DELETE CASCADE,
FOREIGN KEY(idInformacoesContato) REFERENCES InformacoesContato (idInformacoesContato) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE Fornecedor (
idFornecedor INTEGER PRIMARY KEY,
nomeForncedor VARCHAR(100),
descricaoFornecedor VARCHAR(200),
idLogradouro INTEGER,
idInformacoesContato INTEGER,
FOREIGN KEY(idLogradouro) REFERENCES Logradouro (idLogradouro) ON UPDATE CASCADE ON DELETE CASCADE,
FOREIGN KEY(idInformacoesContato) REFERENCES InformacoesContato (idInformacoesContato) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE Produto (
nomeProduto VARCHAR(100),
descricaoProduto VARCHAR(200),
idProduto INTEGER PRIMARY KEY
)

CREATE TABLE Pedido (
idPedido INTEGER PRIMARY KEY,
idFornecedor INTEGER,
idProduto INTEGER,
idFuncionario INTEGER,
idUnidade INTEGER,
dataSolicitacao DATETIME,
dataAtendimento DATETIME,
FOREIGN KEY(idFornecedor) REFERENCES Fornecedor (idFornecedor) ON UPDATE CASCADE ON DELETE CASCADE,
FOREIGN KEY(idProduto) REFERENCES Produto (idProduto) ON UPDATE CASCADE ON DELETE CASCADE,
FOREIGN KEY(idFuncionario) REFERENCES Funcionario (idFuncionario) ON UPDATE CASCADE ON DELETE CASCADE,
FOREIGN KEY(idUnidade) REFERENCES Unidade (idUnidade) ON UPDATE CASCADE ON DELETE CASCADE
)

ALTER TABLE Funcionario ADD FOREIGN KEY(idFuncao) REFERENCES Funcao (idFuncao)
ALTER TABLE Funcionario ADD FOREIGN KEY(idLogradouro) REFERENCES Logradouro (idLogradouro) ON UPDATE CASCADE ON DELETE CASCADE
ALTER TABLE Funcionario ADD FOREIGN KEY(idInformacoesContato) REFERENCES InformacoesContato (idInformacoesContato) ON UPDATE CASCADE ON DELETE CASCADE
ALTER TABLE InformacoesContato ADD FOREIGN KEY(idDDD) REFERENCES DDD (idDDD) ON UPDATE CASCADE ON DELETE CASCADE
ALTER TABLE InformacoesContato ADD FOREIGN KEY(idDDI) REFERENCES DDI (idDDI) ON UPDATE CASCADE ON DELETE CASCADE
ALTER TABLE Unidade ADD FOREIGN KEY(idFranqueado) REFERENCES Franqueado (idFranqueado)
