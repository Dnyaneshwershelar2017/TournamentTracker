CREATE PROCEDURE dbo.spPrizes_Insert
	@PlaceNumber int,
	@PlaceName varchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

		insert into dbo.Prizes(PlaceNumber,PlaceName,PrizeAmount,PrizePercentage)
		values(@PlaceNumber,@PlaceName,@PrizeAmount,@PrizePercentage);

		select @id = SCOPE_IDENTITY(); 
END
GO
