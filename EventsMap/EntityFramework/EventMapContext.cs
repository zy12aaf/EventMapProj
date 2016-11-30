using System.Data.Entity;
using Domain;

namespace DataAccess
{
    public class EventMapContext : DbContext
    {
        public DbSet<Location> Locations;
    }
}
