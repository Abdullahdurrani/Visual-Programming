USE [ITCON]
GO

/****** Object:  StoredProcedure [dbo].[spEmployees_Search]    Script Date: 07-Jan-22 7:33:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spEmployees_Search]
@Id int
as begin
Select * from Employees where Id=@Id
end
GO

