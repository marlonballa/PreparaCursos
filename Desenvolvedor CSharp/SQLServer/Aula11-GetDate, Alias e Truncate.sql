use AcademiaAula09
Go

INSERT INTO Aluno(idAluno, nomeAluno, nascimentoAluno, enderecoAluno, numeroCasaAluno, telefoneAluno, bairroAluno)
OUTPUT Inserted.*
VALUES(18, 'Rubens Carneiro', GETDATE(), 'Rua Bernardino Rodrigues', '125', '(17) 9-9773-0255', 'Centro de Convenções');

/*Alias SQL - São apelidos que podemos dar as nossas tabelas*/

update A
SET A.nascimentoAluno = getdate()
from Aluno as A
Where a.idAluno = 5;

/*O comando Truncate Table volta a tabela ao seu formato pós-criação*/
Truncate Table nomeTabela;