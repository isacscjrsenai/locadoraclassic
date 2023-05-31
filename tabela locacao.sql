use locadoraclassic;
CREATE TABLE locacao(
id int primary key auto_increment not null,
id_locacao int not null,
data_locacao date not null,
data_devolucao date not null,
id_filme int,
FOREIGN KEY (id_filme) REFERENCES filme(id)
);


