using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Event
    {
        #region Referencing properties

        public int? ArrangerId { get; set; }
        public Arranger Arranger { get; set; }
        public int? LocationID { get; set; }
        public Location Location { get; set; }
        public int? CompanyID { get; set; }
        public Company Company { get; set; }

        #endregion

        #region Raw properties

        public int EventId { get; set; }
        public EventType Type { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> LocalMpName { get; set; }
        public bool EventMedia { get; set; }
        public bool OpenToPublic { get; set; }
        public DateTime DateOfEvent { get; set; }
        public string Description { get; set; }
        public string Attendees { get; set; }
        public Audience MainAudience { get; set; }
        public bool ShowOnWebsite { get; set; }

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
