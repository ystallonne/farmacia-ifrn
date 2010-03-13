USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE atualizarCLIENTE
	@IDCliente int,
	@cpf char(11),
	@rg int,
	@orgaoEmissor varchar(50),
	@naturalidade varchar(50),
	@nacionalidade varchar(50),
	@dataCadastro date,
	@IDUsuario int
AS
	UPDATE [SIDAF].[dbo].[Cliente]
	SET [cpf] = @cpf
	   ,[rg] = @rg
       ,[orgaoEmissor] = @orgaoEmissor
       ,[naturalidade] = @naturalidade
       ,[nacionalidade] = @nacionalidade
       ,[dataCadastro] = @dataCadastro
       ,[IDUsuario] = @IDUsuario
	WHERE IDCliente = @IDCliente
GO