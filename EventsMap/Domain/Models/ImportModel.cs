using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace Domain.Models
{
    public class ImportModel
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string ContactAddressOne { get; set; }
        public string ContactAddressTwo { get; set; }
        public string ContactCity { get; set; }
        public string ContactRegion { get; set; }
        public string ContactPostcode { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public float ContactLat { get; set; }
        public float ContactLng { get; set; }
        public string CompanyName { get; set; }
        public string CompanySize { get; set; }
        public string EventType { get; set; }
        public bool EventOpenPublic { get; set; }
        public DateTime EventDateTime { get; set; }
        public string EventDescription { get; set; }
        public string EventAttendees { get; set; }
        public bool EventShowOnWebsite { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime Approved { get; set; }
        public string ApprovedBySitecoreId { get; set; }
        public bool IsDeleted { get; set; }
        public string EventName { get; set; }
        public string EventPostcode { get; set; }
        public float EventLat { get; set; }
        public float EventLng { get; set; }
        public string EventRegion { get; set; }
        public string CompanyTwitterHandle { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyFacebookPage { get; set; }
        public string EventMainAudience { get; set; }
        public bool EventInvitingLocalMp { get; set; }
        public string EventLocalMpName { get; set; }
        public string EntityState { get; set; }
        public string EntityKey { get; set; }
    }
}
