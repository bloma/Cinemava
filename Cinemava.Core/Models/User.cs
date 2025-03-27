
namespace Cinemava.Core.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public User() { }
        public User(Guid id, string? name, string? surname, string? email, string? password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
        }
    }
}
