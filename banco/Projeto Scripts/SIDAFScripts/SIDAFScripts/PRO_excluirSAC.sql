USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE excluirSAC
	@IDSAC int
AS
	DELETE FROM SAC
	WHERE IDSAC = @IDSAC
GO


