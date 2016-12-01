using Domain.Models;

namespace Domain.Converters
{
    public static class ImportConverter
    {
        public static Event ConvertEvents(this ImportModel importModel)
        {
            return new Event
            {
                EventId = importModel.Id,
                //Type
                EventName = importModel.EventName,
                EventLocalMpName = importModel.EventLocalMpName,
                //EventMedia
                OpenToPublic = importModel.EventOpenPublic,
                EventDate = importModel.EventDate,
                EventTime = importModel.EventTime,
                Description = importModel.EventDescription,
                Attendees = importModel.EventAttendees,
                //MainAudience
                EventShowOnWebsite = importModel.EventShowOnWebsite,

                Arranger = new Arranger()
                {
                    Id = importModel.Id,
                    ContactName = importModel.ContactName,
                    ContactEmail = importModel.ContactEmail,
                    ContactPhone = importModel.ContactPhone
                },

                Location = new Location()
                {
                    LocationId = importModel.Id,
                    //Address
                    EventPostcode = importModel.EventPostcode,
                    //ContactPostcode?
                    EventLat = importModel.EventLat,
                    EventLng = importModel.EventLng,
                    //Region
                    EventName = importModel.EventName
                },

                Company = new Company()
                {
                    Id = importModel.Id,
                    CompanyName = importModel.CompanyName,
                    CompanySize = importModel.CompanySize,
                    CompanyTwitterHandle = importModel.CompanyTwitterHandle,
                    CompanyWebsite = importModel.CompanyWebsite,
                    CompanyFacebookPage = importModel.CompanyFacebookPage
                }
            };
        }
    }
}
