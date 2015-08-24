using System;

namespace Support.Cqrs.Contracts.IncomingNote
{
    public class CreateIncomingNoteRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CallId { get; set; }
        public Guid ContactId { get; set; }
        public Guid IncidentId { get; set; }
    }
}