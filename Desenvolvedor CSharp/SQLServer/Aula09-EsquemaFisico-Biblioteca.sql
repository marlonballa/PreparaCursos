-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.

Create  Database BibliotecaAula09
Go

Use BibliotecaAula09
Go

CREATE TABLE Livros (
isbn Int PRIMARY KEY,
tituloLivro nvarchar(100),
dataPublicacaoLivro datetime,
idCategoria Int
)

CREATE TABLE Categorias (
idCategoria Int PRIMARY KEY,
nomeCategoria nvarchar(100)
)

CREATE TABLE Autores (
idAutor Int PRIMARY KEY,
nomeAutor nvarchar(100),
sobrenomeAutor nvarchar(100)
)

CREATE TABLE ListaAutores (
idAutor Int,
isbn Int,
FOREIGN KEY(idAutor) REFERENCES Autores (idAutor) ON UPDATE CASCADE,
FOREIGN KEY(isbn) REFERENCES Livros (isbn) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE Usuarios (
idUsuario Int PRIMARY KEY,
nomeUsuario nvarchar(100),
telefoneUsuario nchar(16),
emailUsuario nvarchar(100)
)

CREATE TABLE Aluguel (
isbn Int,
idUsuario Int,
idAluguel Int PRIMARY KEY,
dataLocacao datetime,
dataDevolucaoPrevista datetime,
dataDevolucaoReal datetime,
FOREIGN KEY(isbn) REFERENCES Livros (isbn) ON UPDATE CASCADE,
FOREIGN KEY(idUsuario) REFERENCES Usuarios (idUsuario) ON UPDATE CASCADE
)

ALTER TABLE Livros ADD FOREIGN KEY(idCategoria) REFERENCES Categorias (idCategoria) ON UPDATE CASCADE
