USE [SIDAF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE cadastrarESTORNO
	@IDFuncionario int,
	@IDCaixa int,
	@IDCliente int,
	@dataEstorno date
	
AS
	INSERT INTO [SIDAF].[dbo].[Estorno]
		       ([IDFuncionario]
	           ,[IDCaixa]
		       ,[IDCliente]
			   ,[dataEstorno])
     VALUES
           (@IDFuncionario
           ,@IDCaixa
           ,@IDCliente
           ,@dataEstorno)
GO


GO