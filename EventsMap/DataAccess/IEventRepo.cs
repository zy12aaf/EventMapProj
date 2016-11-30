using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace DataAccess
{
    public interface IEventRepo : IDisposable
    {
        IEnumerable<Event> GetEvents();
        Event GetEventByID(int eventId);
        void InsertEvent(Event apprenticeEvent);
        void DeleteEvent(int apprenticeEvent);
        void UpdateEvent(Event apprenticeEvent);
        void Save();
    }
}
