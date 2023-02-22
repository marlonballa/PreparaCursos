-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



CREATE TABLE Categorias (
idCategoria Int PRIMARY KEY,
nomeCategoria nvarchar(100)
)

CREATE TABLE Livros (
isbn nvarchar(13) PRIMARY KEY,
tituloLivro nvarchar(100),
dataPublicacaoLivro datetime,
idCategoria Int,
FOREIGN KEY(idCategoria) REFERENCES Categorias (idCategoria) ON UPDATE CASCADE
)

CREATE TABLE ListaAutores (
isbn nvarchar(13),
idAutor Int,
FOREIGN KEY(isbn) REFERENCES Livros (isbn) ON UPDATE CASCADE
)

CREATE TABLE Usuarios (
idUsuario Int PRIMARY KEY,
nomeUsuario nvarchar(100),
telefoneUsuario nvarchar(16),
emailUsuario nvarchar(100),
)

CREATE TABLE Autores (
idAutor Int PRIMARY KEY,
nomeAutor nvarchar(100),
sobrenomeAutor nvarchar(100)
)

CREATE TABLE Aluguel (
isbn nvarchar(13),
idUsuario Int,
idAluguel Int PRIMARY KEY,
dataLocacao datetime,
dataDevolucaoPrevista datetime,
dataDevolucaoReal datetime,
FOREIGN KEY(isbn) REFERENCES Livros (isbn) ON UPDATE CASCADE,
FOREIGN KEY(idUsuario) REFERENCES Usuarios (idUsuario) ON UPDATE CASCADE
)

ALTER TABLE ListaAutores ADD FOREIGN KEY(idAutor) REFERENCES Autores (idAutor) ON UPDATE CASCADE

/*Inserindo usuário no banco de dados*/
INSERT INTO Usuarios (idUsuario, nomeUsuario, telefoneUsuario, emailUsuario)
VALUES
(1, 'João Silva', '11 99999-9999', 'joao.silva@email.com'),
(2, 'Maria Rodrigues', '11 88888-8888', 'maria.rodrigues@email.com'),
(3, 'Pedro Souza', '11 77777-7777', 'pedro.souza@email.com'),
(4, 'Ana Oliveira', '11 66666-6666', 'ana.oliveira@email.com'),
(5, 'Lucas Santos', '11 55555-5555', 'lucas.santos@email.com'),
(6, 'Rafael Martins', '11 44444-4444', 'rafael.martins@email.com'),
(7, 'Julia Silva', '11 33333-3333', 'julia.silva@email.com'),
(8, 'Guilherme Souza', '11 22222-2222', 'guilherme.souza@email.com'),
(9, 'Luciana Oliveira', '11 11111-1111', 'luciana.oliveira@email.com'),
(10, 'Fabio Santos', '11 99999-9999', 'fabio.santos@email.com'),
(11, 'Eduardo Rodrigues', '11 88888-8888', 'eduardo.rodrigues@email.com'),
(12, 'Ricardo Souza', '11 77777-7777', 'ricardo.souza@email.com'),
(13, 'Carolina Oliveira', '11 66666-6666', 'carolina.oliveira@email.com'),
(14, 'Andre Santos', '11 55555-5555', 'andre.santos@email.com'),
(15, 'Marcelo Martins', '11 44444-4444', 'marcelo.martins@email.com'),
(16, 'Paula Silva', '11 33333-3333', 'paula.silva@email.com'),
(17, 'Mateus Souza', '11 22222-2222', 'mateus.souza@email.com'),
(18, 'Juliana Oliveira', '11 11111-1111', 'juliana.oliveira@email.com'),
(19, 'Carlos Santos', '11 99999-9999', 'carlos.santos@email.com'),
(20, 'Fernanda Rodrigues', '11 88888-8888', 'fernanda.rodrigues@email.com');

/*Inserindo a lista de Categorias dos Livros*/
INSERT INTO Categorias (idCategoria, nomeCategoria)
VALUES
(1, 'Ficção Científica'),
(2, 'Romance'),
(3, 'Aventura'),
(4, 'Terror'),
(5, 'Comédia'),
(6, 'Drama'),
(7, 'Autoajuda'),
(8, 'Suspense'),
(9, 'História'),
(10, 'Infantojuvenil'),
(11, 'Filosofia'),
(12, 'Ciência'),
(13, 'Arte'),
(14, 'Literatura Estrangeira'),
(15, 'Contos de Fadas'),
(16, 'Mitologia'),
(17, 'Fábulas'),
(18, 'Poesia'),
(19, 'Contos Populares'),
(20, 'Estudos Sociais');

/*Inserindo a lista de Livros*/

