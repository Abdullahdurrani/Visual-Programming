USE [ITCON]
GO

/****** Object:  StoredProcedure [dbo].[spEmployees_Insert]    Script Date: 07-Jan-22 7:32:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spEmployees_Insert]
@Id int,
@Name nvarchar(50),
@Email nvarchar(50)
as
begin
insert into Employees values(@Id,@Name,@Email)
end
GO

