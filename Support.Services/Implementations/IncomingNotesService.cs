using System.Security.Principal;
using Microsoft.Xrm.Client;
using Support.Cqrs.Commands;
using Support.Cqrs.Contracts;
using Support.Cqrs.Contracts.IncomingNote;
using Support.Crm.Model.Entities;
using Support.Crm.Repository.Interfaces;
using Support.Services.Interfaces;

namespace Support.Services.Implementations
{
    public class IncomingNotesService: IIncomingNotesService
    {
        private readonly ISystemUsersService mSystemUsersService;
        private readonly IIncomingNoteCommands mIncomingNoteCommands;

        public IncomingNotesService(ISystemUsersService systemUsersService, IIncomingNoteCommands incomingNoteCommands )
        {
            mSystemUsersService = systemUsersService;
            mIncomingNoteCommands = incomingNoteCommands;
        }

        public void CreateIncomingNote(CreateIncomingNoteRequest request, IIdentity currentUser)
        {
            var currentUserId = mSystemUsersService.FindUserIdByIdentity(currentUser);
            mIncomingNoteCommands.CreateNew(request, currentUserId);
        }
    }
}