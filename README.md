# HouseRentingSystem

**HouseRentingSystem** is a full-featured ASP.NET Core MVC web application for browsing, renting, and managing house listings. It was developed as a course project for the **ASP.NET Core Advanced** module at SoftUni.

---

## 🔑 Features

- ✅ User registration and login
- 🏡 Browse available houses by category
- 📝 Add, edit, and delete houses (agents only)
- 📦 Rent and release houses(clients only)
- ⚠️ Full model validation and error handling
- 🎨 Razor views with Bootstrap for responsive UI

---

## 🧰 Technologies Used

- ASP.NET Core MVC 6
- Entity Framework Core 6
- Microsoft Identity
- SQL Server
- xUnit for unit testing
- Bootstrap 5

---

## 🚀 How to Run Locally
1. Clone the repository:
   ```bash
   git clone https://github.com/demirdemirev101/HouseRentingSystem
2.Open the solution in Visual Studio 2022+ or use the CLI.
3.Create a local SQL Server database and configure the connection string in:
   HouseRentingSystem.Web/appsettings.json
4.Apply the database migrations:
   dotnet ef database update
5.Run the application:
  dotnet run --project HouseRentingSystem.Web
