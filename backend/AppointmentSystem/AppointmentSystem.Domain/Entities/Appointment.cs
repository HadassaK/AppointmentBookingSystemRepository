using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentSystem.Domain.Entities
{
    internal class Appointment
    {
        public Guid Id { get; set; }
        public Guid ClinicId { get; set; } // (FK → clinics.id)
        public Guid ServiceId { get; set; } // (FK → services.id)
        public Guid ProviderUderId { get; set; } //(FK → users.id) נותן השירות
        public Guid ClientUserid { get; set; } // (FK → users.id)
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Enum Status { get; set; }//status(scheduled / cancelled / completed / no_show)
        public DateTime CreatedAt { get; set; }
    }
}
