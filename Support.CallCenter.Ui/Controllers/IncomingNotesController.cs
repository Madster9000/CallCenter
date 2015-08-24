using System.Web.Http;
using Support.Cqrs.Contracts;
using Support.Cqrs.Contracts.IncomingNote;
using Support.Services.Interfaces;

namespace Support.CallCenter.Ui.Controllers
{
    public class IncomingNotesController : ApiController
    {
        private readonly IIncomingNotesService mIncomingNotesService;

        public IncomingNotesController(IIncomingNotesService incomingNotesService)
        {
            mIncomingNotesService = incomingNotesService;
        }

        public void PostNewIncomingNote(CreateIncomingNoteRequest noteContract)
        {
            var currentUser = User;
            mIncomingNotesService.CreateIncomingNote(noteContract, currentUser.Identity);
        }
    }
}
