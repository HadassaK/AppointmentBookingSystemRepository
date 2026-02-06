# Architectural Decisions

This document tracks major architectural decisions and their rationale.

---

## Single Database with Multi-Tenancy

Decision:
- Use a single database with clinic-based isolation.

Rationale:
- Faster development
- Easier maintenance
- Lower operational complexity

Future:
- Can be migrated to database-per-clinic if needed.

---

## Separate Client and ClinicUser Tables

Decision:
- Separate tables for clinic staff and clinic clients.

Rationale:
- Clear separation of responsibilities
- Cleaner authorization model
- Avoids mixing business and system concerns

---

## External Messaging Service

Decision:
- Messaging handled by an external service.

Rationale:
- Decoupling
- Independent scaling
- Improved reliability

---

End of document.
