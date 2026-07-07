# 🏥 Hospital Management API

A RESTful Web API built with **ASP.NET Core** and **Entity Framework Core** for managing hospital operations. The project follows a **3-Tier Architecture** using the **Repository Pattern** and **Service Layer** to separate business logic, data access, and presentation.

---

# 🚀 Features

The API provides complete management for:

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
- Repository Pattern
- Service Layer
- Dependency Injection
- Data Transfer Objects (DTOs)
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
├── DTOs
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

# 🔄 Data Transfer Objects (DTOs)

The project uses **Create DTOs** to separate API requests from domain entities.

Implemented DTOs:

- CreateDepartmentDto
- CreateDoctorDto
- CreatePatientDto
- CreateAppointmentDto
- CreateMedicalRecordDto
- CreatePrescriptionDto

### Benefits

- Prevents over-posting attacks
- Exposes only the required fields
- Improves security
- Makes the API easier to maintain
- Keeps entities independent from API contracts

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

The project follows the **Repository Pattern** and **Service Layer Architecture**.

- Controllers handle HTTP requests.
- Services contain business logic.
- Repositories communicate with the database.
- Entity Framework Core manages data persistence.
- DTOs separate API contracts from domain models.

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

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=HospitalManagementDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 3. Restore packages

```bash
dotnet restore
```

### 4. Build the project

```bash
dotnet build
```

### 5. Run the project

```bash
dotnet run
```

### 6. Open Swagger

```
https://localhost:{port}/swagger
```

---

# ✅ Project Status

- ✔ Repository Pattern
- ✔ Service Layer
- ✔ Entity Framework Core
- ✔ SQL Server Integration
- ✔ Dependency Injection
- ✔ Create DTOs
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
- DTO Design
- SQL Server Database Design
- CRUD Operations

---

# 👨‍💻 Author

**Shady Mahmoud**

Backend Developer | ASP.NET Core | C# | Entity Framework Core | SQL Server
