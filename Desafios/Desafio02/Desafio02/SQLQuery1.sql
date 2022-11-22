create table Fornecedor(
	idFornecedor int primary key identity not null,
	nomeFornecedor varchar(50) not null
)

create table Produto(
	idProduto int primary key identity not null, 
	nomeProduto varchar(50) not null,
	preco float not null

	FOREIGN KEY (idProduto) REFERENCES Fornecedor (idFornecedor)
)

create table Cliente(
	idCliente int primary key identity not null,
	nomeCliente varchar(50) not null,
	telefone varchar(20) not null
)

create table NotaFiscal(
	idNota int primary key identity not null,
	notaFiscal_idCliente int not null,
	notaFiscal_idProduto int not null,
	quantidade int,
	valorTotal float

	FOREIGN KEY (notaFiscal_idCliente) REFERENCES Cliente (idCliente),
	FOREIGN KEY (notaFiscal_idProduto) REFERENCES Produto (idProduto)
)

select *
from Fornecedor

select * 
from Cliente

select *
from Produto

select *
from NotaFiscal\



