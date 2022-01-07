USE [ITCON]
GO

/****** Object:  StoredProcedure [dbo].[spEmployees_Delete]    Script Date: 07-Jan-22 7:32:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spEmployees_Delete]
@Id int,
@Name nvarchar(50),
@Email nvarchar(50)
as begin
delete from Employees where Id=@Id
end
GO

