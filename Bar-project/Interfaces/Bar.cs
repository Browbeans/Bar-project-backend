using System;
using Bar_project.Enums;

namespace Bar_project.Interfaces
{
    public interface Bar
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BarCategory Category { get; set; }
        public string Founded { get; set; }
        public Guid AdressCode { get; set; }
        public Guid ContactCode { get; set; }
        public Guid ImageCode { get; set; }
        public Guid MenuCode { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
