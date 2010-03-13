USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE selecionarFUNCINARIOporEMPRESA
	@empresa int
AS
	SELECT * FROM [SIDAF].[dbo].[Funcionario]
	WHERE empresa = @empresa
GO