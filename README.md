# Shared Kernel for Clean Architecture & DDD

This repository contains a **Shared Kernel** that provides reusable domain logic and cross-cutting concerns for solutions following the principles of **Clean Architecture** and **Domain-Driven Design (DDD)**. It encapsulates shared business logic and abstractions that are applicable across multiple bounded contexts.

## Key Features

- **Domain Entities**: Common entities that can be reused across contexts.
- **Value Objects**: Immutable, shared value objects like `Money`, `Address`, etc.
- **Domain Events**: Shared domain events to ensure consistency across contexts.
- **Domain Errors**: the base class for the errors
- **Domain Exception**
- **Result Pattern**
- **CQRS Pattern**
- **Cross-Cutting Concerns**: Common patterns like base classes, utilities, and shared logic.

## Folder Structure

```bash
source code/
  └── CASolution.SharedKernel/
      ├──  Entites/
      ├──  Domain Errors/
      ├──  Domain Events/
      ├──  Utilities/
      |     └── Result/
      ├──  CQRS /
      ├──  Specification/
      └──  Unit of work/
