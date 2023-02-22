use AcademiaAula09;
Go

/*Estamos acesasndo a tabela Estado, informando as colunas que receber�o informa��es e passando os valores que devem ser inseridos*/
INSERT INTO Estado (idEstado, nomeEstado, UF) VALUES
(1, 'Acre', 'AC'),
(2, 'Alagoas', 'AL'),
(3, 'Amap�', 'AP'),
(4, 'Amazonas', 'AM'),
(5, 'Bahia', 'BA'),
(6, 'Cear�', 'CE'),
(7, 'Distrito Federal', 'DF'),
(8, 'Esp�rito Santo', 'ES'),
(9, 'Goi�s', 'GO'),
(10, 'Maranh�o', 'MA'),
(11, 'Mato Grosso', 'MT'),
(12, 'Mato Grosso do Sul', 'MS'),
(13, 'Minas Gerais', 'MG'),
(14, 'Par�', 'PA'),
(15, 'Para�ba', 'PB'),
(16, 'Paran�', 'PR'),
(17, 'Pernambuco', 'PE'),
(18, 'Piau�', 'PI'),
(19, 'Rio de Janeiro', 'RJ'),
(20, 'Rio Grande do Norte', 'RN'),
(21, 'Rio Grande do Sul', 'RS'),
(22, 'Rond�nia', 'RO'),
(23, 'Roraima', 'RR'),
(24, 'Santa Catarina', 'SC'),
(25, 'S�o Paulo', 'SP'),
(26, 'Sergipe', 'SE'),
(27, 'Tocantins', 'TO');

INSERT INTO Estado (idEstado, nomeEstado, UF) VALUES
(28, 'Estado de Teste e Manipula��o', 'ET')


INSERT INTO Estado (idEstado, nomeEstado, UF) VALUES
(29, 'Estado de Teste e Manipula��o', 'ET')
/*
	Para realizarmos altera��oes em nosso banco de dados, devemos utilizar "UPDATE", onde sua sintaxe b�sica �:
	UPDATE nomeTabela SET coluna = novoValor
*/

Update Estado
Set nomeEstado = 'Estado de Teste: Update' 
Where idEstado = 28;

/*
	Para realizarmos a exclus�o de informa��es de um banco de dados devemos utilizar "Delete", onde sua sintaxe b�sica �:
	Delete FROM nomeTabele Where condi��o
*/

Delete from Estado Where idEstado = 29;

/*Inserindo informa��es na tabela aluno*/

