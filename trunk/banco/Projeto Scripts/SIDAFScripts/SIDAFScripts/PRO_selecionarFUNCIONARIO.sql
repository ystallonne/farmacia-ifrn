USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE selecionarFUNCIONARIO
AS
	SELECT * FROM [SIDAF].[dbo].[Funcionario]
GO