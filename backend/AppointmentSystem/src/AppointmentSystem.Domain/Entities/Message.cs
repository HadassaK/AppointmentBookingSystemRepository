using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Reflection.Metadata;
using System.Text;

namespace AppointmentSystem.Domain.Entities
{
    internal class Message
    {
        public Guid Id { get; set; } //(PK)
        public Guid ClinicId { get; set; } //(FK → clinic.id)
        public Guid UserId { get; set; } //(FK → user.id) נשלח למי
        public Enum Type { get; set; }//type(reminder / marketing / retention)
        public Enum Channel { get; set; } //channel(sms / email / whatsapp)
        public string Content { get; set; } // קטן מידי?
        public DateTime SentAt { get; set; }
        public DateTime DeliveredAt { get; set; }//(nullable)
        public DateTime ReadAt { get; set; }//(nullable)

    }
}
