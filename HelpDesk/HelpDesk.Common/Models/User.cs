using Newtonsoft.Json;

namespace HelpDesk.Common.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsEmployee { get; set; } = false;
        public string? Function { get; set; }
        public string? Department { get; set; }

        public User() { }

        [JsonConstructor]
        private User(int id, string name, string login, string password, string email, bool isEmployee, string? function, string? department)
        {
            Id = id;
            Name = name;
            Login = login;
            Password = password;
            Email = email;
            IsEmployee = isEmployee;
            Function = function;
            Department = department;
        }
    }
}