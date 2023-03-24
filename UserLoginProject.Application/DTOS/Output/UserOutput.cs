using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Application.DTOS.Output
{
    public class UserOutput
    {
        public UserOutput(Guid id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public static UserOutput FromEntity(User user)
        {
            return new UserOutput(user.Id, user.Name, user.Email, user.Password);
        }
    }
}
