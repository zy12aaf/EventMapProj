using Domain.Models;

namespace DataAccess
{
    public static class ImportConverter
    {
        public static Event ConvertEvents(this ImportModel importModel)
        {
            return new Event
            {
                EventId = importModel.Id,
                //Type
                Name = importModel.EventName,
                LocalMpName = importModel.EventLocalMpName,
                //EventMedia
                OpenToPublic = importModel.EventOpenPublic,
                DateOfEvent = importModel.EventDateTime,
                Description = importModel.EventDescription,
                Attendees = importModel.EventAttendees,
                //MainAudience
                ShowOnWebsite = importModel.EventShowOnWebsite,

                Arranger = new Arranger()
                {
                    Id = importModel.Id,
                    Contact_Name = importModel.ContactName,
                    Contact_Email = importModel.ContactEmail,
                    Contact_Phone = importModel.ContactPhone
                },

                Location = new Location()
                {
                    LocationId = importModel.Id,
                    //Address
                    Postcode = importModel.EventPostcode,
                    //ContactPostcode?
                    Latitude = importModel.EventLat,
                    Longtitude = importModel.EventLng,
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
