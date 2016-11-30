using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Dto
{
    public class EventDto
    {
        public EventDto(string eventName, string address, string postcode, double latitude, double longtitude, Region region, DateTime eventDate, string eventDescription)
        {
            EventName = eventName;
            Address = address;
            Postcode = postcode;
            Latitude = latitude;
            Longtitude = longtitude;
            Region = region;
            EventDate = eventDate;
            EventDescription = eventDescription;
        }

        public string EventName { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public Region Region { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
    }
}
