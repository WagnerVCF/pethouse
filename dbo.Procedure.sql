CREATE PROCEDURE [dbo].[AtualizarUsuario]
	@Id int,
	@login nchar(50),
	@senha nchar(50)
AS
	UPDATE Usuario SET login = @login, senha = @senha WHERE Id = @Id
RETURN 0