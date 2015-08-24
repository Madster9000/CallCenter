using System.Linq;
using Support.Cqrs.Contracts.Contact;

namespace Support.Cqrs.Queries.Contact
{
    public interface IContactsQueries
    {
        IQueryable<ContactResponse> SelectContactsByPhone(string phoneNumber);
        IQueryable<ContactResponse> SelectContactByRequestParameters(ContactRequest request);
    }
}