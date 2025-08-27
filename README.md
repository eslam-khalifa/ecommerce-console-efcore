# ecommerce-console-efcore

A simple **E-commerce Console Application** built using **EF Core (Code First + Fluent API)** in .NET 8.  

This project demonstrates a small relational database with multiple entity relationships, migrations, data seeding, and LINQ queries.

---

## Features

- **Database Design (EF Core Code First)**:
  - Customers, Orders, Products, Categories, OrderItems
  - One-to-One, One-to-Many, and Many-to-Many relationships
  - Fully configured using Fluent API

- **Database Migrations**:
  - EF Core migrations with SQL Server
  - Seed initial data for testing

- **Queries**:
  - Filtering, projections, and navigation property access
  - Example queries in `EFCoreQueries` class

- **Runtime**:
  - Console application that lists customers, orders, products, and order details
  - Demonstrates how to work with EF Core in a console environment

---

## Getting Started

### Prerequisites

- .NET 8 SDK
- SQL Server (local or remote)
- Visual Studio 2022 / 2023 or VS Code

### Setup

1. Clone the repository:

```bash
git clone https://github.com/your-username/ECommerceEFCore.git
