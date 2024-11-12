namespace Gymbokning.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime => StartTime + Duration; // EndTime beräknas från StartTime och Duration
        public string Description { get; set; }

        public GymClass(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
