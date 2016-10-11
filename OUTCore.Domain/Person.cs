namespace OUTCore.Domain
{
    /// <summary>
    /// Represents the Peron class.
    /// </summary>
    public class Person : DomainBase
    {
        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or set the phone number
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
