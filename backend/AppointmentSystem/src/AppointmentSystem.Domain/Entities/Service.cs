using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Xml.Linq;

namespace AppointmentSystem.Domain.Entities
{
    internal class Service
    {
        public Guid Id { get; set; }//(PK, guid)
        public Guid ClinicId { get; set; } //(FK → clinics.id)
        public string Name { get; set; }
        public int DurationMinutes { get; set; }
        public double Price { get; set; } //(nullable)
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
