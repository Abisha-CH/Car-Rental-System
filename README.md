# Car Rental System

A web-based Car Rental System built using **ASP.NET Core MVC**, **C#**, and **Bootstrap**. The application allows users to view available cars, book cars, and view booked cars through a simple, responsive interface.

## Features

- **Available Cars:** View cars available for rent.
- **Car Details:** View car names and rental prices per day.
- **Book a Car:** Book a car using the booking button.
- **Booked Cars:** View cars that have been booked.
- **Responsive Design:** Bootstrap styling for different screen sizes.
- **Navigation:** Easily switch between available and booked cars.

## Technologies Used

- C#
- ASP.NET Core MVC
- Razor Views
- HTML5 and CSS3
- Bootstrap
- JavaScript

## Project Structure

```text
CarRentalSystem/
├── CarRentalSystem.sln
├── .gitignore
└── CarRentalSystem/
    ├── Controllers/
    │   ├── CarController.cs
    │   └── HomeController.cs
    ├── Models/
    │   ├── Car.cs
    │   └── ErrorViewModel.cs
    ├── Views/
    │   ├── Car/
    │   │   ├── Index.cshtml
    │   │   └── Booked.cshtml
    │   ├── Home/
    │   └── Shared/
    ├── wwwroot/
    ├── Program.cs
    └── appsettings.json
```

## Getting Started

### Prerequisites

- Visual Studio with ASP.NET and web development support
- .NET SDK compatible with the project

### Run the Application

1. Clone or download this repository.
2. Open `CarRentalSystem.sln` in Visual Studio.
3. Restore NuGet packages if prompted.
4. Build the solution.
5. Run the application using Visual Studio.

## How to Use

1. Open the Available Cars page.
2. Browse the listed cars and their daily rental prices.
3. Select **Book Car** to book a vehicle.
4. Open **Booked Cars** to view booked vehicles.

## Current Limitations

- Car information is stored in application memory rather than a database.
- Bookings are temporary and may reset when the application restarts.
- User authentication and payment processing are not implemented.

## Author

**Abisha-CH**

## License

This project was developed for educational purposes.
