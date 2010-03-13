USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE cadastrarCLIENTE
	@cpf char(11),
	@rg int,
	@orgaoEmissor varchar(50),
	@naturalidade varchar(50),
	@nacionalidade varchar(50),
	@dataCadastro date,
	@IDUsuario int
	
AS
	INSERT INTO [SIDAF].[dbo].[Cliente]
		       ([cpf]
	           ,[rg]
		       ,[orgaoEmissor]
			   ,[naturalidade]
			   ,[nacionalidade]
			   ,[dataCadastro]
			   ,[IDUsuario])
     VALUES
           (@cpf
           ,@rg
           ,@orgaoEmissor
           ,@naturalidade
           ,@nacionalidade
           ,@dataCadastro
           ,@IDUsuario)
GO


GO