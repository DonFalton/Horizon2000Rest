# Horizon2000Rest

## Introduction

Horizon2000Rest is a Web API solution built in VisualStudio, utilizing the Entity Framework ASP.NET 6 with the C# language. The purpose of this project is to interact with a remote database, providing endpoints to create, read, update, and delete data.

## Structure

The solution consists of three projects:

1. **Horizon2000Rest (Web API)**
2. **Horizon2000Rest.Core (Class Library)**
3. **Horizon2000Rest.Entity (Class Library)**

### Horizon2000Rest (Web API)

This project is the main entry point for the application. It references the Horizon2000Rest.Core project and includes the following important elements:

- Package references to `Microsoft.EntityFrameworkCore.Design` and `Swashbuckle.AspNetCore`.
- A `Controllers` folder (this is where the API endpoints will be defined).
- A project reference to the `Horizon2000Rest.Core` project.

### Horizon2000Rest.Core (Class Library)

This project contains core functionality and business logic. It references the Horizon2000Rest.Entity project and includes:

- A package reference to `Microsoft.EntityFrameworkCore.Design`.
- A project reference to the `Horizon2000Rest.Entity` project.

### Horizon2000Rest.Entity (Class Library)

This project contains all data-related functionality, including the entities and the DbContext. It includes:

- Package references to `Microsoft.EntityFrameworkCore`, `Microsoft.EntityFrameworkCore.Design`, `Microsoft.EntityFrameworkCore.SqlServer`, and `Microsoft.EntityFrameworkCore.Tools`.
- A `Migrations` folder (this is where Entity Framework migrations will be stored).
- A series of classes in the `Models` folder that serve as templates for the tables, rows, data types, and relationships to be created in the database.

## Database

The solution connects to a remote database via the connection string provided in the `appsettings.json` file located in the `Horizon2000Rest` project.

In the `Horizon2000Rest.Entity` project, the `Models` folder includes classes that define the structure and relationships of the database tables. An example of such a class is `StudentCourseSkillCardDbo.cs`.

The `Data` folder contains a class named `HorizonContext.cs` that inherits from `Microsoft.EntityFrameworkCore.DbContext`. It includes methods `OnConfiguring` and `OnModelCreating(ModelBuilder modelBuilder)` that define the relationships between tables and seed data to populate the tables.

## Usage

To migrate the information from the `Horizon2000Rest.Entity` project to the `Horizon2000*NAME*` database, run the following command in the terminal:

```
Add-Migration InitialCrate -Project Horizon2000Rest.Entity
```

This command will create the tables (if they do not exist) and populate them with seed data.

To update the databse from the `Horizon2000Rest.Entity` project to the `Horizon2000*NAME*` database, run the following command in the terminal:

```
Update-Database -Project Horizon2000Rest.Entity
```

