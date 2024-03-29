USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION DescriptografaSenha
	(
		@Login VARCHAR(20),
		@Senha VARCHAR(1000)
	)
RETURNS VARCHAR(4000)
AS
	BEGIN
	
		-- CRIANDO A CHAVE PARA CRIPTOGRAFAR
		   DECLARE @ChaveCriptografia VARCHAR(1000) = 'CHAVE'
		   
		-- RECUPERANDO A SENHA DO USUÁRIO AINDA CRIPTOGRADA
		   DECLARE @SenhaCriptografada VARCHAR(MAX) = ( SELECT senha 
		                                                  FROM Usuario
		                                                 WHERE login = @Login)   
		
		-- DESCRIPTOGRAFANDO A SENHA
		   DECLARE @Descriptografada VARCHAR(5000) = DECRYPTBYPASSPHRASE(@ChaveCriptografia, @SenhaCriptografada)
		
		-- RETORNA A SENHA DESCRIPTOGRAFADA
		   RETURN @Descriptografada
	END