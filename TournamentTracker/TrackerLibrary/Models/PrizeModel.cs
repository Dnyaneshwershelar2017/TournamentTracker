namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
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
    }
}