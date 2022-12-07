/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Nome]
      ,[Idade]
	  ,[Valor]
  FROM [AulaSQLServer].[dbo].[Teste1]
GO
 -- ALTER TABLE [AulaSQLServer].[dbo].[Teste1]
 -- ADD [Valor] int NULL

 UPDATE [AulaSQLServer].[dbo].[Teste1]
	SET Valor = 56
Where Id = 1
GO