INSERT INTO Cidades (idCidade, nomeCidade, idEstado) VALUES
(1, 'Rio Branco', 1),
(2, 'Cruzeiro do Sul', 1),
(3, 'Senador Guiomard', 1),
(4, 'Macei�', 2),
(5, 'Arapiraca', 2),
(6, 'Palmeira dos �ndios', 2),
(7, 'Macap�', 3),
(8, 'Santana', 3),
(9, 'Laranjal do Jari', 3),
(10, 'Manaus', 4),
(11, 'Iranduba', 4),
(12, 'Manacapuru', 4),
(13, 'Salvador', 5),
(14, 'Feira de Santana', 5),
(15, 'Vit�ria da Conquista', 5),
(16, 'Fortaleza', 6),
(17, 'Caucaia', 6),
(18, 'Juazeiro do Norte', 6),
(19, 'Bras�lia', 7),
(20, 'Taguatinga', 7),
(21, 'Sobradinho', 7),
(22, 'Vit�ria', 8),
(23, 'Cariacica', 8),
(24, 'Serra', 8),
(25, 'Goi�nia', 9),
(26, 'Aparecida de Goi�nia', 9),
(27, 'An�polis', 9),
(28, 'S�o Lu�s', 10),
(29, 'Imperatriz', 10),
(30, 'Timon', 10),
(31, 'Cuiab�', 11),
(32, 'V�rzea Grande', 11),
(33, 'Rondon�polis', 11),
(34, 'Campo Grande', 12),
(35, 'Dourados', 12),
(36, 'Tr�s Lagoas', 12),
(37, 'Belo Horizonte', 13),
(38, 'Contagem', 13),
(39, 'Uberl�ndia', 13),
(40, 'Bel�m', 14),
(41, 'Ananindeua', 14),
(42, 'Santar�m', 14),
(43, 'Jo�o Pessoa', 15),
(44, 'Bayeux', 15),
(45, 'Santa Rita', 15),
(46, 'Curitiba', 16),
(47, 'Londrina', 16),
(48, 'Foz do Igua�u', 16),
(49, 'Recife', 17),
(50, 'Jaboat�o dos Guararapes', 17),
(51, 'Olinda', 17),
(52, 'Teresina', 18),
(53, 'Timon', 18),
(54, 'Piripiri', 18),
(55, 'Rio de Janeiro', 19),
(56, 'Niter�i', 19),
(57, 'Natal', 20),
(58, 'Mossor�', 20),
(59, 'Caic�', 20),
(60, 'Macei�', 21),
(61, 'Arapiraca', 21),
(62, 'Palmeira dos �ndios', 21),
(63, 'Macap�', 22),
(64, 'Santana', 22),
(65, 'Laranjal do Jari', 22),
(66, 'Manaus', 23),
(67, 'Parintins', 23),
(68, 'Itacoatiara', 23),
(69, 'Bel�m', 24),
(70, 'Ananindeua', 24),
(71, 'Marituba', 24),
(72, 'Palmas', 25),
(73, 'Gurupi', 25),
(74, 'Porto Nacional', 25),
(75, 'Boa Vista', 26),
(76, 'Normandia', 26),
(77, 'Alto Alegre', 26),
(78, 'Jo�o Pessoa', 27),
(79, 'Campina Grande', 27),
(80, 'Patos', 27);

/*Inserindo informa��es na tabela aluno*/
INSERT INTO Aluno (idAluno, nomeAluno, nascimentoAluno, enderecoAluno, numeroCasaAluno, telefoneAluno, bairroAluno, idCidade)
VALUES
(1, 'Jo�o Silva', '01/01/2000', 'Rua 1', '100', '22 99999-9999', 'Centro', 2),
(2, 'Maria Souza', '02/03/2001', 'Rua 2', '200', '24 88888-8888', 'Bairro 2', 27),
(3, 'Carlos Ferreira', '03/04/2002', 'Rua 3', '300', '27 77777-7777', 'Bairro 3', 80),
(4, 'Ana Paula', '04/05/2003', 'Rua 4', '400', '23 66666-6666', 'Bairro 4', 77),
(5, 'Ricardo Oliveira', '05/06/2004', 'Rua 5', '500', '26 55555-5555', 'Bairro 5', 3),
(6, 'Juliana Costa', '06/07/2005', 'Rua 6', '600', '25 44444-4444', 'Bairro 6', 17);

INSERT INTO Aluno (idAluno, nomeAluno, nascimentoAluno, enderecoAluno, numeroCasaAluno, telefoneAluno, bairroAluno, idCidade)
VALUES
(7, 'Lucas Santos', '07/08/2006', 'Rua 7', '700', '21 11111-1111', 'Bairro 7', 31),
(8, 'Fernanda Silva', '08/09/2007', 'Rua 8', '800', '23 22222-2222', 'Bairro 8', 56),
(9, 'Gustavo Souza', '09/10/2008', 'Rua 9', '900', '27 33333-3333', 'Bairro 9', 9),
(10, 'Vitoria Oliveira', '10/11/2009', 'Rua 10', '1000', '21 44444-4444', 'Bairro 10', 23),
(11, 'Bianca Ferreira', '11/12/2010', 'Rua 11', '1100', '23 55555-5555', 'Bairro 11', 39),
(12, 'Andre Souza', '12/01/2011', 'Rua 12', '1200', '26 66666-6666', 'Bairro 12', 66),
(13, 'Larissa Silva', '01/03/2012', 'Rua 13', '1300', '21 77777-7777', 'Bairro 13', 47),
(14, 'Rafael Oliveira', '02/07/1969', 'Rua 14', '1400', '23 88888-8888', 'Bairro 14', 24),
(15, 'Julia Costa', '16/03/1973', 'Rua 15', '1500', '27 99999-9999', 'Bairro 15', 56),
(16, 'Pedro Santos', '31/01/1988', 'Rua 16', '1600', '21 12345-1234', 'Bairro 16', 78),
(17, 'Luana Silva', '18/04/1993', 'Rua 17', '1700', '23 54321-4321', 'Bairro 17', 25);