INSERT INTO Livros (isbn, tituloLivro, dataPublicacaoLivro, idCategoria)
VALUES
('1234567890123', 'Guerra e Paz', '2010-01-01', 7),
('2345678901234', 'Grandes Esperanças', '2010-02-01', 2),
('3457789012345', 'O Morro dos Ventos Uivantes', '2010-03-01', 2),
('4567890123456', 'O Pequeno Príncipe', '2010-04-01', 10),
('5678901234567', 'O Dispositivo Holden', '2010-05-01', 1),
('6789012345678', 'O Processo', '2010-06-01', 11),
('7890123456789', 'O Jogo da Amarelinha', '2010-07-01', 6),
('8901234567890', '1984', '2010-08-01', 1),
('9012345678901', 'A Montanha Mágica', '2010-09-01', 11),
('0123456789012', 'A Divina Comédia', '2010-10-01', 11),
('1234567890129', 'A Ilíada', '2010-11-01', 16),
('2345678901214', 'A Odisséia', '2010-12-01', 16),
('3456789912345', 'O Código da Vinci', '2011-01-01', 11),
('4567890023456', 'A Arte da Guerra', '2011-02-01', 11),
('5678901231567', 'O Medo da Morte', '2011-03-01', 11),
('6789092345678', 'O Alquimista', '2011-04-01', 7),
('7890123456780', 'As Valkírias', '2011-05-01', 16),
('8901234367890', 'O Poder do Hábito', '2011-06-01', 7),
('9012345078901', 'O Segredo', '2011-07-01', 7),
('0123456789092', 'O Monge e o Executivo', '2011-08-01', 7),
('1234567890128', 'A Mente Subconsciente', '2011-09-01', 7),
('2345678901224', 'O Poder da Ação', '2011-10-01', 7),
('3456789012345', 'A Origem das Espécies', '2011-11-01', 12),
('4567890126456', 'A Descoberta do Universo', '2011-12-01', 12),
('5678901234367', 'As Leis da Natureza', '2012-01-01', 12),
('6789012345478', 'A Evolução do Pensamento', '2012-02-01', 11);

/*Inserindo autores no banco de dados*/

INSERT INTO Autores (idAutor, nomeAutor, sobrenomeAutor)
VALUES 
(1, 'J.K.', 'Rowling'),
(2, 'Stephen', 'King'),
(3, 'George', 'Orwell'),
(4, 'Mark', 'Twain'),
(5, 'Agatha', 'Christie'),
(6, 'Herman', 'Melville'),
(7, 'J.R.R.', 'Tolkien'),
(8, 'Fyodor', 'Dostoevsky'),
(9, 'Lewis', 'Carroll'),
(10, 'William', 'Shakespeare'),
(11, 'Jane', 'Austen'),
(12, 'Isaac', 'Asimov'),
(13, 'Mary', 'Shelley'),
(14, 'John', 'Steinbeck'),
(15, 'Arthur', 'Conan Doyle'),
(16, 'Antoine', 'de Saint-Exupéry'),
(17, 'Jack', 'Kerouac'),
(18, 'Emily', 'Dickinson'),
(19, 'Nora', 'Roberts'),
(20, 'Jack', 'London');

/*Selecionando informações de um banco de dados*/
/*Listando todos os Livros da tabela Livros*/
Select * from Livros

/*Informando uma colunas especifícas no select e informando a forma de organização*/
Select tituloLivro, idCategoria from Livros order by tituloLivro DESC;

/*
Count - Comando de agregação: Sua principal função é a contagem das células na tabela, 
retornando valores inteiros de itens de um determinado campo.
Podemos usar para apresentar a quantidade de funcionários de um determinado setor, ou de livros de uma mesma categoria.
*/
SELECT Count(*)  FROM Livros;

/*Realizando Consultas com Where, para aplicarmos filtros*/
Select tituloLivro from Livros where idCategoria = 7;
SELECT Count(*)  FROM Livros where idCategoria = 7;
SELECT Count(*)  FROM Livros where dataPublicacaoLivro > '2012-01-01';
SELECT Count(*)  FROM Livros where dataPublicacaoLivro < '2012-01-01';
SELECT Count(*)  FROM Livros where dataPublicacaoLivro = '2012-01-01';
SELECT tituloLivro FROM Livros where dataPublicacaoLivro > '2012-01-01';

/*
Método de construção do código para "Junção de Tabelas" 
O código abaixo fornece informações de duas tabelas, isto é
Ele busca na tabela Livros pelo título do Livro e na tabela Categorias pelo nome da Categoria e relaciona essas informações
pela coluna idCategoria
*/
Select Livros.tituloLivro, Categorias.nomeCategoria from Livros, Categorias
Where Livros.idCategoria = Categorias.idCategoria

/*
Podemos agrupar diversos valores em uma consulta, utilizando o comando Group By, que é responsável por agrupar os dados de uma consulta
e mostrar o resultado total de cada registro, separadamente
Produzindo uma linha de resumo único para cada formato

Ex: Em uma loja de artigos esportivos podemos fazer uma consulta para saber quantos tênis temos de determinada marca. 
*/
/*Retorna a quantidade de livros que temos de cada categoria*/
select Categorias.nomeCategoria, count (*) from Livros, Categorias
WHERE Livros.idCategoria = Categorias.idCategoria group by nomeCategoria
