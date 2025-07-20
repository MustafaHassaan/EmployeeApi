# 🧑‍💼 Employee API - ASP.NET Core

This is the **backend API** for the Employee Management CRUD application.  
Built using **ASP.NET Core Web API**, it provides endpoints to perform Create, Read, Update, and Delete operations on employees.

---

## 🔧 Technologies Used

- ASP.NET Core 8
- C#
- In-Memory Data Storage (can be extended to use SQLite or SQL Server)

---

## 📦 API Endpoints

| Method | Endpoint             | Description              |
|--------|----------------------|--------------------------|
| GET    | /api/employees       | Get all employees        |
| GET    | /api/employees/{id}  | Get employee by ID       |
| POST   | /api/employees       | Create a new employee    |
| PUT    | /api/employees/{id}  | Update an employee       |
| DELETE | /api/employees/{id}  | Delete an employee       |

---

⚙️ Steps to run the project after downloading
 - Make sure you download and run the Angular project first
   - Frontend ([Frontend Angular](https://github.com/MustafaHassaan/employee-crud-angular))
 - Please change the ConnectionString link in the appsettings.json file.
 - Execute the following command to add the first migration:
   - dotnet ef migrations add InitialCreate
   - dotnet ef database update
   - dotnet run
---

🔗 Related Projects
 - Frontend ([Frontend Angular](https://github.com/MustafaHassaan/employee-crud-angular))

🧑‍💻 Developer
Mostafa Hassaan
- 🔗 GitHub ([Profile](https://github.com/MustafaHassaan))
