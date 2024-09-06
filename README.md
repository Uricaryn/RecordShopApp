# Record Shop Application

The **Record Shop Application** is a comprehensive software suite designed to manage and operate a record shop. The application consists of four main components, each serving distinct roles in the overall architecture of the application.

## Project Structure

### 1. RecordShopService
This is the backend service responsible for handling the main business logic and service operations of the application.

- **Project File**: `RecordShopService.csproj`
- **Key Directories**:
  - `DTOs/`: Contains Data Transfer Objects like `AdminCreateDto`, `AlbumCreateDto`.
  - `Services/`: Contains the main services utilized by the application.
  - `bin/`: Contains compiled binaries and DLLs.
  - `obj/`: Contains temporary files and build outputs.

### 2. ClassLibrary1
This library provides additional business logic, concrete implementations, enums, and interfaces that enhance the functionality of the main service.

- **Project File**: `ClassLibrary1.csproj`
- **Key Directories**:
  - `Concrete/`: Contains concrete classes implementing interfaces.
  - `Enum/`: Enum definitions used across the application.
  - `Interface/`: Interfaces defining contracts used by other services.

### 3. RecordShopAppDAL
The Data Access Layer manages all database-related operations including context configurations and migrations.

- **Project File**: `RecordShopAppDAL.csproj`
- **Key Directories**:
  - `Context/`: Database context and configurations.
  - `Migrations/`: Contains migration files for database schema updates.
  - `Configuration/`: Configurations related to the database.
  - `Interface/`: Interfaces specific to data access.

### 4. RecordShopAppUI
The user interface component, likely built with Windows Forms or WPF, provides a graphical interface for interacting with the backend services.

- **Project File**: `RecordShopAppUI.csproj`
- **Key Directories**:
  - `Properties/`: Contains resources, settings, and designer files.
  - `Images/`: Resources for UI visuals.
  - `obj/`: Compiled resources and binaries for the UI.

## Features

- **Admin Management**: Create, view, and manage admin accounts.
- **Album Management**: Add, edit, and view albums in the record shop.
- **Data Management**: Comprehensive data handling through the Data Access Layer.
- **User Interface**: A user-friendly UI for managing shop operations.

## Getting Started

### Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) installed on your system.

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/RecordShopApp.git
Restore dependencies for each component:

bash
Kodu kopyala
dotnet restore
Build the solution:

bash
Kodu kopyala
dotnet build
Run the backend services and UI application:

bash
Kodu kopyala
dotnet run --project RecordShopService
dotnet run --project RecordShopAppUI
Contributing
Contributions are welcome! Please fork this repository and submit a pull request for review.

License
This project is licensed under the MIT License - see the LICENSE file for details.

Contact
For any inquiries, please contact onuranatca@hotmail.com.tr
