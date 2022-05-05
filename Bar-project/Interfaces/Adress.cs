using System;
namespace Bar_project.Interfaces
{
    public interface Adress
    {
        public Guid Code { get; set; }
        public string Streetname { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
}
