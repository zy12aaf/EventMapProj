using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Domain.Models
{
    public class Event
    {
        #region Referencing properties
        public int? ContactId { get; set; }
        public Contact Contact { get; set; }

        public int? CompanyId { get; set; }
        public Company Company { get; set; }

        public int? ArrangerId { get; set; }
        public Arranger Arranger { get; set; }

        public int? LocationId { get; set; }
        public Location Location { get; set; }
        #endregion

        #region Raw properties
        public int EventId { get; set; }
        public EventType Type { get; set; }
        public string EventName { get; set; }
        public string EventMp { get; set; }
        public bool EventMedia { get; set; }
        public bool OpenToPublic { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string Description { get; set; }
        public string Attendees { get; set; }
        public string EventAudience { get; set; }
        public bool EventShowOnWebsite { get; set; }
        public DateTime New { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Delete { get; set; }
        public bool IsDelete { get; set; }
        public Audience MainAudience { get; set; }
        public bool EventInvitingLocalMp { get; set; }
        public string EventLocalMpName { get; set; }
        public string EntityState { get; set; }
        public string EntityKey { get; set; }
        #endregion

        #region Enums
        public enum EventType
        {
            [EnumMember(Value = "Open-Evening")]
            OpenEvening,
            [EnumMember(Value = "Apprenticeship-Information-Session")]
            ApprenticeshipInformationSession, 
            [EnumMember(Value = "Apprenticeship job fair")]
            ApprenticeJobFair
        }

        public enum Audience
        {
            [Display(Name = "Potential apprentices")]
            PotentialApprentice,
            [Display(Name = "Parents")]
            Parents
        }
        #endregion
    }
}
