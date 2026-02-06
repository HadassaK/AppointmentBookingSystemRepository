using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentSystem.Domain.Entities
{
    internal class ClinicUser
    {
        public Guid Id { get; set; } //(PK)
        public Guid ClinicId { get; set; } //(FK → clinic.id)
        public Guid UserId { get; set; } //(FK → user.id)
        public Enum Role { get; set; } // (enum: provider / admin / secretary)
        public bool IsActive { get; set; } //status(active / inactive)
        public DateTime CreatedDate { get; set; }

    }
}
