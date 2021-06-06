# VMS - Verification Management System

![Screenshot](/images/title.png)

## [Live Demo](https://verificationmanagementsystem.azurewebsites.net/)

## Description
MVP for an app to manage verification & validation programs of any hardware.

The inspiration came from VRS, which is a massive system used by one of the companies I worked for. The system has some difficulties coming from old technologies being used, like Excel for UI and IBM Mainframe for databases. Implementing the same features in modern web technologies would improve the system stability and reduce its complexity, which was my main motivation for doing it.

## How to use
To clarify some definitions used:
* A Vehicle is a single product which will be used for experiments.
* Main goal of the Experiment is to verifiy product requirements.
* There could be many experiments allocated to one vehicle.
* Each vehicle have many stages during the process, starting from planning, through testing and finishing with disassembly and component inspection.
* All users can view the status of the vehicle, but only an Administrator is able to create, update and delete the data.

## Technologies Used
* ASP.NET Core 5.0 for a Web App.
    * Blazor Server in order to create an SPA without the need of coding in JavaScript.
    * Identity for Authentication and Authorization. It uses Razor Pages, Entity Framework and a separate MS SQL Server database.
    * Data Access was done by Dapper.
* Bootstrap 4.6 for quickly creating responsive UI.
* MS SQL Server for the main database. Data logic was implemented by Stored Procedures.

## Next Steps

- [ ] New UI using JS framework for better SPA experience - Blazor Server is still young technology, where main JS frameworks are more mature.
- [ ] Custom CSS3 to simplify styling the UI.
- [ ] Add features for project management of the whole life of the tested vehicle, like Gantt charts and maps with build and strip progress.
- [ ] Add parameters functionality for experiments to know what instrumentation will be needed on the vehicle.
