namespace CookingSharp.Domain
{
    /// <summary>
    /// Representa un usuario en el dominio del negocio.
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        /// <summary>
        /// Constructor para crear una nueva instancia de Usuario.
        /// </summary>
        public User(int id, string name, string surname, string email, string password)
        {
            Id = id;
            UpdateProfile(name, surname, email);
            ChangePassword(password);
        }

        /// <summary>
        /// Actualiza la información del perfil del usuario, aplicando las reglas de validación.
        /// </summary>
        public void UpdateProfile(string name, string surname, string email)
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

            Name = name;
            Surname = surname;
            Email = email;
        }

        /// <summary>
        /// Cambia la contraseña del usuario, aplicando las reglas de validación de seguridad.
        /// </summary>
        public void ChangePassword(string newPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                throw new ArgumentException("La contraseña no puede ser nula o vacía.", nameof(newPassword));
            }
            if (newPassword.Length < 8)
            {
                throw new ArgumentException("La contraseña debe tener al menos 8 caracteres.", nameof(newPassword));
            } //TO DO: sumarle requisitos, quizás con exp reg

            Password = newPassword;
        }
    }
}