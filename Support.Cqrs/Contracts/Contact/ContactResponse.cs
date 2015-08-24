using System;

namespace Support.Cqrs.Contracts.Contact
{
    public class ContactResponse
    {
        public Guid? Id { get; set; }
        public string FullName { get; set; }
        public Guid? OrganizationId { get; set; }
        public Guid? ClientCardId { get; set; }
    }
}