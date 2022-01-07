USE [ITCON]
GO

/****** Object:  StoredProcedure [dbo].[spEmployees_Update]    Script Date: 07-Jan-22 7:33:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spEmployees_Update]
@Id int,
@Name nvarchar(50),
@Email nvarchar(50)
as
begin
Update Employees set Name=@Name,Email=@Email where Id=@Id
end
GO

