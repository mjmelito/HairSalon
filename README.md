# Claire's Client Tracker

#### A simple C# program built for hair salons and stylists to manage their clients

#### By Matthew Melito

## Technologies Used

* C#
* MySQL
* HTML

## Description

This C# application was designed and built to help hair salon owners and managers track their client base and assign clients to the stylists who work with them.


## Setup/Installation Requirements

#### Installing .NET and MySQL
1. Install .NET6 if you have not done so. Visit [this link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to download the recommended versions of both software packages.
2. Follow the installer prompts to install the software. Use the default settings.
3. In a terminal, install `dotnet-script` by entering the following command: `$ dotnet tool install -g dotnet-script`. You will also need to configure your environment to access this tool. See [this link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script).
4. Install MySQL.  Follow the instructions at [this link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

#### Cloning and Initial Setup

5. Clone project repository from https://github.com/mjmelito/HairSalon
6. Navigate to the project's root directory, HairSalon
7. Install the MySglConnector Package with the following terminal command: dotnet add package MYSqlConnector -v 2.2.0. Then enter 'dotnet restore'.
8. Within the HairSalon directory, add a file named 'appsettings.json and add the following code to the file:

{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_mysqlconnector;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
9. Be sure to add obj, bin, and appsettings.json to your .gitignore file and commit the file to GitHub to protect your Username and Password.

#### Importing the Database 
10. Open MySQL Workbench and locate the Navigator pane (on the left-hand side of the program window.)
11. Select "Data Import/Restore".
12. Select "Import from Self Contained File". Navigate to the top directory of the project. ("HairSalon").
13. Within "HairSalon", select the file named matt_melito.sql.
14. Under "Default Schema to be Imported To", click the "New..." button, enter the name of the database (matt_melito.sql), and click "OK".
15. Select to the "Start Import" button.

#### Running the Program
16. 

## Known Bugs

* No known bugs or issues.

## This project uses the following license: MIT

Copyright (c) 2023 Matthew Melito