-- Para unir valores de duas tabelas diferentes em uma mesma pesquisa realizada pelo usu�rio, devemos utilizar op INNER JOIN
  select idAluguel, isbn, nomeUsuario, dataLocacao, dataDevolucaoPrevista, dataDevolucaoReal
  from Aluguel
  --Efetua a jun��o entre as duas tabelas
  inner join Usuarios
  --Indicaremos que a coluna idUsuario da tabela Usuarios dever� encontrar o mesmo valor na idUsuario da Aluguel
  ON Usuarios.idUsuario = Aluguel.idUsuario

  --Realizando consultas em mais do que duas tabelas
  select dataLocacao, nomeUsuario, tituloLivro
  from  Aluguel
  INNER JOIN Livros
  ON Aluguel.isbn = Livros.isbn
  INNER JOIN Usuarios
  ON Aluguel.idUsuario = Usuarios.idUsuario;

  --A cla�sula LEFT JOIN exibe od dados relacionais e n�o relacionais (um cliente que nunca pegou um livro, possui apenas um cadastro)
  --Esta consulta retorna para n�s todos os alugueis existentes, bem como os clientes que n�o possuem nenhum aluguel relacionado
  select tituloLivro, nomeUsuario, emailUsuario
  FROM Usuarios
  LEFT JOIN Aluguel
  ON Usuarios.idUsuario = Aluguel.idUsuario
  LEFT JOIN Livros
  ON Livros.isbn = Aluguel.isbn

  --Quais livros nunca foram alugados? Dos que j� foram, qual a �ltima data de loca��o?
  --Right Join, mostra os dados n�o relacionados da tabela que est� � direita da cl�usula FROM
  select tituloLivro, nomeUsuario, dataLocacao
  FROM Aluguel
  RIGHT JOIN Livros
  ON Aluguel.isbn = Livros.isbn
  LEFT JOIN Usuarios
  ON Aluguel.idUsuario = Usuarios.idUsuario

  /*
    Tanto o LEFT JOIN quanto o RIGHT JOIN s�o tipos de jun��es (join) usados para combinar dados de duas tabelas em um banco de dados. A principal diferen�a entre eles est� na tabela que � considerada como "principal" e a que � considerada como "secund�ria".
	No LEFT JOIN, a tabela da esquerda � a principal e todos os seus dados ser�o inclu�dos na consulta, independentemente de haver correspond�ncia na tabela da direita. J� no RIGHT JOIN, a tabela da direita � a principal e todos os seus dados ser�o inclu�dos, mesmo que n�o haja correspond�ncia na tabela da esquerda.
	Em resumo, a principal diferen�a entre LEFT JOIN e RIGHT JOIN � a tabela que � considerada como principal e que ter� todos os seus dados inclu�dos na consulta, mesmo que n�o haja correspond�ncia na outra tabela.
  */