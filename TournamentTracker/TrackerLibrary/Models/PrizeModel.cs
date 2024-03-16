namespace TrackerLibrary.Models
{
    public class PrizeModel
    {

        public int PrizeID { get; set; }
        /// <summary>
        /// Represents the place no for the prize.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the place name for the prize.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the amount of prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage amount of prize.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage, string prizeId="0")
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;


            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;


            int idNumberValue = 0;
            int.TryParse(prizeId, out idNumberValue);
            PrizeID = idNumberValue;

        }
    }
}