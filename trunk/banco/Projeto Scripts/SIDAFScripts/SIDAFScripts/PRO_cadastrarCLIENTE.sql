USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[cadastrarCliente]
	
	--DADOS DE CLIENTE
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
	BEGIN
	   SET NOCOUNT ON
	
	-- INICIANDO A TRANSA��O
	   BEGIN TRANSACTION
			BEGIN
			-- INSERINDO USU�RIO
				INSERT INTO Usuario	(login, senha)
				VALUES (@login, dbo.CriptografaSenha(@senha))
			
			-- DECLARA A VARI�VEL PARA RECUPERAR O �LTIMO IDUSUARIO
				DECLARE @IDUsuario int = SCOPE_IDENTITY()
			
			-- INSERINDO ENDERE�O
				INSERT INTO Endereco (logradouro
									 ,numero
									 ,complemento
									 ,cep
									 ,IDCidade
									 ,bairro)
				VALUES(@logradouro
					  ,@numero
					  ,@complemento
					  ,@cep
					  ,@IDCidade
					  ,@bairro)
					  
			-- DECLARA A VARI�VEL PARA RECUPERAR O ULTIMO IDENDERECO
				DECLARE @IDEndereco int = SCOPE_IDENTITY()

	INSERT INTO Cliente
				(IDEndereco
				,IDUsuario
				,nome
				,dataNascimento
				,cpf
				,rg
				,orgaoEmissorRg
				,naturalidade
				,nacionalidade
				,telefoneFixo
				,celular
				,email
				,dataCadastro
				,dataUltimaAlteracao)
				 VALUES (@IDEndereco
						,@IDUsuario
						,@nome
						,@dataNascimento
						,@cpf
						,@rg
					    ,@orgaoEmissorRg
					    ,@naturalidade
					    ,@nacionalidade
					    ,@telefoneFixo
					    ,@celular
					    ,@email
					    ,@dataCadastro
					    ,@dataUltimaAlteracao)	   
			   
				IF @@ERROR = 0
					COMMIT TRANSACTION
				ELSE
					ROLLBACK TRANSACTION
			END
		END