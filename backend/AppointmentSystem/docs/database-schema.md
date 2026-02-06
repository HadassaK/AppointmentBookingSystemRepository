# Database Schema

This document describes the logical database schema of the Appointment Management System.
The schema is technology-agnostic and represents the system contract.

---

## Users

Represents a real person in the system.
A user can be a client, a service provider, or an admin in one or more clinics.

### Table: users

- id (guid, PK)
- first_name
- last_name
- phone (unique)
- email (nullable, unique)
- created_at
- updated_at

Notes:
- Users are global across the system.
- No clinic or role is stored here.

---

## Clinics

Represents a business entity (clinic).

### Table: clinics

- id (guid, PK)
- name
- business_id (VAT / Company ID)
- address
- phone
- is_active
- created_at
- updated_at

---

## Clinic Users (Staff)

Represents system users that operate or manage a clinic.

### Table: clinic_users

- id (guid, PK)
- clinic_id (FK → clinics.id)
- user_id (FK → users.id)
- role (enum: provider, admin, secretary)
- status (active / inactive)
- created_at

Notes:
- Used for authorization and permissions.
- A user can have different roles in different clinics.

---

## Clients

Represents clients of a specific clinic.
Stores business and treatment-related data.

### Table: clients

- id (guid, PK)
- clinic_id (FK → clinics.id)
- user_id (FK → users.id)
- notes (nullable)
- preferences (json, nullable)
- status (active / archived)
- created_at

Notes:
- A user may be a client in multiple clinics.
- Client data is isolated per clinic.

---

## Services

Represents services or treatments offered by a clinic.

### Table: services

- id (guid, PK)
- clinic_id (FK → clinics.id)
- name
- duration_minutes
- price (nullable)
- is_active
- created_at

Notes:
- Contains only service definition.
- No scheduling information is stored here.

---

## Availability Rules

Defines availability and unavailability rules for service providers.

### Table: availability_rules

- id (guid, PK)
- clinic_id (FK → clinics.id)
- provider_user_id (FK → users.id)
- type (weekly / date_range / single_date)
- day_of_week (nullable)
- start_time (nullable)
- end_time (nullable)
- start_date (nullable)
- end_date (nullable)
- is_available (boolean)
- created_at

Notes:
- Used to calculate available appointment slots.
- Rules-based, not actual bookings.

---

## Appointments

Represents a scheduled appointment.

### Table: appointments

- id (guid, PK)
- clinic_id (FK → clinics.id)
- service_id (FK → services.id)
- provider_user_id (FK → users.id)
- client_id (FK → clients.id)
- start_datetime
- end_datetime
- status (scheduled / cancelled / completed / no_show)
- created_at

---

## Messages

Stores records of messages sent to users.

### Table: messages

- id (guid, PK)
- clinic_id (FK → clinics.id)
- user_id (FK → users.id)
- type (reminder / marketing / retention)
- channel (sms / email / whatsapp)
- content
- sent_at
- delivered_at (nullable)
- read_at (nullable)

Notes:
- This table is for logging and tracking only.
- Actual message delivery is handled by an external service.

---

## Relationships Summary

- User → ClinicUser → Clinic
- User → Client → Clinic
- Clinic → Services
- Clinic → Appointments
- Clinic → AvailabilityRules
- Clinic → Messages

---

End of document.
