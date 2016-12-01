using System.Collections.Generic;
using System.Linq;
using Domain.Models;

namespace DataAccess
{
    public class LocationRepo
    {
        EventMapContext context = new EventMapContext();

        public void Add(Location l)
        {
            context.Locations.Add(l);
            context.SaveChanges();
        }

        public IEnumerable<Location> Locations()
        {
            return context.Locations.ToList();
        }
    }
}
