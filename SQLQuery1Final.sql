/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [ProjectsID]
      ,[Image]
      ,[Name]
      ,[Description]
      ,[Skills]
      ,[GitHub]
  FROM [FinalProject].[dbo].[Projects]