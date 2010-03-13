USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE atualizarFUNCIONARIO
	@IDFuncionario int,
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
	UPDATE [SIDAF].[dbo].[Funcionario]
	SET [IDUsuario] = @IDUsuario 
       ,[cpf] = @cpf
	   ,[rg] = @rg
       ,[orgaoEmissor] = @orgaoEmissor
       ,[naturalidade] = @naturalidade
       ,[nacionalidade] = @nacionalidade
       ,[tipoFuncionario] = @tipoFuncionario
       ,[IDEmpresa] = @IDEmpresa
       ,[dataCadastro] = @dataCadastro
       ,[isAtivo] = @isAtivo
	WHERE IDFuncionario = @IDFuncionario
GO