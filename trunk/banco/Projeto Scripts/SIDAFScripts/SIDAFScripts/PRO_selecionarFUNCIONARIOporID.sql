USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE selecionarFUNCIONARIOporID
	@IDFuncionario int
AS
	SELECT * FROM [SIDAF].[dbo].[Funcionario]
	WHERE IDFuncionario = @IDFuncionario
GO