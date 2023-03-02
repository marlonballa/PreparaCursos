-- Para unir valores de duas tabelas diferentes em uma mesma pesquisa realizada pelo usuário, devemos utilizar op INNER JOIN
  select idAluguel, isbn, nomeUsuario, dataLocacao, dataDevolucaoPrevista, dataDevolucaoReal
  from Aluguel
  --Efetua a junção entre as duas tabelas
  inner join Usuarios
  --Indicaremos que a coluna idUsuario da tabela Usuarios deverá encontrar o mesmo valor na idUsuario da Aluguel
  ON Usuarios.idUsuario = Aluguel.idUsuario

  --Realizando consultas em mais do que duas tabelas
  select dataLocacao, nomeUsuario, tituloLivro
  from  Aluguel
  INNER JOIN Livros
  ON Aluguel.isbn = Livros.isbn
  INNER JOIN Usuarios
  ON Aluguel.idUsuario = Usuarios.idUsuario;

  --A claúsula LEFT JOIN exibe od dados relacionais e não relacionais (um cliente que nunca pegou um livro, possui apenas um cadastro)
  --Esta consulta retorna para nós todos os alugueis existentes, bem como os clientes que não possuem nenhum aluguel relacionado
  select tituloLivro, nomeUsuario, emailUsuario
  FROM Usuarios
  LEFT JOIN Aluguel
  ON Usuarios.idUsuario = Aluguel.idUsuario
  LEFT JOIN Livros
  ON Livros.isbn = Aluguel.isbn

  --Quais livros nunca foram alugados? Dos que já foram, qual a última data de locação?
  --Right Join, mostra os dados não relacionados da tabela que está à direita da cláusula FROM
  select tituloLivro, nomeUsuario, dataLocacao
  FROM Aluguel
  RIGHT JOIN Livros
  ON Aluguel.isbn = Livros.isbn
  LEFT JOIN Usuarios
  ON Aluguel.idUsuario = Usuarios.idUsuario

  /*
    Tanto o LEFT JOIN quanto o RIGHT JOIN são tipos de junções (join) usados para combinar dados de duas tabelas em um banco de dados. A principal diferença entre eles está na tabela que é considerada como "principal" e a que é considerada como "secundária".
	No LEFT JOIN, a tabela da esquerda é a principal e todos os seus dados serão incluídos na consulta, independentemente de haver correspondência na tabela da direita. Já no RIGHT JOIN, a tabela da direita é a principal e todos os seus dados serão incluídos, mesmo que não haja correspondência na tabela da esquerda.
	Em resumo, a principal diferença entre LEFT JOIN e RIGHT JOIN é a tabela que é considerada como principal e que terá todos os seus dados incluídos na consulta, mesmo que não haja correspondência na outra tabela.
  */