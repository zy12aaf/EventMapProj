using System;

namespace Domain.Models
{
    public class ImportModel
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string CompanyName { get; set; }
        public string CompanySize { get; set; }
        public string CompanyWebsite { get; set; }
        public string EventType { get; set; }
        public string EventName { get; set; }
        public string EventLocation { get; set; }
        public string EventPostcode { get; set; }
        public string EventMp { get; set; }
        public string EventMedia { get; set; }
        public bool EventOpenPublic { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string EventDescription { get; set; }
        public string EventAttendees { get; set; }
        public string EventAudience { get; set; }
        public bool EventShowOnWebsite { get; set; }
        public DateTime New { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Delete { get; set; }
        public bool IsDeleted { get; set; }
        public float EventLat { get; set; }
        public float EventLng { get; set; }
        public string EventRegion { get; set; }
        public string CompanyTwitterHandle { get; set; }
        public string CompanyFacebookPage { get; set; }
        public string EventMainAudience { get; set; }
        public bool EventInvitingLocalMp { get; set; }
        public string EventLocalMpName { get; set; }
        public string EntityState { get; set; }
        public string EntityKey { get; set; }
    }
}
