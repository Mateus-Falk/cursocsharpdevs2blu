insert into pessoa (nome, datanascimento, idade, status)
values ('Meninin Maluquim','2005-09-01', 17, 0);

/*DELETE*/
delete from pessoa
where id = 9;

delete from pessoa 
where max(id);