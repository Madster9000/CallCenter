using System;
using Support.Cqrs.Contracts.IncomingNote;

namespace Support.Cqrs.Commands
{
    public interface IIncomingNoteCommands
    {
        void CreateNew(CreateIncomingNoteRequest request, Guid userId);
    }
}