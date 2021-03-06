USE [Booking]
GO
/****** Object:  StoredProcedure [dbo].[SaveBooking]    Script Date: 7/7/2022 19:30:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSaveBooking] 
	@ResortId INT,
	@Email VARCHAR(50),
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
	INSERT INTO [dbo].[Booking]
           ([ResortID]
		   ,[Email]
           ,[Checkin]
           ,[Checkout]
           ,[Adults]
           ,[Kids]
           ,[Nights]
           ,[BookingCost]
           ,[BookingCostPerNight]
           ,[BookingTotalCost])
     VALUES
           (@ResortId
		   ,@Email
           ,@Checkin
           ,@Checkout
           ,@Adults
           ,@Kids
           ,@Nights
           ,@BookingCost
           ,@BookingCostPerNight
           ,@BookingTotalCost)
END
