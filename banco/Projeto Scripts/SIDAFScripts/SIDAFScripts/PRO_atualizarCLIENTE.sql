USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[atualizarCLIENTE]
	
	--DADOS DE CLIENTE
	@IDCliente int,
	@IDUsuario int,
	@IDEndereco int,
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
	@dataCadastro date,
	@dataUltimaAlteracao date,
	-- DADOS DE USUARIO
	@login varchar(50),
	@senha varchar(1000),
	-- DADOS DE ENDERE�O
	@IDCidade int,
	@cep int,
	@logradouro varchar(150),
	@numero int,
	@complemento varchar(20),
	@bairro varchar(100)
AS
	UPDATE Cliente
	SET	 nome = @nome
		,dataNascimento = @dataNascimento
		,cpf = @cpf		
		,rg = @rg
		,orgaoEmissorRg = @orgaoEmissor
		,naturalidade = @naturalidade
		,nacionalidade = @nacionalidade
		,telefoneFixo = @telefoneFixo
		,celular = @celular
		,email = @email
		,dataUltimaAlteracao = @dataUltimaAlteracao
		WHERE IDCliente = @IDCliente
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
		
