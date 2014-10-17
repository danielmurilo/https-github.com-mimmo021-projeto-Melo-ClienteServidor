create database EasyImovel;
go
use EasyImovel;
go
create table Cli_Rede
(
Id_cli_rede int identity(1,1) primary key,
nome_Cli_Rede varchar(100) not null,
login_Cli_Rede varchar(100) not null,
senha_Cli_Rede varchar(100) not null,
email_Cli_Rede varchar(100) not null,
telefone_Cli_Rede varchar (10)
);


go
create table Funcionario
(
Id_Funcionario int identity(1,1) primary key,
nome_f varchar(100) not null,
login_f varchar(100) not null,
senha_f varchar(100) not null,
email_f varchar(100) not null,
data_Cadastro_Fun date not null,
telefone_f varchar (10) not null

);
go

create table Cliente
(
Id_cliente int identity(1,1) primary key,
tipo varchar (25),
nome_Cli varchar(100) ,
nome_fatasia varchar(100) ,
razao_social varchar(100) ,
email_Cli varchar(100) not null,
telefone_Cli varchar (10),
data_Cadastro_Cli date not null,
rua varchar (200) not null,
bairro varchar(200) not null,
cidade varchar (200) not null,
complemento varchar(500),
Uf varchar (2) not null,
cpf varchar (11) not null,
rg varchar (11) not null,
cnpj varchar(100) not null,
);
go
create table Imovel
(
Id_Imovel int identity(1,1) primary key,
Id_Funcionario int FOREIGN KEY REFERENCES Funcionario(Id_Funcionario),
Id_Propietario int FOREIGN KEY REFERENCES Cliente(Id_cliente),
data_Cadastro date not null,
rua varchar (200) not null,
bairro varchar(200) not null,
cidade varchar (200) not null,
Uf varchar (2) not null,
complemento varchar (500),
N_quartos int not null,
N_garagens int not null,
N_banheiros int not null,
valor varchar (20)not null,
valor_sugerido varchar (20)not null,
);
go
create table interesse
(
Id_cli_rede int FOREIGN KEY REFERENCES Cli_Rede(Id_cli_rede),
Id_Imovel int FOREIGN KEY REFERENCES Imovel(Id_Imovel),
);
go

create table vendas 
(
Id_Vendas int identity(1,1) primary key,
Id_Funcionario int FOREIGN KEY REFERENCES funcionario(Id_Funcionario),
Id_cli int FOREIGN KEY REFERENCES Cliente(Id_cliente),
Id_Imovel int  FOREIGN KEY REFERENCES Imovel(Id_Imovel),
obs varchar(500),
Contra_P varchar(20),
situacao varchar(20) 
)

go
select * from imovel











