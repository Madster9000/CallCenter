using System;
using Microsoft.Xrm.Client;
using Support.Cqrs.Contracts.IncomingNote;
using Support.Crm.Model.Entities;
using Support.Crm.Repository.Interfaces;

namespace Support.Cqrs.Commands
{
    public class IncomingNoteCommands: IIncomingNoteCommands
    {
        private readonly IRepository<iok_ncomingnote> mIncomingNoteRepository;

        public IncomingNoteCommands(IRepository<iok_ncomingnote> incomingNoteRepository)
        {
            mIncomingNoteRepository = incomingNoteRepository;
        }

        public void CreateNew(CreateIncomingNoteRequest request, Guid userId)
        {
            var note = new iok_ncomingnote
            {
                iok_title = request.Title,
                iok_notedescription = request.Description,
                iok_callid = request.CallId,
                iok_responsibleuser = new CrmEntityReference("systemuser", userId),
                iok_regardingcontact = new CrmEntityReference("contact", request.ContactId),
                new_regardingincident = new CrmEntityReference("incident", request.IncidentId)
            };

            mIncomingNoteRepository.Create(note);
        }
    }
}