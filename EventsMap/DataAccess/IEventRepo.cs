using System;
using System.Collections.Generic;
using Domain.Models;

namespace DataAccess
{
    public interface IEventRepo : IDisposable
    {
        IEnumerable<Event> GetEvents();
        Event GetEventById(int eventId);
        void InsertEvent(Event apprenticeEvent);
        void DeleteEvent(int apprenticeEvent);
        void UpdateEvent(Event apprenticeEvent);
        void Save();
    }
}
