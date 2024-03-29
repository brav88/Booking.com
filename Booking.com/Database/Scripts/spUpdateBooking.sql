USE [Booking]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateBooking]    Script Date: 11/8/2022 19:06:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateBooking] 
	@BookingCode INT,
	@Checkin DATETIME,
	@Checkout DATETIME,
	@Adults INT,
	@Kids INT,
	@Nights INT,
	@BookingCost DECIMAL,
	@BookingCostPerNight DECIMAL,
	@BookingTotalCost DECIMAL
AS
BEGIN
	UPDATE [dbo].[Booking]
	   SET [Checkin] = @Checkin
		  ,[Checkout] = @Checkout
		  ,[Adults] = @Adults
		  ,[Kids] = @Kids
		  ,[Nights] = @Nights
		  ,[BookingCost] = @BookingCost
		  ,[BookingCostPerNight] = @BookingCostPerNight
		  ,[BookingTotalCost] = @BookingTotalCost
	 WHERE [BookingCode] = @BookingCode
END
