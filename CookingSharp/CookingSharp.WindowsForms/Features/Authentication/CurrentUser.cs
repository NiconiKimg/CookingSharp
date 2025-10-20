using static CookingSharp.Domain.User; // Para poder usar RoleTypes

namespace CookingSharp.WindowsForms
{
    public class CurrentUser
    {
        public int Id { get; }
        public string Email { get; }
        public RoleTypes Role { get; }

        public CurrentUser(int id, string email, RoleTypes role)
        {
            Id = id;
            Email = email;
            Role = role;
        }
    }
}