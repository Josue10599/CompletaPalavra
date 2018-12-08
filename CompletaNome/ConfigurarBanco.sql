#Caso o banco não exista gerar um novo banco 
CREATE DATABASE bancopal IF NOT EXISTS;

#Selecionar o banco que será utilizado
USE bancopal;

#Deletar a tabela caso ela já exista
DROP TABLE banpal IF EXISTS;

#Gerar tabela
CREATE TABLE banpal (
    cod INT NOT NULL,
    pal VARCHAR(250) NOT NULL,
);

#Organiza os cod
UPDATE banpal SET cod = cod - 1 WHERE cod > '1';

#Remove dados do banco
DELETE FROM banpal WHERE cod = '1';

#Insere dados no banco de dados
INSERT INTO banpal (id, pal) VALUES ('1', 'Como você está?');

#Selecionar toda a lista
SELECT * FROM banpal ORDER BY cod

#Selecionar a palavra solicitada pelo código
SELECT pal FROM banpal WHERE id = '1';
