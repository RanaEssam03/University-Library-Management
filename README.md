# University-Library-Management

The University Library Management System is a Windows application built using C# and MS SQL Server. This system allows students, professors, and administrators to sign up and sign in to the library system. Students and professors can view books, view their information, update their information (excluding email), and view their borrow history. Administrators can add books, view user information (including students and professors), and manage the library system.

## Getting Started

### Prerequisites

- Windows PC with .NET Framework installed
- MS SQL Server

### Installing

1. Clone the repository to your local machine.
2. Open the project in Visual Studio.
3. Restore the NuGet packages.
4. Update the database connection string in the `app.config` file.
5. Build and run the application.

## Usage

### Sign Up

1. Open the application.
2. Click the "Sign Up" button on the login page.
3. Fill in the required information (fname, lanme, password, email).
4. Click the "Submit" button.

### Sign In

1. Open the application.
2. Enter your email and password.
3. Click the "Sign In" button.

### View Books

1. Sign in to the application.
2. Click the "View Books" button on the main menu.
3. Browse through the list of books and click on a book to view its details.

### Borrow History

1. Sign in to the application.
2. Click the "Borrow History" button on the main menu.
3. Browse through the list of borrow history and click on an item to view its details.

### Update User Information

1. Sign in to the application.
2. Click the "Update Information" button on the main menu.
3. Fill in the required information (name, password, phone number, address).
4. Click the "Submit" button.

### Add Books

1. Sign in to the application as an administrator.
2. Click the "Add Books" button on the main menu.
3. Fill in the required information (book title, author name, publisher, ISBN, quantity).
4. Click the "Submit" button.

### View User Information

1. Sign in to the application as an administrator.
2. Click the "View Users" button on the main menu.
3. Browse through the list of users and click on a user to view their details.

## Built With

- C#
- MS SQL Server


