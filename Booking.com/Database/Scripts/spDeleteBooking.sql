USE [Booking]
GO
/****** Object:  StoredProcedure [dbo].[spGetResorts]    Script Date: 28/7/2022 19:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteBooking] 
	@BookingCode INT
AS
BEGIN
	DELETE FROM Booking
	WHERE BookingCode = @BookingCode
END
