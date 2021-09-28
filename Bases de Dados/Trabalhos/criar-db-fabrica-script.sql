-- criacao de base de dados --
CREATE DATABASE fabrica

-- TABELA CODIGOS_POSTAIS
create table Codigos_Postais (
	cod_postal nvarchar(8) primary key not null, 
	localidade nvarchar(30) not null
);
-- INSERIR CODIGOS POSTAIS
insert into Codigos_Postais values
('4460-280','Barbeitos'),
('2799-554','Linda-a-Velha'),
('7370-170', 'Campo Maior'),
('4100-001','Lisboa'),
('4400-096','V.N.Gaia'),
('4000-034','Porto');

-- TABELA CLIENTES
create table Clientes(
cod_cli int primary key not null,
nome_cli nvarchar(35) not null,
morada_cli nvarchar(35) null,
cod_postal nvarchar(8) foreign key references Codigos_Postais(cod_postal) null,
contacto_cli int null,
nif_cli int null
);
-- INSERIR CLIENTES
insert into Clientes values 
(1,'Diogo Ramiro','Rua de Alverca','4100-001', 225695555, 235265585),
(2,'Jaime Delgado','Rua das violetas','4400-096', 935262352, 265851455),
(3,'Artur Lima','Rua das fontainhas','4000-034', 965232255, 265851520),
(4,'Gerson Magno','Rua das fontainhas','4000-034', 965232255, 265851520);

-- TABELA PRODUTOS
create table Produtos(
cod_prod int primary key not null,
nome_prod nvarchar(35) not null,
descricao_prod nvarchar(50) null,
peso_prod decimal (16, 2) null,
preco_prod money default 0,
quantidade_prod int null
);

-- CRIAR PRODUTOS
insert into Produtos values
(1, 'Delta', 'Capsulas de Cafe', 0.50, 0.20, 300000),
(2, 'Buondi', 'Capsulas de Cafe', 0.55, 0.25, 200000),
(3, 'Nespresso', 'Capsulas de Cafe', 0.55, 0.25, 100000),
(4, 'Dulce Gusto', 'Capsulas de Cafe', 0.55, 0.30, 500000);

-- TABELA ENCOMENDAS
create table Encomendas(
cod_enc int primary key not null,
data_enc datetime null,
quantidade_prod int null,
preco_enc money default 0
);
-- INSERIR ENCOMENDAS
insert into Encomendas values
(1, '2019-01-01 10:30:00', 100, 20),
(2, '2020-01-02 11:30:00', 200, 50),
(3, '2020-01-03 12:30:00', 300, 75),
(4, '2020-01-04 13:30:00', 1000, 250);

-- TABELA FORNECEDORES
create table Fornecedores(
cod_forn int primary key not null,
nome_forn nvarchar(35) not null,
morada_cli nvarchar(35) null,
cod_postal nvarchar(8) foreign key references Codigos_Postais(cod_postal) null,
contacto_forn int null,
);
-- INSERIR FORNECEDORES
insert into Fornecedores values
(1, 'Delta Cafe', 'Campo Maior Rua B, nº 4', '7370-170', 268009200),
(2, 'Nestlé Portugal SA', 'R. Alexandre Herculano 8', '2799-554', 808200644);

-- TABELA FORNECEDORES
create table Prod_Forn(
cod_forn int foreign key references Fornecedores(cod_forn) not null,
cod_prod int foreign key references Produtos(cod_prod) not null,
);
-- INSERIR RELACAO ENTRE FORNECEDORES-PRODUTOS
insert into Prod_Forn values
(1, 1),
(2, 2),
(2, 3),
(2, 4);

-- TABELA FORNECEDORES
create table Enc_Prod_Cli(
cod_cli int foreign key references Clientes(cod_cli) not null,
cod_prod int foreign key references Produtos(cod_prod) not null,
cod_enc int foreign key references Encomendas(cod_enc) not null
);

-- INSERIR RELACAO ENTRE ENCOMENDAS-PRODUTOS-CLIENTES
insert into Enc_Prod_Cli values
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(3, 4, 4);


-- Listar o nome de todos os clientes.
select nome_cli from Clientes

-- Listar o nome dos produtos com quantidade superior a 150.000
select nome_prod, quantidade_prod from Produtos where quantidade_prod > 150000

-- Listar, sem repetições, a localidade dos códigos postais superiores a 5000.
select distinct(localidade) from Codigos_Postais where cod_postal > '5000'

-- Listar o número total de Produtos e associar a tabela 'total_prod'.
select count(*) as total_prod from Produtos

-- Listar todos os produtos com quantidade superior a 120000 e o nome termina em 'o'
select * from Produtos where quantidade_prod > 120000 and lower(nome_prod) like('%o')

-- Listar todos os clientes cuja morada contém a palavra 'das'.
select * from Clientes where lower(morada_cli) like('%das%')

-- Número de encomendas feitas em 2020.
select count(*) as numero_req from Encomendas where YEAR(data_enc) = 2020

-- Nomes de clientes residentes no Porto.
select nome_cli, localidade from Clientes, Codigos_Postais where localidade = 'Porto' AND Clientes.cod_postal = Codigos_Postais.cod_postal 

-- Qual o preco da Quantidade de produto superior à média.
select preco_enc from Encomendas where quantidade_prod > (select AVG(quantidade_prod) from Encomendas)

-- Nomes dos produtos encomendados pelo cliente nº 3.
select nome_prod from Produtos, Enc_Prod_Cli where cod_cli = 3 and Enc_Prod_Cli.cod_prod = Produtos.cod_prod

-- Lista de fornecedoes e produtos por eles fornecidos.
select nome_forn, nome_prod from Produtos, Fornecedores, Prod_Forn 
where Fornecedores.cod_forn = Prod_Forn.cod_forn and Produtos.cod_prod = Prod_Forn.cod_prod

-- Lista do número de encomendas feitas for cada cliente.
select nome_cli, count(*) as numero_enc from Encomendas, Enc_Prod_Cli, Clientes 
where Enc_Prod_Cli.cod_cli = Clientes.cod_cli and Encomendas.cod_enc = Enc_Prod_Cli.cod_enc group by nome_cli

-- Nomes de clientes que fizeram mais do que uma encomenda.
select nome_cli from Clientes, Enc_Prod_Cli where Clientes.cod_cli = Enc_Prod_Cli.cod_cli group by Clientes.cod_cli, nome_cli having count(cod_enc) > 1

-- Lista de todas as encomendas efectuadas em 2020 ordenadas pelo número de cliente e incluindo as datas e o nome dos produtos encomendados.
select Clientes.cod_cli, nome_cli, Encomendas.data_enc, Produtos.nome_prod 
from Clientes, Encomendas, Produtos, Enc_Prod_Cli
where YEAR(Encomendas.data_enc) = 2020 
and Encomendas.cod_enc = Enc_Prod_Cli.cod_enc 
and Produtos.cod_prod = Enc_Prod_Cli.cod_prod 
and Clientes.cod_cli = Enc_Prod_Cli.cod_cli
order by Clientes.cod_cli

