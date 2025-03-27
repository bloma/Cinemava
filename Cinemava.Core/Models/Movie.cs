
namespace Cinemava.Core.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime ReleasedDate { get; set; }
        public Movie() { }
        public Movie(Guid id, string? name, string? description, DateTime releasedDate)
        {
            Id = id;
            Name = name;
            Description = description;
            ReleasedDate = releasedDate;
        }
    }
}
