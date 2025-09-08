namespace CookingSharp.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string surname, string email, string password)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(name));
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentException("El apellido no puede ser nulo o vacío.", nameof(surname));
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("El correo electrónico no puede ser nulo o vacío.", nameof(email));
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("La contraseña no puede ser nula o vacía.", nameof(password));
            }
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;

        }


    }
}
