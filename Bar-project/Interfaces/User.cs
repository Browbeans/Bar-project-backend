using System;
namespace Bar_project.Interfaces
{
    public interface User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
    }
}
