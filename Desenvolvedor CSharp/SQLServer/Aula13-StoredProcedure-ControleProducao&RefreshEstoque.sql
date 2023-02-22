--Stored Procedure responsável por realizar a inserção de "Produção", com o produto e a quantidade produzidos.
create procedure controleProducao
	@idProduto int,
	@quantidadeProduto int
AS
	INSERT Producao VALUES (GETDATE(), @idProduto, @quantidadeProduto)
	--Faz uma chamada a SP que é responsável por atualizar a quantidade de produtos no estoque.
	execute refreshEstoque
		@idProduto,
		@quantidadeProduto
	--Mostra as atualizações que ocorreram
	SELECT * from Estoque
	where idProduto = @idProduto
GO

create procedure refreshEstoque
	@idProduto int,
	@quantidadeProduto int
AS
	--Vamos realizar uma atualização na tabela Estoque
	UPDATE Estoque
	--Para isso, precisamos verficar a quantidade atual do produto e somar com a quantidade que foi produzida. 
	SET quantidadeProdutoEstoque = (SELECT quantidadeProdutoEstoque FROM ESTOQUE where idProduto = @idProduto) + @quantidadeProduto
	where idProduto = @idProduto
GO