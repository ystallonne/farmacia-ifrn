USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE excluirFUNCIONARIO
	@IDFunc int
AS
	DELETE FROM Funcionario
	WHERE IDFuncionario = @IDFunc
GO

