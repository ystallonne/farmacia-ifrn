USE [SIDAF]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[atualizarFORNECEDOR]
	
	-- DADOS DO FORNECEDOR
		@IDFornecedor int,
		@IDEndereco int,
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
				
				-- ATUALIZANDO FORNECEDOR
					UPDATE Fornecedor
					SET		nomeFantasia = @nomeFantasia
						   ,razaoSocial = @razaoSocial
						   ,cnpj = @cnpj
						   ,ie = @ie
						   ,im = @im
						   ,email = @email
						   ,telefone = @telefone
						   ,fax = @fax
						   ,url = @url
					WHERE IDFornecedor = @IDFornecedor
					
				-- ATUALIZANDO ENDERE�O
					UPDATE Endereco
					SET		 logradouro = @logradouro
							,numero = @numero
							,complemento = @complemento
							,bairro = @bairro
							,cep = @cep
							,IDCidade = @IDCidade
					WHERE IDEndereco = @IDEndereco
					
			-- VERIFICANDO SE OCORREU ALGUM ERRO
				IF @@ERROR = 0

			-- FECHA A TRANSA��O 
					COMMIT TRANSACTION
				ELSE

			-- REVERTIMENTO DA TRANSA��O
					ROLLBACK TRANSACTION
			END
	END