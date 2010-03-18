USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[atualizarFUNCIONARIO]
	@IDFuncionario int,
	@nome varchar(150),
	@dataNascimento datetime,
	@cpf char(11),
	@rg int,
	@orgaoEmissorRg varchar(10),
	@naturalidade varchar(50),
	@nacionalidade varchar(50),
	@telefoneFixo nchar(10),
	@celular nchar(10),
	@email varchar(50),
	@tipoFuncionario int,
	@isAtivo binary,
	@IDUsuario int,
	@login varchar(50),
	@senha varchar(1000),
	@IDEmpresa int,
	@IDEndereco int,
	@cep int,
	@IDCidade int,
	@logradouro varchar(150),
	@numero int,
	@complemento varchar(20),
	@bairro varchar(100)	
AS
	UPDATE Funcionario
	SET nome = @nome
		,dataNascimento = @dataNascimento 
		,cpf = @cpf
	    ,rg = @rg
        ,orgaoEmissorRg = @orgaoEmissor
        ,naturalidade = @naturalidade
        ,nacionalidade = @nacionalidade
        ,telefoneFixo = @telefoneFixo
        ,celular = @celular
        ,email = @email        
        ,tipoFuncionario = @tipoFuncionario
        ,IDEmpresa = @IDEmpresa
        ,dataCadastro = @dataCadastro
        ,isAtivo = @isAtivo
        WHERE IDFuncionario = @IDFuncionario
        UPDATE Usuario
			SET	 login = @login
				,senha = dbo.CriptografaSenha(@senha)
				WHERE IDUsuario = @IDUsuario
				
		UPDATE Endereco
			SET  cep = @cep
				,logradouro = @logradouro
				,numero = @numero
				,complemento = @complemento
				,bairro = @bairro
				,IDCidade = @IDCidade
				WHERE IDEndereco = @IDEndereco
GO