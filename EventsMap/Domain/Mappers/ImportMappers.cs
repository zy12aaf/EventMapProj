using CsvHelper.Configuration;
using Domain.Models;

namespace Domain.Mappers
{
    public class ImportMappers : CsvClassMap<ImportModel>
    {
        public void CsvToModel()
        {
            Map(m => m.CompanyName).Name("Contact_Name");
            Map(m => m.ContactEmail).Name("Contact_Email");
            Map(m => m.ContactPhone).Name("Contact_Phone");
            Map(m => m.CompanyName).Name("Company_Name");
            Map(m => m.CompanySize).Name("Company_Size");
            Map(m => m.CompanyWebsite).Name("Company_Website");
            Map(m => m.EventType).Name("Event_Type");
            Map(m => m.EventName).Name("Event_Name");
            Map(m => m.EventLocation).Name("Event_Location");
            Map(m => m.EventPostcode).Name("Event_Postcode");
            Map(m => m.EventMp).Name("Event_MP");
            Map(m => m.EventMedia).Name("Event_Media");
            Map(m => m.EventOpenPublic).Name("Event_Open_Public");
            Map(m => m.EventDate).Name("Event_Date");
            Map(m => m.EventTime).Name("Event_Time");
            Map(m => m.EventDescription).Name("Event_Description");
            Map(m => m.EventAttendees).Name("Event_Attendees");
            Map(m => m.EventAudience).Name("Event_Audience");
            Map(m => m.EventShowOnWebsite).Name("Event_Show_On_Website");
            Map(m => m.EventLat).Name("Event_Lat");
            Map(m => m.EventLng).Name("Event_Lng");
            Map(m => m.EventRegion).Name("Event_Region");
            Map(m => m.CompanyTwitterHandle).Name("Company_Twitter_Handle");
            Map(m => m.CompanyFacebookPage).Name("Company_FacebookPage");
            Map(m => m.EventMainAudience).Name("Event_Main_Audience");
            Map(m => m.EventInvitingLocalMp).Name("Event_InvitingLocalMP");
            Map(m => m.EventLocalMpName).Name("Event_LocalMPName");
        }
    }
}
