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
```

2. Update the connection string in `Program.cs` (or `ApplicationDbContextFactory.cs`) to match your SQL Server:

```csharp
optionsBuilder.UseSqlServer("Server=localhost;Database=ECommerceDb;Trusted_Connection=True;TrustServerCertificate=True;");
```

1. Run EF Core migrations:

```powershell
Add-Migration InitialCreate
Update-Database
```

4. Run the console app:

```bash
dotnet run
```

---

## Project Structure

```txt
ECommerce/
│
├─ Configurations/
│ ├─ CategoryConfig.cs
│ ├─ CustomerConfig.cs
│ ├─ OrderConfig.cs
│ ├─ OrderItemConfig.cs
│ └─ ProductConfig.cs
│
├─ Data/
│ ├─ ApplicationDbContext.cs
│ └─ ApplicationDbContextFactory.cs
│
├─ Migrations/
│ ├─ 20250827181845_AddCategoryAndCustomerAndOrderAndOrderItemsAndProductTables.cs
│ └─ ApplicationDbContextModelSnapshot.cs
│
├─ Models/
│ ├─ Category.cs
│ ├─ Customer.cs
│ ├─ Order.cs
│ ├─ OrderItem.cs
│ └─ Product.cs
│
├─ EFCoreQueries.cs
├─ GlobalUsings.cs
├─ Program.cs
├─ .editorconfig
├─ bin/
└─ obj/
```

---

## Notes

- Seed data uses **static values** for migrations to avoid EF Core “model changes every build” warnings.
- Runtime code can still use `DateTime.UtcNow` or `Guid.NewGuid()` for dynamic data.

---

## License

This project is licensed under the MIT License.
