# NetCore-OnionArchitect
Getting Started
To build and run this sample as-is, you must have Visual Studio 2015 installed. In most cases you can run the application by following these steps:
Download and extract the .zip file.
Open the solution file in Visual Studio.
Change connection string in the appsettings.json file of the web project.
Choose OA.Repo project in package manager console and run the following command for migration and create database.
   Tools –> NuGet Package Manager –> Package Manager Console
   PM> Add-Migration MyFirstMigration
   PM> Update-Database
   Run the application.
