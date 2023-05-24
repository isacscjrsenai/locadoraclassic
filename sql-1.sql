create database locadoraclassic;
use locadoraclassic;
create table categoria(
	id int primary key auto_increment not null,
    nome varchar(60) not null
);

insert into categoria(nome) values('comédia');
insert into categoria(nome) values('drama');

select * from categoria;