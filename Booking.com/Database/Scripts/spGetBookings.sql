USE [Booking]
GO
/****** Object:  StoredProcedure [dbo].[spGetResorts]    Script Date: 28/7/2022 18:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetBookings] 
	@Email varchar(50)
AS
BEGIN
	SELECT 
		b.*,
		r.Name,
		r.Photo
	FROM [dbo].[Booking] b
		INNER JOIN [dbo].[Resort] r
		ON b.ResortID = r.Id
	WHERE Email = @Email
END
