using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace AppointmentSystem.Domain.Entities
{
    internal class Clinic
    {
        public Guid Id { get; set; } // (PK)
        public string Name { get; set; }
        public long BusinessId { get; set; } // (ח.פ / עוסק) unique?
        public long Phone { get; set; } // (unique)
        public string Email { get; set; } // (nullable, unique)
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
