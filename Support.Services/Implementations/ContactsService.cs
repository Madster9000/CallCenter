using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Support.Cqrs.Contracts.Contact;
using Support.Cqrs.Queries.Contact;
using Support.Crm.Model.Entities;
using Support.Services.Interfaces;
using Support.Crm.Repository.Interfaces;

namespace Support.Services.Implementations
{
    public class ContactsService : IContactsService
    {
        private readonly IContactsQueries mContactsQueries;
        private readonly Regex mPhoneStartRegex = new Regex(@"^(8|\+7|7)");

        public ContactsService(IContactsQueries contactsQueries)
        {
            mContactsQueries = contactsQueries;
        }

        public ContactResponse GetContactByPhoneNumber(string phoneNumber)
        {
            var normalizedPhone = mPhoneStartRegex.Replace(phoneNumber, "");
            return mContactsQueries.SelectContactsByPhone(normalizedPhone).FirstOrDefault();
        }

        public IEnumerable<ContactResponse> GetContactsBySearchContract(ContactRequest contactSearch)
        {
            return mContactsQueries.SelectContactByRequestParameters(contactSearch);
        }
    }
}