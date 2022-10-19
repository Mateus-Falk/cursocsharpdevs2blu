select * from compromissos;
select * from contatos;
select * from endereco;
select * from estados;

insert into endereco 
(cep,
rua,
numero,
bairro,
cidade,
id_estados)
values
(@cep,
@rua,
@numero,
@bairro,
@cidade,
@id_estados)