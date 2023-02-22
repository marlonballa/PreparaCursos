use AcademiaAula09;
Go

/*Estamos acesasndo a tabela Estado, informando as colunas que receberão informações e passando os valores que devem ser inseridos*/
INSERT INTO Estado (idEstado, nomeEstado, UF) VALUES
(1, 'Acre', 'AC'),
(2, 'Alagoas', 'AL'),
(3, 'Amapá', 'AP'),
(4, 'Amazonas', 'AM'),
(5, 'Bahia', 'BA'),
(6, 'Ceará', 'CE'),
(7, 'Distrito Federal', 'DF'),
(8, 'Espírito Santo', 'ES'),
(9, 'Goiás', 'GO'),
(10, 'Maranhão', 'MA'),
(11, 'Mato Grosso', 'MT'),
(12, 'Mato Grosso do Sul', 'MS'),
(13, 'Minas Gerais', 'MG'),
(14, 'Pará', 'PA'),
(15, 'Paraíba', 'PB'),
(16, 'Paraná', 'PR'),
(17, 'Pernambuco', 'PE'),
(18, 'Piauí', 'PI'),
(19, 'Rio de Janeiro', 'RJ'),
(20, 'Rio Grande do Norte', 'RN'),
(21, 'Rio Grande do Sul', 'RS'),
(22, 'Rondônia', 'RO'),
(23, 'Roraima', 'RR'),
(24, 'Santa Catarina', 'SC'),
(25, 'São Paulo', 'SP'),
(26, 'Sergipe', 'SE'),
(27, 'Tocantins', 'TO');

INSERT INTO Estado (idEstado, nomeEstado, UF) VALUES
(28, 'Estado de Teste e Manipulação', 'ET')


INSERT INTO Estado (idEstado, nomeEstado, UF) VALUES
(29, 'Estado de Teste e Manipulação', 'ET')
/*
	Para realizarmos alteraçãoes em nosso banco de dados, devemos utilizar "UPDATE", onde sua sintaxe básica é:
	UPDATE nomeTabela SET coluna = novoValor
*/

Update Estado
Set nomeEstado = 'Estado de Teste: Update' 
Where idEstado = 28;

/*
	Para realizarmos a exclusão de informações de um banco de dados devemos utilizar "Delete", onde sua sintaxe básica é:
	Delete FROM nomeTabele Where condição
*/

Delete from Estado Where idEstado = 29;

/*Inserindo informações na tabela aluno*/

