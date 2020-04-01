# Salon Organizer
#### March 20, 2020

ASP.NET core MVC application using Entity Framework Core and MySQL to organize structure of a salon. Search your stylists or clients, add them, remove them or edit them. 

## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone https://github.com/MMAlaeddin/SalonOrganizer
    ```
2. Change directories into the project working directory:
    ```
    cd Salon.Solution/SalonOrganizer
    ```
3. Restore all dependencies:
    ```
    dotnet restore
    ```

#### Setup Database

4. Run the following commands in MySQL to setup this project Database
    ```
    CREATE DATABASE `mariam_alaeddin`;
    USE mariam_alaeddin;
    CREATE TABLE `Stylists` (
        `StylistId` int(11) NOT NULL AUTO_INCREMENT,
        `StylistName` varchar(255) DEFAULT NULL,
        `Description` varchar(255) DEFAULT NULL,
        PRIMARY KEY (`StylistId`)
    );
    CREATE TABLE `Clients` (
        `ClientId` int(11) NOT NULL AUTO_INCREMENT,
        `ClientName` varchar(255) DEFAULT NULL,
        `StylistId` int(11) NOT NULL DEFAULT '0',
        PRIMARY KEY (`ClientId`)
    );

    ```
5. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```
6. Open the locally hosted server in your preferred web browser:
    ```
    start http://localhost:5000
    ```


## Technologies Used

* C#
* ASP.NET core MVC 2.2
* Entity Framework Core
* MySQL + MySQL Workbench version 8.0.15
* RESTful Routing
* CRUD Functionality
* Git

## Authors

* **MARIAM ALAEDDIN** - (https://github.com/MMALAEDDIN)


## License

Licensed under the MIT license.

COPYRIGHT 2020 - MARIAM ALAEDDIN