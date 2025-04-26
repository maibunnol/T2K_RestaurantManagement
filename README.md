# T2K Restaurant Management System

## Overview
The **T2K Restaurant Management System** is a cross-platform application built using **.NET MAUI** and **Blazor**. It provides a comprehensive solution for managing restaurant operations, including menu management, order input, and order tracking. The system leverages **Entity Framework Core** for database management and supports SQLite as the underlying database.

---

## Features
1. **Menu Management**:
   - Add, edit, and delete menu items.
   - Categorize menu items for better organization.
   - Store menu item details such as name, description, price, and image.

2. **Order Input**:
   - Create new orders based on available menu items.
   - Automatically assign a random order number to each new order.
   - Calculate the total price of items in the cart.

3. **Order Tracking**:
   - Track the status of orders (e.g., "Pending", "Ready").
   - Mark individual order items as completed.
   - Notify users when an order is ready.
   - Clear completed orders from the system.

4. **Cross-Platform Support**:
   - Runs on Android, iOS, Windows, and macOS using .NET MAUI.
   - Provides a native-like experience across platforms.

5. **Blazor Integration**:
   - Uses Blazor components for building interactive and reusable UI elements.
   - Embedded Blazor components in the MAUI app using `BlazorWebView`.

---

## Technologies Used
### **Frameworks and Libraries**
- **.NET MAUI**: For building cross-platform native applications.
- **Blazor**: For creating interactive web-based UI components.
- **Entity Framework Core**: For database management and ORM functionality.
- **SQLite**: Lightweight database for storing application data.

### **Programming Concepts**
- **Classes**: Used to represent entities like `MenuItem`, `Order`, `OrderItem`, and `Category`.
- **Interfaces**: Used for dependency injection (e.g., `IDbContextFactory` and `IJSRuntime`).
- **Exception Handling**: Try-catch blocks for handling runtime errors during database operations.
- **Dependency Injection**: Services like `T2KDBContext` and `IJSRuntime` are injected into components for better modularity.

---

## Project Structure
### **Key Files**
1. **`MauiProgram.cs`**:
   - Configures the MAUI app, including database setup and dependency injection.
   - Ensures the SQLite database is created and seeded with initial data.

2. **Blazor Components**:
   - **`OrderInput.razor`**: Handles order creation and cart management.
   - **`OrderStatus.razor`**: Displays and tracks the status of orders.
   - **`Home.razor`**: The landing page of the application.

3. **Database Context**:
   - **`T2KDBContext`**: Manages database connections and defines `DbSet` properties for entities.

4. **Models**:
   - **`MenuItem`**: Represents a menu item.
   - **`Order`**: Represents an order.
   - **`OrderItem`**: Represents an item within an order.
   - **`Category`**: Represents a category of menu items.

5. **Configuration**:
   - **`appsettings.json`**: Stores configuration settings, including the SQLite database connection string.

---

## Setup and Installation
### **Prerequisites**
- .NET 9 SDK installed on your machine.
- A code editor like Visual Studio 2022 or Visual Studio Code.

### **Steps to Run the Project**
1. Clone the repository:
```
git clone https://github.com/maibunnol/T2K_RestaurantManagement/
```
```
cd T2K_RestaurantManagement
```


2. Build the project:
```
dotnet build
```


3. Run the project:
```
dotnet run
```
The application should launch on your target platform

---

