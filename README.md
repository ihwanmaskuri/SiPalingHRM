# SiPalingHRM

**SiPalingHRM** adalah hasil konversi/rework dari OrangeHRM (PHP) ke dalam ekosistem **.NET Framework 4.7.2**.

## Struktur Proyek

- **OrangeHRM.Entities**: Model data (POCO) yang dipetakan ke database.
- **OrangeHRM.Data**: Data Access Layer menggunakan Entity Framework 6.
- **OrangeHRM.Core**: Business Logic Layer dan Services.
- **OrangeHRM.Api**: RESTful API menggunakan ASP.NET Web API.
- **OrangeHRM.Web**: Frontend menggunakan ASP.NET MVC 5.

## Fitur yang Sudah Dimigrasi
- [x] PIM (Employee Management)
- [x] Leave Management
- [x] Time & Attendance
- [x] Admin & Organization Structure
- [x] Performance Management
- [x] Recruitment Basics

## Tech Stack
- .NET Framework 4.7.2
- Entity Framework 6
- ASP.NET Web API 2
- ASP.NET MVC 5
- SQL Server
