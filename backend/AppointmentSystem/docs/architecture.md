# System Architecture

This document describes the high-level architecture of the Appointment Management System.

---

## Overview

The system is designed as a modular monolith with clear separation of concerns,
allowing future extraction of services if needed.

---

## Core Principles

- Single database (multi-tenant by clinic)
- Logical isolation via clinic_id
- Clear separation between:
  - Domain logic
  - Application use cases
  - Infrastructure concerns

---

## Project Structure

- Api – HTTP endpoints, authentication, authorization
- Application – Business logic and use cases
- Domain – Entities, value objects, enums
- Persistence – EF Core, DbContext, migrations
- Infrastructure – External integrations (excluding messaging service)
- Docs – Architecture and schema documentation

---

## Messaging

- Messaging (SMS / Email / WhatsApp) is handled by a separate service.
- The core system only:
  - Requests message sending
  - Logs message results

---

## Scalability Notes

- Clinics are isolated logically via clinic_id.
- Physical database separation can be introduced later if required.

---

End of document.
