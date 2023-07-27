# Backyard Gleaners

### By Eusebie Siebenberg

#### Independent Capstone Project @ Epicodus. A Gleaners App built around a custom API and MVC Client Front End, with Google Maps integration

[API Usage](#using-this-api)

## Technologies Used

* C#
* .NET
* ASP.NET CORE
* MVC API Client Front End
* Entity Framework Core
* EF Core Migrations
* Swashbuckle
* Swagger
* MySQL
* Rest Sharp
* Google MyMaps Integration, Google Icons
* Bootstrap

## Description 

A website for local backyard gardeners with food surplus to connect with community members to distribute foods: Gleaning is simply harvesting extra crops from gardens, or farms, to provide to anyone in need. Users can learn about becoming a gardening host, a Gleaner, and how to volunteer to assist with food surplus distribution within their city. Discover the benefits, history and facts about gleaning. Additionaly, user will have a full page map view of pinned gardeners location, ability to create a gardeners profile, and search for specific food resources by type and location.

## Setup/Installation Requirements

1. Open your shell of choice (e.g., Terminal or GitBash) and run these commands in order:
    * Clone this repository with $ `git clone https://github.com/eusebiedev/Backyard-Gleaners.git`
    * Open in your favorite IDE, navigate to the root directory of this project `BackyardGleaners.Solution`, Create a `.gitignore` file with $ `touch .gitignore`, copy/paste this into the .gitignore file:
      ```
      bin
      obj
      appsettings.json
      appsettings.*.json
      ``` 
2. `API Setup`: Navigate to this project's API directory called `BackyardGleanersApi` with $ `cd BackyardGleanersApi`
    * create a new file called appsettings.json with $ `touch appsettings.json`, copy/paste this into the file, replacing `uid` and `pwd` with your own values for using MySQL Workbench.
(remove square brackets when inputting your details):
      ```
      {
        "Logging": {
          "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
          }
        },
        "AllowedHosts": "*",
        "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=backyard_gleaners_api;uid=root;pwd=epicodus;"
        }
      }
      ```
    * create another file called appsettings.Development.json with $ `touch appsettings.Development.json`, copy/paste the following code:
      ```
      {
        "Logging": {
          "LogLevel": {
            "Default": "Information",
            "Microsoft": "Trace",
            "Microsoft.AspNetCore": "Information",
            "Microsoft.Hosting.Lifetime": "Information"
          }
        }
      }
      ```
3. `Database Setup`: Within the `BackyardGleanersApi` directory, run $ `dotnet ef database update` to generate the database. Open your copy of MySQL Workbench, click on the `Navigator > Schemas`, right-click and select `Refresh All`, you should see your new BackyardGleanersApi database.

4. `MVC Client Setup`: Navigate to this project's Client directory called `BackyardGleanersClient` with $ `cd BackyardGleanersClient`
    * create a new file called appsettings.json with $ `touch appsettings.json`, copy/paste this into the file:
      ```
      {
        "Logging": {
          "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
          }
        },
        "AllowedHosts": "*"
      }
      ```
    * create another file called appsettings.Development.json with $ `touch appsettings.Development.json`, copy/paste the following code:
      ```
      {
        "Logging": {
          "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
          }
        }
      }
      ```
5.  To use this app, both the API and MVC must be running. After following the instructions outlined above:
    * Start the API First using $ `dotnet run` from within the BackyardGleanersApi directory
    * Then start the Client using $ `dotnet watch run` from within the BackyardGleanersClient directory. This command will launch the application in your browser!

## Using This Api

#### To test routes in Swagger: 

* In your terminal, navigate to the BackyardGleanersApi directory and run ```dotnet watch run``` 
* In your broswer, open https://localhost:5001/swagger/index.html
* Use the GUI to navigate the API and test the endpoints
* `API Versioning` is enabled, which defaults to API v2 when Swagger opens. Simply use the Swagger `Select a definition` drop down options list to select API v1. Versioning is important because when we make breaking changes in the future, we can push these changes to a new version, and retain an original version for enterprises that can't update to Version 2 just yet.

#### To test routes in Postman: 
* Make sure that Postman API Platform is downloaded to your device
* Start a new request by clicking the + at the top of the window
* Copy and paste any of the below listed end point links into the text bar that says 'Enter URL or paste text'
* Make sure the method to the left of the text box matches the method described for the endpoint you are testing
* If route requires a body, navigate to the body window just below the text box
* Copy and paste the body code listed above and replace fields with their respective values
* Click send and wait for response at the bottom of the window
* To access API v1 in Postman: `https://localhost:5001/api/v1/gardeners/` 
* To access API v2 in Postman: `https://localhost:5001/api/v2/gardeners/`

## Api Endpoints
```
Endpoints:
GET /api/v2/gardeners/
GET /api/v2/gardeners/{id}
POST /api/v2/gardeners/
PUT /api/v2/gardeners/{id}
DELETE /api/v2/gardeners/{id}
SEARCH /api/v2/garderers/search?{}={}
```

## Example URLs for Requests on Gardeners
| Parameter  | Type   | Description  | Sample Url  |
|----------- |-----   | ---------    | -------------  | 
| Gardeners  | List   | Returns a list of all gardeners in database | https://localhost:5001/api/v2/gardeners |
| Name  | String   | Returns a garderner with matching name |https://localhost:5001/api/v2/Gardeners?name=Cherry%20Bark |
| Food  | String   | Returns a gardener with matching food surplus |https://localhost:5001/api/v2/Gardeners?food=cherries |
| Search  | Query   | Returns a gardener with matching food or location | https://localhost:5001/api/v2/Gardeners/Search?location=se

#### API endpoints for Post, Put, Delete will be limited to user accounts in the future.

## Known Bugs

No known bugs as of 07/24/23

### Research & Planning Log:
#### Friday 7/7
* 8:42: researching combining api/client to one repo
* 9:18: may separate into individual projects for modularity
* 9:39: creating combined api/client test project to see how to run project from singular repo
* 10:29: cannot run both api/client in same repo, testing failed
* 11:11: attempting to combine api/client in test project. close
* 11:23: Successfully combined API & Client to a single .Solution project and launched interface!
* 12:59: Looking into embedding location based google maps for each host
* 1:28: Successfully embed custom location based google map on profile view in tests
* 1:56: Researching creating a full independent map view with each host pinned, click pin to go to details
* 2:39: Building initial host Model.cs
* 2:53: Working on Capstone Proposal file
* 3:26: Create initial Host database in MySQL
* 3:49: Building seed database model
* 3:55: updating README fields
* 4:15: research authentication and user roles
* 4:45: Fix corrupted API directory
* 4:52: Building seeded database, Host Controller

#### Friday 7/14
* 8:00: Studying donation form integration
* 8:46: Looking into Google Cal integration
* 9:22: building api controllers
* 10:21: researching user comment section for gardeners 
* 11:55: building mvc client front end
* 2:57: break from building Client, researching Comment section
* 4:54: card layout forEach gardener successfull, building views, push and submit

#### Saturday 7/15
* 2:00: Research theme switcher for dark mode toggle

#### Friday 7/21
* 8:16: Research migrating search function to use navbar instead of opening View
* 4:30: Looking into Hosting on a Azure, Render

#### Tuesday 7/25
* 11:55: WIP: Adding Identity is causing many issues, may have to add to stretch goal

#### Wednesday 7/26
* 8:22: Plan for today:
    * Work through setting up hosting on Microsoft Azure
    * Try to debug account creation which was breaking the app 
    * Add 'People We Like' / Resources page
    * Add improved unified style/possible css animation to About view
* 9:14: Azure Deployment in progress
* 10:47: Azure deployment success, after encountering Region error when selecting West US(2 or 3) when creating Web App, selecting default East US, deployed without error. moving to connecting database
* 12:00: Deployed Web App to Azure, waiting on live server status 
* 4:22: WIP progress since lunch, troubleshooting 404 from Azure

#### Thursday 7/27 Presentation Day!
* 9:00: WIP, setting up an Azure Web App service for my MVC Client side

[Back to Top](#backyard-gleaners)

## [MIT](https://opensource.org/license/mit/) License 

Copyright © 2023 Eusebie Siebenberg

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

If you have any questions, comments, or concerns, please reach out to me at: siebenee@gmail.com