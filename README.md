# 🎁 Mechira Sinit

<p align="center">
  <img src="./docs/images/demo.gif" width="800" alt="Mechira Sinit Demo">
</p>

<p align="center">
  A full-stack Chinese auction management system built with Angular and ASP.NET Core Web API.
</p>

---

# 🛠️ Built With

<p align="center">

<img src="https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white">

<img src="https://img.shields.io/badge/TypeScript-3178C6?style=for-the-badge&logo=typescript&logoColor=white">

<img src="https://img.shields.io/badge/SCSS-CC6699?style=for-the-badge&logo=sass&logoColor=white">

<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white">

<img src="https://img.shields.io/badge/.NET%208-512BD4?style=for-the-badge&logo=dotnet&logoColor=white">

<img src="https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white">

<img src="https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white">

<img src="https://img.shields.io/badge/Entity%20Framework%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white">

<img src="https://img.shields.io/badge/JWT-000000?style=for-the-badge&logo=jsonwebtokens&logoColor=white">

<img src="https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black">

</p>

---

# 📌 About The Project

**Mechira Sinit** is a full-stack web application for managing a Chinese auction system.

The system allows guests to browse available gifts, while registered users can add gifts to their basket and create orders.

An administrator manages gifts, user permissions, and controls the lottery process. The lottery is activated manually by the administrator and winners are selected randomly.

---

# ✨ Features

## 👤 Guest Users

* Browse available gifts
* View gift details without registration

## 🛒 Registered Users

* User authentication
* Add gifts to basket
* Create orders
* Participate in the Chinese auction

## 👑 Administrator

* Manage gifts
* Manage permissions
* Control the lottery process
* Run random winner selection

---

# 🖼️ Screenshots

## 🏠 Home Page

<p align="center">
  <img src="./docs/images/home.png" width="800" alt="Home Page">
</p>

---

## 🎁 Gifts Page

<p align="center">
  <img src="./docs/images/gifts.png" width="800" alt="Gifts Page">
</p>

---

## 🛒 Shopping Basket

<p align="center">
  <img src="./docs/images/basket.png" width="800" alt="Shopping Basket">
</p>

---

## 🔐 Login

<p align="center">
  <img src="./docs/images/login.png" width="800" alt="Login Page">
</p>

---

## 👑 Admin Management

<p align="center">
  <img src="./docs/images/admin.png" width="800" alt="Admin Panel">
</p>

---

## 🎲 Lottery

<p align="center">
  <img src="./docs/images/lottery.png" width="800" alt="Lottery">
</p>

---

## 🤝 Donors

<p align="center">
  <img src="./docs/images/donors.png" width="800" alt="Lottery">
</p>

---

# 🏗️ Architecture

```text
                 Angular Client
                       |
                       |
              HTTP Requests + JWT
                       |
                       |
             ASP.NET Core Web API
                       |
                       |
            Entity Framework Core
                       |
                       |
              SQL Server Database
```

---

# 📂 Project Structure

```text
MechiraSinit/
│
├── client/
│   └── Angular Frontend
│
└── server/
    └── ASP.NET Core Web API Backend
```

---

# ⚙️ Backend Architecture

The backend is organized using a layered architecture:

### Controllers

Responsible for handling HTTP requests and API endpoints.

### Services

Contains the business logic of the application.

### Repository Pattern

Separates data access logic from business logic.

### DTOs

Used for transferring data between the client and server.

### Entity Framework Core

Handles database communication and migrations.

---

# 🔐 Authentication & Authorization

The system uses JWT authentication to securely manage users and protect API requests.

Different permissions are applied according to user roles:

* Regular users can create orders and participate in the auction.
* Administrators can manage gifts and run the lottery.

---

# 🗄️ Database

The project uses **SQL Server** with **Entity Framework Core**.

Main entities:

* Users
* Gifts
* Donors
* Orders
* Lottery
* Categories

---

# 🚀 Installation

## Backend

Navigate to the server folder:

```bash
cd server
```

Restore dependencies:

```bash
dotnet restore
```

Run the server:

```bash
dotnet run
```

---

## Frontend

Navigate to the client folder:

```bash
cd client
```

Install dependencies:

```bash
npm install
```

Run Angular:

```bash
ng serve
```

The application will run on:

```text
http://localhost:4200
```

---

# 📚 API Documentation

Swagger is integrated into the backend to provide interactive API documentation and allow testing of endpoints.

---

# 💻 Development Tools

* Visual Studio
* Visual Studio Code
* Git & GitHub

---

# 👩‍💻 Author

**Efrat-Fr**
