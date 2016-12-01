namespace Domain.Models
{
    public class EventEntityInfo
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public bool Approved { get; set; }
        public bool IsDeleted { get; set; }
    }
}
