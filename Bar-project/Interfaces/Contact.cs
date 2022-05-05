using System;
namespace Bar_project.Interfaces
{
    public interface Contact
    {
        public Guid Code { get; set; }
        public int Phonenumber { get; set; }
        public string EmailAdress { get; set; }
    }
}
