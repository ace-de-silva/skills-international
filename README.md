# Skills International — Student Registration System

A Windows Forms desktop application built with **C# (.NET Framework 4.7.2)** and **SQL Server** for Skills International School. Developed as the DiTEC Final Project at ESOFT Metro Campus.

---

## Overview

The system provides a secure login gateway and a full-featured student registration module, allowing staff to register, search, update, and delete student records stored in a SQL Server database.

---

## Screenshots

| Login Form | Registration Form |
|---|---|
| ![Login](docs/login.png) | ![Registration](docs/registration.png) |

> Add your own screenshots to a `docs/` folder and update the paths above.

---

## Features

- **Secure Login** — Credential validation against hardcoded defaults and a database `Logins` table for multi-user support
- **Student Registration** — Full CRUD operations (Create, Read, Update, Delete) on student records
- **Search by Reg No** — Selecting a registration number from the dropdown auto-fills all fields
- **Form Validation** — Required field checks before any database write
- **Confirmation Dialogs** — Delete and Exit actions prompt for user confirmation
- **Logout** — Returns to the Login form without closing the application

---

## Tech Stack

| Layer | Technology |
|---|---|
| Language | C# |
| Framework | .NET Framework 4.7.2 |
| UI | Windows Forms (WinForms) |
| Database | Microsoft SQL Server |
| IDE | Visual Studio 2022 |

---

## Database Schema

**Database name:** `Student`

### Table: `Registration`

| Column | Data Type | Constraint |
|---|---|---|
| regNo | INT | PRIMARY KEY |
| firstName | VARCHAR(50) | |
| lastName | VARCHAR(50) | |
| dateOfBirth | DATETIME | |
| gender | VARCHAR(50) | |
| address | VARCHAR(50) | |
| email | VARCHAR(50) | |
| mobilePhone | INT | |
| homePhone | INT | |
| parentName | VARCHAR(50) | |
| nic | VARCHAR(50) | |
| contactNo | INT | |

### Table: `Logins`

| Column | Data Type | Constraint |
|---|---|---|
| username | VARCHAR(50) | PRIMARY KEY |
| password | VARCHAR(50) | |

---

## Getting Started

### Prerequisites

- [Visual Studio 2019 / 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload
- SQL Server LocalDB — **ships with Visual Studio**, no separate install needed

> SSMS is not required. Visual Studio includes **SQL Server Object Explorer** which covers everything needed.

### 1. Set up the database

1. In Visual Studio, go to **View → SQL Server Object Explorer**.
2. Expand **SQL Server → (localdb)\MSSQLLocalDB**.
3. Right-click the server node and select **New Query**.
4. Paste the contents of `database_setup.sql` into the query window.
5. Click the green **Execute** button (or press `Ctrl+Shift+E`).

The `Student` database with both tables will be created automatically.

### 2. Configure the connection string

The default `App.config` already points to LocalDB — no changes needed if you're on Visual Studio:

```xml
<add name="StudentDB"
     connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True"
     providerName="System.Data.SqlClient" />
```

If you do have SQL Server Express or a full SQL Server installed, update `Data Source` accordingly:

| Setup | Data Source value |
|---|---|
| Visual Studio LocalDB (default) | `(localdb)\MSSQLLocalDB` |
| SQL Server Express | `.\SQLEXPRESS` |
| Full SQL Server (local) | `localhost` or `.` |

### 3. Open and run

1. Double-click `SkillsInternational.sln` to open in Visual Studio.
2. Press **F5** (or click **Start**) to build and run.

---

## Default Login Credentials

| Field | Value |
|---|---|
| Username | `Admin` |
| Password | `Skills@123` |

---

## Project Structure

```
skills-international/
├── SkillsInternational.sln
├── database_setup.sql
└── SkillsInternational/
    ├── SkillsInternational.csproj
    ├── App.config
    ├── Program.cs
    ├── DatabaseHelper.cs
    ├── LoginForm.cs
    ├── LoginForm.Designer.cs
    ├── RegistrationForm.cs
    ├── RegistrationForm.Designer.cs
    └── Properties/
        └── AssemblyInfo.cs
```

---

## License

This project was created for educational purposes as part of the **DiTEC (Diploma in Information Technology)** programme at ESOFT Metro Campus.
