/*Comando respons�vel pela cria��o de um banco de dados*/
create database FarmaciaAula03SQLServer

/*Comando respons�vel por criar as tabelas de um banco de dados
	create table <nomeTabela>
		(<descri��o das colunas>),
		(<descri��o das chaves>) -> Lista de colunas que s�o tratadas como chaves prim�rias. 
*/

/*Criando a tabela Clientes*/
use FarmaciaAula03SQLServer;

create table Clientes (
	/*Este atributo � do tipo inteiro, foi definido como chave prim�ria e � autoincrement�vel*/
	idCliente int primary key identity,
	nomeCliente varchar(100) not null,
	enderecoCliente varchar(100) not null,
	telefoneCliente char(16) not null,
	cpfCliente char(14) not null,
);

/*Criando a Tabela Produtos*/
use FarmaciaAula03SQLServer;

create table Produtos(
	idProduto int primary key identity,
	nomeProduto varchar(100) not null,
	quantidadeEstoque int not null,
	valorCompra decimal(8,2) not null,
	valorVenda decimal(9,2) not null
);
