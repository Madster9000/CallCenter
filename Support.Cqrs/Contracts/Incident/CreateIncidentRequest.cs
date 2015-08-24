using System;

namespace Support.Cqrs.Contracts.Incident
{
    public class CreateIncidentRequest
    {
        public Guid Id { get; set; }
        public bool CloseAfterRegistration { get; set; }
        public bool IsSupportIncident { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public int Specialization { get; set; }
        public Guid ContactId { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid FunctionalId { get; set; }
        public Guid SubjectId { get; set;}
        public string CloseReason { get; set; }
    }
}