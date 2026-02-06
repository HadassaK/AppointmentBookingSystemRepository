using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Xml;

namespace AppointmentSystem.Domain.Entities
{
    internal class User
    {
        public Guid Id { get; set; } // (PK)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; } // (unique)
        public string Email { get; set; } // (nullable, unique)
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
