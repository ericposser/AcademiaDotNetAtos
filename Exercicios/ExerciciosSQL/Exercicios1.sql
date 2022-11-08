create database empresa_db

create table Departamento(
	idDepartamento int primary key not null,
	nome varchar(50) not null,
	localizacao varchar(50) not null,
	orcamento varchar(50) not null,
);

create table Empregado(
	idEmpregado int primary key not null,
	nome varchar(50),
	idGerente int,
	funcao varchar(50),
	departamento_idDepartamento int,
	dataAdmissao date,
	salario float,
	comissao float,

	foreign key (departamento_idDepartamento) references Departamento (idDepartamento), 
	foreign key (idGerente) references Empregado (idEmpregado)
);

INSERT INTO Departamento VALUES('1','Banco de Dados','Porto Alegre','2346');
INSERT INTO Departamento VALUES('2','Balconistas','Pelotas','10000');
INSERT INTO Departamento VALUES('3','Inteligência Artific','Pelotas','333');
INSERT INTO Departamento VALUES('4','Compiladores','Novo Hamburgo','5050');
INSERT INTO Departamento VALUES('5','Redes','Taquara','12122');


INSERT INTO Empregado VALUES('1','Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
INSERT INTO Empregado VALUES('2','Zico','1','Operário','1','1999-08-13','100','0');
INSERT INTO Empregado VALUES('3','Lula',NULL,'Presidente','5','1950-01-01','10000','0');
INSERT INTO Empregado VALUES('4','Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
INSERT INTO Empregado VALUES('5','Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
INSERT INTO Empregado VALUES('6','Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
INSERT INTO Empregado VALUES('7','Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
INSERT INTO Empregado VALUES('8','Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
INSERT INTO Empregado VALUES('9','Pelé','1','Operário','1','2000-09-09','100',NULL);
INSERT INTO Empregado VALUES('10','Romário','1','Operário','5','2001-12-25','100','0');
INSERT INTO Empregado VALUES('11','Malu Mader','5','Balconista','2','2001-10-20','3400','0');
INSERT INTO Empregado VALUES('12','Antônio Fagundes','7','Vendedor','3','2002-12-22','5000','10');

select Departamento.nome, Departamento.orcamento * 12
from Departamento
where orcamento > 10000

select Departamento.nome 'Departamento', Departamento.orcamento * 12 'Orçamento'
from Departamento
where orcamento > 10000

select distinct Empregado.funcao
from Empregado

select Empregado.nome, Empregado.funcao
from Empregado
order by nome asc

select Empregado.nome, Empregado.funcao
from Empregado
order by nome desc

select Empregado.nome
from Empregado
where empregado.salario < 1000 or empregado.salario > 3500

select Empregado.nome, empregado.salario
from Empregado
where empregado.salario between 3400 and 4000 and empregado.funcao = 'Balconista'

select lower (Empregado.nome)
from Empregado

select substring(empregado.nome,1,5)
from Empregado

select avg(empregado.salario) 
from empregado

select max(empregado.salario)
from empregado

select min(empregado.salario)
from empregado

select sum(empregado.salario)
from empregado

select avg(empregado.comissao)
from empregado

select avg(empregado.comissao)
from empregado
where departamento_idDepartamento > 2

select Empregado.nome, Empregado.funcao ,Departamento.nome
from empregado, Departamento

SELECT  A.idEmpregado, A.nome, A.funcao, B.nome 'CHEFE'
FROM  Empregado A, Empregado B
WHERE  A.idGerente  = B.idEmpregado;

INSERT INTO Departamento (idDepartamento, nome, localizacao, orcamento) VALUES ('70','PRODUCAO','RIO DE JANEIRO','1200');

UPDATE Empregado 
SET Empregado.salario = Empregado.salario* 1.2 
WHERE Empregado.salario< 1000;

DELETE FROM Empregado
WHERE Empregado.salario > 5000;

select Empregado.nome, empregado.funcao, Departamento.orcamento
from empregado, Departamento
where departamento.orcamento = 10000

SELECT Departamento.nome
FROM Departamento
WHERE EXISTS (SELECT * FROM Empregado
              WHERE Empregado.salario > 3000 AND Empregado.Departamento_idDepartamento = departamento.idDepartamento);