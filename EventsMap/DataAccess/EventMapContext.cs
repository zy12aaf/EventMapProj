using System.Data.Entity;
using Domain.Models;

namespace DataAccess
{
    public class EventMapContext : DbContext
    {
        

        public EventMapContext() : base("EventsMap")
        {
        }

        public DbSet<Arranger> Arranger { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventEntityInfo> EventEntityInfo { get; set; }
        public DbSet<EventTimestamps> EventTimestamps { get; set; }
        public DbSet<Location> Locations { get; set; }

    }
}