INSERT INTO Cidades (idCidade, nomeCidade, idEstado) VALUES
(1, 'Rio Branco', 1),
(2, 'Cruzeiro do Sul', 1),
(3, 'Senador Guiomard', 1),
(4, 'Maceió', 2),
(5, 'Arapiraca', 2),
(6, 'Palmeira dos Índios', 2),
(7, 'Macapá', 3),
(8, 'Santana', 3),
(9, 'Laranjal do Jari', 3),
(10, 'Manaus', 4),
(11, 'Iranduba', 4),
(12, 'Manacapuru', 4),
(13, 'Salvador', 5),
(14, 'Feira de Santana', 5),
(15, 'Vitória da Conquista', 5),
(16, 'Fortaleza', 6),
(17, 'Caucaia', 6),
(18, 'Juazeiro do Norte', 6),
(19, 'Brasília', 7),
(20, 'Taguatinga', 7),
(21, 'Sobradinho', 7),
(22, 'Vitória', 8),
(23, 'Cariacica', 8),
(24, 'Serra', 8),
(25, 'Goiânia', 9),
(26, 'Aparecida de Goiânia', 9),
(27, 'Anápolis', 9),
(28, 'São Luís', 10),
(29, 'Imperatriz', 10),
(30, 'Timon', 10),
(31, 'Cuiabá', 11),
(32, 'Várzea Grande', 11),
(33, 'Rondonópolis', 11),
(34, 'Campo Grande', 12),
(35, 'Dourados', 12),
(36, 'Três Lagoas', 12),
(37, 'Belo Horizonte', 13),
(38, 'Contagem', 13),
(39, 'Uberlândia', 13),
(40, 'Belém', 14),
(41, 'Ananindeua', 14),
(42, 'Santarém', 14),
(43, 'João Pessoa', 15),
(44, 'Bayeux', 15),
(45, 'Santa Rita', 15),
(46, 'Curitiba', 16),
(47, 'Londrina', 16),
(48, 'Foz do Iguaçu', 16),
(49, 'Recife', 17),
(50, 'Jaboatão dos Guararapes', 17),
(51, 'Olinda', 17),
(52, 'Teresina', 18),
(53, 'Timon', 18),
(54, 'Piripiri', 18),
(55, 'Rio de Janeiro', 19),
(56, 'Niterói', 19),
(57, 'Natal', 20),
(58, 'Mossoró', 20),
(59, 'Caicó', 20),
(60, 'Maceió', 21),
(61, 'Arapiraca', 21),
(62, 'Palmeira dos Índios', 21),
(63, 'Macapá', 22),
(64, 'Santana', 22),
(65, 'Laranjal do Jari', 22),
(66, 'Manaus', 23),
(67, 'Parintins', 23),
(68, 'Itacoatiara', 23),
(69, 'Belém', 24),
(70, 'Ananindeua', 24),
(71, 'Marituba', 24),
(72, 'Palmas', 25),
(73, 'Gurupi', 25),
(74, 'Porto Nacional', 25),
(75, 'Boa Vista', 26),
(76, 'Normandia', 26),
(77, 'Alto Alegre', 26),
(78, 'João Pessoa', 27),
(79, 'Campina Grande', 27),
(80, 'Patos', 27);

/*Inserindo informações na tabela aluno*/
INSERT INTO Aluno (idAluno, nomeAluno, nascimentoAluno, enderecoAluno, numeroCasaAluno, telefoneAluno, bairroAluno, idCidade)
VALUES
(1, 'João Silva', '01/01/2000', 'Rua 1', '100', '22 99999-9999', 'Centro', 2),
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
VALUES (2, 20, 'Programação Básica'), (3, 15, 'Programação Avançada'), (4, 25, 'Desenvolvimento Web'),
(5, 10, 'Desenvolvimento de Jogos'), (6, 18, 'Banco de Dados'), (7, 25, 'Programação em Java'), 
(8, 22, 'Desenvolvimento de Aplicativos'), (9, 20, 'Inteligência Artificial'), (10, 15, 'Programação em C++');


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
	Atualizando as informações da tabela "Matrícula", pegaremos a turma 3 e alteraremos o StatusMatricula para 3
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
	Permite realizar a inserção, atualização ou deleção de dados, em uma tabela destino, realizando as operações na tabela de origem.
*/

/*Primeiro informamos qual tabela será afetada*/
Merge Matricula
/*Informamos onde a tabela onde os dados serão acessados ou utilizados*/
using Aluno
/*Devemos definir uma condição*/
ON Matricula.idAluno = Aluno.idAluno
/*Agora vamos inserir a instrução que deve ser executado caso o retorno do merge seja false*/
/*Caso a combinação acima não exista, será realizada uma nova inserção na tabela matrícula*/
WHEN NOT MATCHED THEN
INSERT (idMatricula, idAluno, idTurma, idStatusMatricula)
VALUES (Aluno.idAluno, Aluno.idAluno, 6, 5)
/*Ao executarmos a instrução merge, será realizada a matrícula dos alunos que ainda não são matrículados*/
/*A instrução Merge funcionará como um laço, percorrendo a tabela Aluno por inteiro*/
WHEN Matched THEN
UPDATE SET Matricula.idStatusMatricula = 1, Matricula.idTurma = 9
Output $action, inserted.*;