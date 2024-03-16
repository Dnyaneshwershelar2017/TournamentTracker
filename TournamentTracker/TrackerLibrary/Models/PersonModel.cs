namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PersonId"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="EmailAddress"></param>
        /// <param name="PhoneNumber"></param>
        public PersonModel(int PersonId,string FirstName, string LastName, string EmailAddress, string PhoneNumber)
        {
            this.PersonId = PersonId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.PhoneNumber = PhoneNumber;
        }

        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}