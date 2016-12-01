using System;
using System.ComponentModel;
using Domain.Enums;
using Domain.Models;

namespace Domain
{
    public class SearchingModel
    {
        public SearchingModel() {
            BeginningRange = DateTime.MinValue;
            EndingRange = DateTime.MaxValue;
        }
        [DisplayName("All Events")]
        public Event.EventType? Type { get; set; }
        [DisplayName("All Regions")]
        public Region? Region { get; set; }
        [DisplayName("Enter Postcode")]
        public LatLong PostCode { get; set; }
        [DisplayName("Enter keyword")]
        public string Keyword { get; set; }
        [DisplayName("All Audiences")]
        public Event.Audience? MainAudience { get; set; }
        public DateTime? BeginningRange { get; set; }
        public DateTime? EndingRange { get; set; }
        [DisplayName("Pick date of event")]
        public DateTime? DateOfEvent { get; set; }
        [DisplayName("Radius")]
        public Distance? SearchWithinRadius { get; set; }
        public PagingInformation PagingInformation { get; set; }
    }
}