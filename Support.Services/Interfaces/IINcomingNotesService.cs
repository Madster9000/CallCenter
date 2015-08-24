using System.Security.Principal;
using Support.Cqrs.Contracts;
using Support.Cqrs.Contracts.IncomingNote;

namespace Support.Services.Interfaces
{
    public interface IIncomingNotesService
    {
        void CreateIncomingNote(CreateIncomingNoteRequest request, IIdentity currentUser);
    }
}