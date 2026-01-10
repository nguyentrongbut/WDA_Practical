# HR Management Web Application

This is a simple **HR Management** web application built with **ASP.NET Core MVC**, **Entity Framework Core**, and **SQLite**.  
It allows you to manage **Departments** and **Employees**, including create, read, update, and delete (CRUD) operations.

---

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Project Structure](#projectstructure)
- [Images](#images)

---

## Features

- Manage **Departments**:
  - Add, edit, delete
  - Track department code, location, and number of employees
- Manage **Employees**:
  - Add, edit, delete
  - Assign employees to departments
- Bootstrap 5 based responsive UI
- Toast notifications for success/error messages
- Validation for form inputs
- SQLite database for easy setup

---

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- Optional: Git

---

## Installation

1. Clone the repository:

```bash
git clone https://github.com/nguyentrongbut/WDA_Practical
cd HR_Manage
```

2. Restore dependencies
```bash
dotnet restore
```

3. Build the project
```bash
dotnet build
```

4. Run the project
```bash
dotnet run
```

By default, the app runs at:
```bash
http://localhost:5212/
```

# ProjectStructure
```bash
HR.Manage/            # Web project (Controllers, Views)
├─ Controllers/
│   ├─ DepartmentController.cs
│   └─ EmployeeController.cs
├─ Views/
│   ├─ Department/
│   └─ Employee/
├─ wwwroot/            # CSS, JS, Bootstrap, Icons
HR.Domain/             # Entity classes
HR.Application/        # Interfaces, DTOs
HR.Infrastructure/     # DbContext, Repositories

```

# Images



