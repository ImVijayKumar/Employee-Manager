# 👨‍💼 Employee Manager

A full-stack web application built to manage employee records efficiently. This project combines a C# ASP.NET Core Web API backend with a React frontend (`employee-manager-ui`) and a MySQL database. It supports full CRUD operations, dynamic data binding, and a responsive user interface.

---

## 📌 Introduction

**Employee Manager** serves as a practical HR tool that allows users to:

- Add, edit, and delete employee records  
- Assign employees to Indian states  
- Automatically calculate age from date of birth  
- View all records in a clean, responsive table  
- Interact with a real-time database using a modern tech stack  

---

## 🚀 Features

- 🧾 Add/Edit employee via modal form  
- 📋 Employee list with sorting and pagination  
- 🗓️ Auto age calculation from DOB  
- 🌐 State dropdown populated from MySQL  
- 🧼 Form validation and clear/reset functionality  
- 📱 Responsive design using Bootstrap or custom CSS  
- 🔄 Real-time updates via API integration  

---

## 🧱 Technologies Used

| Layer     | Technology                          |
|-----------|--------------------------------------|
| Frontend  | React (`employee-manager-ui`), Axios, React Router, Bootstrap/CSS |
| Backend   | ASP.NET Core Web API (C#)            |
| Database  | MySQL                                |

---

## 📁 Project Structure


---

## ⚙️ Installation & Usage

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/your-username/Employee-Manager.git


2️⃣ Set Up the Database
Open MySQL Workbench or CLI

Run the SQL script:

sql
source sql/employee-manager-schema.sql;
This creates States and Employees tables and inserts 29 Indian states

3️⃣ Run the Backend (ASP.NET Core)
bash
cd Employee-Manager
dotnet restore
dotnet run
Ensure appsettings.json has your correct MySQL connection string

API runs at https://localhost:5001

4️⃣ Run the Frontend (React)
bash
cd employee-manager-ui
npm install
npm start
React app runs at http://localhost:3000

Axios connects to backend endpoints like /api/employees and /api/states

🔄 System Implementation
Frontend (employee-manager-ui)

Sidebar navigation and top header

Employee table with Edit/Delete buttons

Modal form for Add/Edit with validation

Age auto-calculated from DOB

State dropdown populated from backend

Backend (ASP.NET Core)

RESTful API with EmployeesController and StatesController

Entity Framework Core or SQL connector for DB access

CORS enabled for frontend communication

Database (MySQL)

States table with 29 Indian states

Employees table with foreign key to States

Sample data included for testing

📌 Future Enhancements
[ ] Search and filter functionality

[ ] Export to CSV or Excel

[ ] Authentication and role-based access

[ ] Dashboard with charts and KPIs
