USE [Booking]
GO
/****** Object:  StoredProcedure [dbo].[GetResorts]    Script Date: 7/7/2022 19:32:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetResorts] 
AS
BEGIN
	SELECT * FROM Resort
END
