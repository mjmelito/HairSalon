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

### Create a Database

1. Download and open MySQL Workbench.
2. Create a Username and Password.
3. Select 'Create a New Schema' from the toolbar.
4. Name the schema and select 'Apply'. A pop up window will appear. Here, select 'Apply' and 'Finish'.
5. Select your schema  from the schemas menu. Right click on 'Tables' and select 'Create Table'.
6. Name the table 'Clients', then add an id column by clicking in the window below the name of the table. Double click to name the column 'id'. Then select INt from the Datatype dropdown menu. Check the PK, NN, and AI checkboxes.
7. Add another row, this time namingthe coumn 'name'. Select VARCHAR(45) under 'Type'.


### Cloning and Running the Project

* Clone project repository from https://github.com/mjmelito/HairSalon
* Navigate to the project's root directory, HairSalon
* Install the MySglConnector Package with the following terminal command: dotnet add package MYSqlConnector -v 2.2.0. Then enter 'dotnet restore'.
* Add a file named 'appsettings.json and add the following code to the file:

{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_mysqlconnector;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
* Be sure to add obj, bin, and appsettings.json to your .gitignore file and commit the file to GitHub to protect your Username and Password.
* In the root directory, enter the terminal command 'dotnet run' to run the application in your browser.

## Known Bugs

* No known bugs or issues.

## This project uses the following license: MIT

Copyright (c) 2023 Matthew Melito