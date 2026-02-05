using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace AppointmentSystem.Domain.Entities
{
    internal class Client
    {
        public Guid Id { get; set; }// (PK)
        public Guid ClinicId { get; set; } //(FK → clinics.id)
        public Guid UserId { get; set; } //(FK → users.id)
        public string Note { get; set; }
        public string Preferences { get; set; } // (json / nullable)
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
