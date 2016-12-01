using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using Domain.Models;

namespace Domain.Mappers
{
    public class ImportMappers : CsvClassMap<ImportModel>
    {
        public void CsvToModel()
        {
            Map(m => m.CompanyName).Name("Company_Name");
            Map(m => m.ContactAddressOne).Name("Contact_Address1");
            Map(m => m.ContactAddressTwo).Name("Contact_Address2");
            Map(m => m.ContactCity).Name("Contact_City");
            Map(m => m.ContactRegion).Name("Contact_Region");
            Map(m => m.ContactPostcode).Name("Contact_Postcode");
            Map(m => m.ContactEmail).Name("Contact_Email");
            Map(m => m.ContactPhone).Name("Contact_Phone");
            Map(m => m.ContactLat).Name("Contact_Lat");
            Map(m => m.ContactLng).Name("Contact_Lng");
            Map(m => m.CompanyName).Name("Company_Name");
            Map(m => m.CompanySize).Name("Company_Size");
            Map(m => m.EventType).Name("Event_Type");
            Map(m => m.EventOpenPublic).Name("Event_Open_Public");
            Map(m => m.EventDateTime).Name("Event_DateTime");
            Map(m => m.EventDescription).Name("Event_Description");
            Map(m => m.EventAttendees).Name("Event_Attendees");
            Map(m => m.EventShowOnWebsite).Name("Event_Show_On_Website");
            Map(m => m.ApprovedBySitecoreId).Name("ApprovedBy_sitecore_id");
            Map(m => m.EventName).Name("Event_Name");
            Map(m => m.EventPostcode).Name("Event_Postcode");
            Map(m => m.EventLat).Name("Event_Lat");
            Map(m => m.EventLng).Name("Event_Lng");
            Map(m => m.EventRegion).Name("Event_Region");
            Map(m => m.CompanyTwitterHandle).Name("Company_Twitter_Handle");
            Map(m => m.CompanyWebsite).Name("Company_Website");
            Map(m => m.CompanyFacebookPage).Name("Company_FacebookPage");
            Map(m => m.EventMainAudience).Name("Event_Main_Audience");
            Map(m => m.EventInvitingLocalMp).Name("Event_InvitingLocalMP");
            Map(m => m.EventLocalMpName).Name("Event_LocalMPName");
        }
    }
}
