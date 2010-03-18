USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[excluirCLIENTE]
	@IDCliente int,
	@IDUsuario int,
	@IDEndereco int
AS
	DELETE FROM Endereco
	WHERE IDEndereco = @IDEndereco
	
	DELETE FROM Usuario
	WHERE IDUsuario = @IDUsuario
	
	DELETE FROM Cliente
	WHERE IDCliente = @IDCliente
GO