Create Table StatusMatricula (
	idStatusMatricula int primary key,
	definicaoStatusMatricula nvarchar(100)
);

insert into StatusMatricula (idStatusMatricula, definicaoStatusMatricula) Values
(1, 'Ativa'),
(2, 'Inativa'),
(3, 'Trancada'),
(4, 'Cancelada'),
(5, 'Finalizada');

ALTER TABLE Matricula ADD FOREIGN KEY(idStatusMatricula) REFERENCES StatusMatricula (idStatusMatricula) 


INSERT INTO Turma (idTurma, qtdVagas, nomeTurma)
VALUES (2, 20, 'Programa��o B�sica'), (3, 15, 'Programa��o Avan�ada'), (4, 25, 'Desenvolvimento Web'),
(5, 10, 'Desenvolvimento de Jogos'), (6, 18, 'Banco de Dados'), (7, 25, 'Programa��o em Java'), 
(8, 22, 'Desenvolvimento de Aplicativos'), (9, 20, 'Intelig�ncia Artificial'), (10, 15, 'Programa��o em C++');


INSERT INTO Matricula (idMatricula, idTurma, idAluno, idStatusMatricula)
VALUES
(1, 1, 1, 1),
(2, 2, 2, 2),
(3, 3, 3, 3),
(4, 4, 4, 4),
(5, 5, 5, 5),
(6, 6, 6, 1),
(7, 7, 7, 2),
(8, 8, 8, 3),
(9, 9, 9, 4),
(10, 10, 10, 5),
(11, 1, 11, 1),
(12, 2, 12, 2),
(13, 3, 13, 3),
(14, 4, 14, 4),
(15, 5, 15, 5),
(16, 6, 16, 1),
(17, 7, 17, 2);

/*
	Atualizando as informa��es da tabela "Matr�cula", pegaremos a turma 3 e alteraremos o StatusMatricula para 3
*/

UPDATE Matricula
Set idStatusMatricula = 5
WHERE idTurma = 3 AND idStatusMatricula <> 5;

/*
	Utilizando o output
*/

Delete from Cidades
Output deleted.*
Where idCidade = 22;

/*
	O conceito de Merge: Mesclar
	Permite realizar a inser��o, atualiza��o ou dele��o de dados, em uma tabela destino, realizando as opera��es na tabela de origem.
*/

/*Primeiro informamos qual tabela ser� afetada*/
Merge Matricula
/*Informamos onde a tabela onde os dados ser�o acessados ou utilizados*/
using Aluno
/*Devemos definir uma condi��o*/
ON Matricula.idAluno = Aluno.idAluno
/*Agora vamos inserir a instru��o que deve ser executado caso o retorno do merge seja false*/
/*Caso a combina��o acima n�o exista, ser� realizada uma nova inser��o na tabela matr�cula*/
WHEN NOT MATCHED THEN
INSERT (idMatricula, idAluno, idTurma, idStatusMatricula)
VALUES (Aluno.idAluno, Aluno.idAluno, 6, 5)
/*Ao executarmos a instru��o merge, ser� realizada a matr�cula dos alunos que ainda n�o s�o matr�culados*/
/*A instru��o Merge funcionar� como um la�o, percorrendo a tabela Aluno por inteiro*/
WHEN Matched THEN
UPDATE SET Matricula.idStatusMatricula = 1, Matricula.idTurma = 9
Output $action, inserted.*;