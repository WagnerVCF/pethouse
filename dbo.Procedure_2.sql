CREATE PROCEDURE [dbo].[InserirUsuario]
	@Id int,
	@nome nchar(50),
	@login nchar(50),
	@senha nchar(50),
	@celular nchar(50),
	@dataadmissao datetime,
	@genero nchar(50)
AS
	INSERT INTO Usuario(login, senha, nome, Id, celular, dataadmissao, genero) VALUES (@login, @senha, @nome, @Id, @celular, @dataadmissao, @genero)
RETURN 0