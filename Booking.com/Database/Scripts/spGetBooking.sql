USE [Booking]
GO
/****** Object:  StoredProcedure [dbo].[spGetBookings]    Script Date: 11/8/2022 19:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetBooking] 
	@BookingCode varchar(50)
AS
BEGIN
	SELECT 
		b.*,
		r.Name,
		r.Photo
	FROM [dbo].[Booking] b
		INNER JOIN [dbo].[Resort] r
		ON b.ResortID = r.Id
	WHERE b.BookingCode = @BookingCode
END
