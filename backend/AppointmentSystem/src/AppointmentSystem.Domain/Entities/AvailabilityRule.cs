using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace AppointmentSystem.Domain.Entities
{
    internal class AvailabilityRule
    {
        public Guid Id { get; set; }
        public Guid ClinicId { get; set; } //(FK → clinics.id)
        public Guid ProviderUserId { get; set; } //(FK → users.id)   ← נותן השירות
        public Enum Type { get; set; } //(enum: weekly / date_range / single_date)
        public int DayOfWeek { get; set; } //(nullable, 0–7)
        public TimeOnly StartTime { get; set; } //(nullable)
        public TimeOnly EndTime { get; set; } //(nullable)
        public DateOnly StartDate { get; set; } //(nullable)
        public DateOnly EndDate { get; set; } //(nullable)
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
