# LogicBuilder.Samples.Enrollment.Spa.Flow

This repository contains a comprehensive sample enrollment application demonstrating the use of **LogicBuilder** with a modern Single Page Application (SPA) architecture. The application showcases how business rules and flow logic can be externalized from code and managed declaratively using LogicBuilder's rules engine.

## Overview

The **Enrollment.Spa.Api** backend service provides RESTful endpoints that are consumed by an Angular client. The API dynamically defines screen configurations and navigation flows based on embedded rulesets, enabling a truly flow-driven user interface where business logic and screen behavior are managed independently from the frontend presentation layer.

## Architecture

The solution follows a clean, layered architecture:

### Projects

- **Enrollment.Spa.Api** (.NET 10)  
  ASP.NET Core Web API that serves as the backend for the Angular SPA. Provides endpoints for flow navigation, screen definitions, and data operations.

- **Enrollment.Spa.Flow** (.NET 10)  
  Core flow management library containing:
  - Embedded rulesets (`.module` and `.resources` files) defining screens and navigation logic
  - Flow execution services and rule processing
  - AutoMapper profiles for data transformation
  - Integration with LogicBuilder's RulesDirector

- **Enrollment.Domain** (.NET Standard 2.0)  
  Domain models and business entities with LogicBuilder attributes for the enrollment process.

- **Enrollment.Data** (.NET Standard 2.0)  
  Data access layer with Entity Framework Core integration.

- **Enrollment.Spa.Flow.Tests** (.NET 10)  
  Unit tests for the flow management components.

### Key Features

- **Flow-Driven Navigation**: Screen sequences and navigation rules are defined in embedded rulesets (e.g., `home.module`, `personal.module`, `admissions.module`, etc.)
- **Dynamic Screen Generation**: The API generates screen configurations based on business rules
- **Rules-Based Business Logic**: Complex enrollment workflows managed declaratively through LogicBuilder
- **Separation of Concerns**: Business logic is independent of UI presentation
- **Docker Support**: Includes Docker Compose configuration for containerized deployment

### Flow Modules

The solution includes rulesets for various enrollment screen flows:
- Initial/Home
- Personal Information
- Contact Information
- Residency
- Academic History
- Admissions
- Certification
- More Info
- Admin
- Report

Each module has corresponding navigation rules (e.g., `nav_personal.module`) that control flow transitions.

## Technologies

- **.NET 10** - Modern .NET for API and flow services
- **.NET Standard 2.0** - Cross-platform domain and data layers
- **LogicBuilder** - Rules engine and flow management
  - LogicBuilder.RulesDirector
  - LogicBuilder.EntityFrameworkCore
  - LogicBuilder.App.Spa packages
- **Entity Framework Core** - Data persistence
- **AutoMapper** - Object-to-object mapping
- **Angular** (Client) - SPA frontend consuming the API
- **Docker** - Containerization support

## Purpose

This sample demonstrates how to build maintainable, enterprise-grade applications where:
- Business rules and navigation flows are externalized from code
- Screen definitions and validation logic are managed declaratively
- Changes to business logic don't require code recompilation
- Frontend and backend concerns are cleanly separated
- Complex enrollment workflows can be modified through rule configuration rather than code changes

This architecture is ideal for applications requiring frequent business rule changes, complex conditional navigation, or multiple variations of the same workflow.