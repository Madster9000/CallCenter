using System;
using System.Collections.Generic;
using System.Linq;
using Support.Cqrs.Contracts.Contact;
using Support.Crm.Repository.Interfaces;
using Support.Datasources.MsCrm;

namespace Support.Cqrs.Queries.Contact
{
    public class ContactsQueries: IContactsQueries
    {
        private readonly IRepository<ContactBase> mContactsRepository;

        public ContactsQueries(IRepository<ContactBase> contactsRepository)
        {
            mContactsRepository = contactsRepository;
        }

        public IQueryable<ContactResponse> SelectContactsByPhone(string phoneNumber)
        {
            var query = mContactsRepository
                .GetAll()
                .Where
                (
                    c =>
                        c.StateCode == 0
                        &&
                        (
                            (!String.IsNullOrEmpty(c.MobilePhone) & c.MobilePhone.Contains(phoneNumber))
                            ||
                            (!String.IsNullOrEmpty(c.Telephone1) & c.Telephone1.Contains(phoneNumber))
                            ||
                            (!String.IsNullOrEmpty(c.Telephone2) & c.Telephone2.Contains(phoneNumber))
                            ||
                            (!String.IsNullOrEmpty(c.Telephone3) & c.Telephone3.Contains(phoneNumber))
                            )
                )
                .Select
                (
                    c => new ContactResponse
                    {
                        Id = c.ContactId,
                        FullName = c.FullName,
                        OrganizationId = c.ParentCustomerId,
                        ClientCardId = c.ContactExtensionBase.new_sotrudniki
                    }
                );

            return query;
        }

        public IQueryable<ContactResponse> SelectContactByRequestParameters(ContactRequest request)
        {
            //GET http://crmwk.systtech.ru:8585/contacts?FirstName=&LastName=&RouteNumber=1215010
            var query = mContactsRepository
                .GetAll()
                .Where
                (
                    c =>
                        c.StateCode == 0
                        &&
                        (
                            (!string.IsNullOrEmpty(request.RouteNumber) &&
                             c.ContactExtensionBase.new_route.Contains(request.RouteNumber))
                            ||
                            (!string.IsNullOrEmpty(request.FirstName) &&
                             c.FullName.ToLower().Contains(request.FirstName.ToLower()))
                            ||
                            (!string.IsNullOrEmpty(request.LastName) &&
                             c.FullName.ToLower().Contains(request.LastName.ToLower()))
                            )
                )
                .Select
                (
                    c => new ContactResponse
                    {
                        Id = c.ContactId,
                        FullName = c.FullName,
                        OrganizationId = c.ParentCustomerId,
                        ClientCardId = c.ContactExtensionBase.new_sotrudniki
                    }
                )
                .OrderBy(c => c.FullName);

            return query;
        }
    }
}