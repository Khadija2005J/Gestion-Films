# Gestion Films

**A movie management web application built with ASP.NET Core MVC and Entity Framework Core.**

Create, view, edit and delete movies through a clean interface, with server-side validation on every field.

## Features

- Full CRUD on movies: title, director, release year, genre and rating
- Validation: required fields, year between 1900 and 2100, rating between 0 and 10
- SQLite database managed with EF Core migrations
- Responsive layout with Bootstrap

## Tech stack

| Layer | Tools |
|-------|-------|
| Framework | ASP.NET Core MVC (.NET 10) |
| ORM | Entity Framework Core |
| Database | SQLite |
| UI | Razor views, Bootstrap, jQuery Validation |

## Project structure

```
GestionFilms.Web/
├── Controllers/FilmsController.cs   # CRUD actions
├── Models/Film.cs                   # Film entity and validation rules
├── Data/ApplicationDbContext.cs     # EF Core context
├── Migrations/                      # Database schema
└── Views/Films/                     # Index, Create, Edit, Details, Delete
```

## Getting started

**Prerequisites:** .NET 10 SDK.

```bash
git clone https://github.com/Khadija2005J/Gestion-Films.git
cd Gestion-Films/GestionFilms.Web
dotnet ef database update     # creates gestion-films.db
dotnet run
```

Then open the URL shown in the terminal and go to **/Films**.

## Team

Built by Khadija Alaoui Mrani and [Rim Ben Moussa](https://github.com/RimBenMoussa).
