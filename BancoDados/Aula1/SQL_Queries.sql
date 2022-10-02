select id, 
		nome, 
        datanascimento, 
        idade, 
        status 
from pessoa
;

select id, id_pessoa,login,senha,status
from usuario;

select p.id codigo_pessoa,
	   u.id codigo_usuario,
	   p.nome,
       u.login,
       u.senha,
       p.datanascimento,
       p.idade,
       p.status situacao,
       u.status status_usuario
from pessoa p
join usuario u on u.id_pessoa = p.id;

select *
from pessoa
where datanascimento < '1998-01-01';

select p2.id from pessoa as p2 order by id desc limit 1;