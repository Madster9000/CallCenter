using System.Collections.Generic;
using Support.Cqrs.Contracts.Contact;
using Support.Crm.Model.Entities;

namespace Support.Services.Interfaces
{
    public interface IContactsService
    {
        ContactResponse GetContactByPhoneNumber(string phoneNumber);
        IEnumerable<ContactResponse> GetContactsBySearchContract(ContactRequest contactSearch);
    }
}