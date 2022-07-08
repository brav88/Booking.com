
CREATE TABLE [dbo].[Booking](
	[BookingCode] [int] IDENTITY(1,1) NOT NULL,
	[ResortID] INT NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Checkin] [datetime] NULL,
	[Checkout] [datetime] NULL,
	[Adults] [int] NULL,
	[Kids] [int] NULL,
	[Nights] [int] NULL,
	[BookingCost] [decimal](18, 0) NULL,
	[BookingCostPerNight] [decimal](18, 0) NULL,
	[BookingTotalCost] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[BookingCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


