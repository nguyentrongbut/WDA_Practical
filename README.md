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

** Departments
<img width="1915" height="930" alt="image" src="https://github.com/user-attachments/assets/708a1cea-9aad-4842-89e4-852a22196253" />
<img width="1917" height="897" alt="image" src="https://github.com/user-attachments/assets/5dff6950-b673-4d72-a7da-9bc15d2a7b74" />
<img width="1912" height="906" alt="image" src="https://github.com/user-attachments/assets/6746ade8-bffc-47c3-bc70-4cbe44a39fa9" />
<img width="1908" height="892" alt="image" src="https://github.com/user-attachments/assets/27ee1d20-3438-45c5-88b4-19c5f1284cf9" />
<img width="1913" height="885" alt="image" src="https://github.com/user-attachments/assets/6968db3a-d597-4aad-9e27-7113833a78ac" />
<img width="1908" height="865" alt="image" src="https://github.com/user-attachments/assets/ed4a0781-365f-4b7b-9ae4-69519508f41e" />

** Employee
<img width="1917" height="910" alt="image" src="https://github.com/user-attachments/assets/0b1965ac-576a-4309-956c-eb21fd4314d5" />
<img width="1916" height="888" alt="image" src="https://github.com/user-attachments/assets/940bdef0-58b5-4f18-b70f-c1bdec84d420" />
<img width="1905" height="897" alt="image" src="https://github.com/user-attachments/assets/8a9148c3-21d4-4844-9fa8-0ce2bc72dbc4" />
<img width="1892" height="907" alt="image" src="https://github.com/user-attachments/assets/bee5beff-e172-4d62-8212-b7bca955ee6e" />
<img width="1911" height="903" alt="image" src="https://github.com/user-attachments/assets/31a9be72-a423-46cb-9075-ab5dfe04db45" />
<img width="1910" height="922" alt="image" src="https://github.com/user-attachments/assets/5a993393-da69-4d69-b6c6-9f8a8c06f2fb" />
<img width="1917" height="888" alt="image" src="https://github.com/user-attachments/assets/39a7ed0a-2800-4fbb-8a54-372287dcaf69" />













