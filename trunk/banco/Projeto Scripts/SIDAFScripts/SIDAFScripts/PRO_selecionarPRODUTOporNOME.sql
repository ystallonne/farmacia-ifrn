USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE selecionarPRODUTOporNOME
	@nome int
AS
	SELECT * FROM Produto
	WHERE descricao like '%'+@nome+'%'
GO


