namespace Support.Cqrs.Contracts.Contact
{
    public class ContactRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RouteNumber { get; set; }
    }
}