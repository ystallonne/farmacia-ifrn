USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE cadastrarFUNCIONARIO

	@IDUsuario int,
	@cpf char(11),
	@rg int,
	@orgaoEmissor varchar(50),
	@naturalidade varchar(50),
	@nacionalidade varchar(50),
	@tipoFuncionario varchar(15),
	@IDEmpresa int,
	@dataCadastro date,
	@isAtivo binary

	
AS
	INSERT INTO [SIDAF].[dbo].[Funcionario]
		       ([IDUsuario]
		       ,[cpf]
	           ,[rg]
		       ,[orgaoEmissor]
			   ,[naturalidade]
			   ,[nacionalidade]
			   ,[tipoFuncionario]
			   ,[IDEmpresa]
			   ,[dataCadastro]
			   ,[isAtivo])
     VALUES
           (@IDUsuario
           ,@cpf
           ,@rg
           ,@orgaoEmissor
           ,@naturalidade
           ,@nacionalidade
           ,@tipoFuncionario
           ,@IDEmpresa
           ,@dataCadastro
           ,@isAtivo)
GO


GO