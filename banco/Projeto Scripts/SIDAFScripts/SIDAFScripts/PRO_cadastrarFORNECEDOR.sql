USE [SIDAF]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cadastrarFORNECEDOR]
		
	-- DADOS DO FORNECEDOR
		@nomeFantasia varchar(150),
		@razaoSocial varchar(250),
		@cnpj char(14),
		@ie int,
		@im int,
		@email varchar(50),
		@telefone nchar(10),
		@fax nchar(10),
		@url varchar(50),
		
	-- DADOS DO ENDERE�O
		@logradouro varchar(150),
		@numero int,
		@complemento varchar(20),
		@bairro varchar(100),
		@cep int,
		@IDCidade int
AS
	BEGIN
	   SET NOCOUNT ON
	
	-- INICIANDO A TRANSA��O
		BEGIN TRANSACTION
			BEGIN
		
			-- INSERINDO ENDERE�O
				INSERT INTO Endereco (logradouro
									 ,numero
									 ,complemento
									 ,bairro
									 ,cep
									 ,IDCidade)
				VALUES(@logradouro
					  ,@numero
					  ,@complemento
					  ,@bairro
					  ,@cep
					  ,@IDCidade)
					  
			-- DECLARA A VARI�VEL PARA RECUPERAR O �LTIMO IDENDERECO
				DECLARE @IDEndereco int = SCOPE_IDENTITY()
			
			-- INSERINDO FUNCION�RIO
				INSERT INTO Fornecedor	(nomeFantasia
										,razaoSocial
										,cnpj
										,ie
										,im
										,email
										,telefone
										,fax
										,url
										,IDEndereco)
				VALUES (@nomeFantasia
				       ,@razaoSocial
					   ,@cnpj
					   ,@ie
					   ,@im
					   ,@email
					   ,@telefone
					   ,@fax
					   ,@url
					   ,@IDEndereco)
       					
			-- VERIFICANDO SE OCORREU ALGUM ERRO
				IF @@ERROR = 0

			-- FECHA A TRANSA��O 
					COMMIT TRANSACTION
				ELSE

			-- REVERTIMENTO DA TRANSA��O
					ROLLBACK TRANSACTION
		END
	END
