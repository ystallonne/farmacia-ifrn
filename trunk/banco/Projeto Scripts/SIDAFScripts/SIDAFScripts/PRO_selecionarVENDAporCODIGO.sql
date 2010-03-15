USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE selecionarVENDAporCODIGO
	@idvenda char
AS
	SELECT * FROM [SIDAF].[dbo].[Venda]
	WHERE IDVenda = @idvenda
GO