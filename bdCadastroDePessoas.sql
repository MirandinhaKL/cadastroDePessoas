/*
	Autor: Karine Miranda
	Elaborado em: 10/02/2019
	Úlima alteração em: 17/02/2019
*/

/*
	Banco de dados para cadastrar pessoas.
*/

CREATE DATABASE cadastroDePessoa;

CREATE TABLE pessoa(
	idPessoa		INT			 NOT NULL	IDENTITY(1,1) PRIMARY KEY,
	nomePessoa		VARCHAR(50)	 NOT NULL,
	dataCadastro	DATE		 NOT NULL,
	dataNascimento	DATE		 NOT NULL,
	endereco		VARCHAR(50),
	cidade			VARCHAR(30),
	estado			VARCHAR(30),
	observacao		TEXT,
	genero			CHAR(1)
);

SELECT* FROM pessoa;