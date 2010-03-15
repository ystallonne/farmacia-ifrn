USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE selecionarVENDAporDATA
	@data char
AS
	SELECT * FROM [SIDAF].[dbo].[Venda]
	WHERE dataVenda = @data
GO