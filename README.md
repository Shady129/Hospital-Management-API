# 🏥 Hospital Management API

A RESTful Web API built with **ASP.NET Core** and **Entity Framework Core** for managing hospital operations. The project follows a **3-Tier Architecture** to separate business logic, data access, and presentation layers.

---

# 🚀 Features

- Department Management
- Doctor Management
- Patient Management
- Appointment Management
- Medical Record Management
- Prescription Management

Each module supports full CRUD operations:

- ✅ Create
- ✅ Read
- ✅ Update
- ✅ Delete

---

# 🛠 Technologies Used

- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server
- Dependency Injection
- Swagger (OpenAPI)

---

# 🏗 Project Architecture

```
HospitalManagementAPI
│
├── Controllers
├── Services
├── Repositories
├── Models
├── Data
└── SQL Server Database
```

### Request Flow

```
Client
   │
   ▼
Controller
   │
   ▼
Service
   │
   ▼
Repository
   │
   ▼
SQL Server Database
```

---

# 📂 Project Modules

- Departments
- Doctors
- Patients
- Appointments
- Medical Records
- Prescriptions

---

# 📌 API Endpoints

## Departments

- GET
- GET By Id
- POST
- PUT
- DELETE

## Doctors

- GET
- GET By Id
- POST
- PUT
- DELETE

## Patients

- GET
- GET By Id
- POST
- PUT
- DELETE

## Appointments

- GET
- GET By Id
- POST
- PUT
- DELETE

## Medical Records

- GET
- GET By Id
- POST
- PUT
- DELETE

## Prescriptions

- GET
- GET By Id
- POST
- PUT
- DELETE

---

# 🧩 Architecture

The project follows the Repository Pattern and Service Layer Architecture.

- Controllers handle HTTP requests.
- Services contain business logic.
- Repositories interact with the database.
- Entity Framework Core manages data persistence.

---

# ▶️ Getting Started

### 1. Clone the repository

```bash
git clone <repository-url>
```

### 2. Configure SQL Server

Update the connection string inside:

```
appsettings.json
```

### 3. Run the project

```bash
dotnet restore
dotnet build
dotnet run
```

### 4. Open Swagger

```
https://localhost:{port}/swagger
```

---

# ✅ Project Status

- ✔ Repository Pattern
- ✔ Service Layer
- ✔ Entity Framework Core
- ✔ SQL Server Integration
- ✔ Swagger Documentation
- ✔ Full CRUD Operations

---

# 📚 Learning Objectives

This project was developed to practice:

- ASP.NET Core Web API
- Entity Framework Core
- Repository Pattern
- Service Layer
- Dependency Injection
- RESTful API Design
- SQL Server Database Design
- CRUD Operations

---

# 👨‍💻 Author

**Shady Mahmoud**
