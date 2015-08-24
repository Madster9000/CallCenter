using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Support.CallCenter.Ui.Configuration.NLog;
using Support.Cqrs.Contracts.Contact;
using Support.Services.Interfaces;

namespace Support.CallCenter.Ui.Controllers
{
    public class ContactsController : ApiController
    {
        private readonly IContactsService mContactsService;

        public ContactsController(IContactsService contactsService)
        {
            mContactsService = contactsService;
        }

        [Route("contacts/{phoneNumber}")]
        public ContactResponse GetContactByPhoneNumber(string phoneNumber)
        {
            return mContactsService.GetContactByPhoneNumber(phoneNumber)
                   ??
                   new ContactResponse
                   {
                       Id = null,
                       FullName = "Контакт не найден. Создать?",
                       OrganizationId = null,
                       ClientCardId = null
                   };
        }

        public ICollection<ContactResponse> GetContactsBySearchContract([FromUri]ContactRequest contactSearch)
        {
            try
            {
                return
                mContactsService
                    .GetContactsBySearchContract(contactSearch).ToList();
            }
            catch (Exception e)
            {
                NLogContaner.Instance.Error(e.ToString());
                return new List<ContactResponse>();
            }
            
        }
    }
}
