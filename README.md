# Backyard Gleaners

### By Eusebie Siebenberg

Update, 2/11/2025: Process to migrate this app to React and Nextjs is about to start! Stay tuned!

Hosted live on Render, compatible with mobile devices: [Backyard Gleaners](https://backyard-gleaners.onrender.com/)

- Render's free service has server downtime. So the site may take a few extra seconds to load! I appreciate the patience.
- WIP: API not in use at this time. Hardcoding database, improve search functionality, improving design system across site

## Description
* Independent Capstone Project @ Epicodus. A Gleaners App built around a custom API and MVC Client Front End, with Google Maps integration, Docker, Render


A website for local backyard gardeners with food surplus to connect with community members to distribute foods: Gleaning is simply harvesting extra crops from gardens, or farms, to provide to anyone in need. Users can learn about becoming a gardening host, a Gleaner, and how to volunteer to assist with food surplus distribution within their city. Discover the benefits, history and facts about gleaning. Additionally, user will have a full page map view of pinned gardeners location, ability to create a gardeners profile, and search for specific food resources by type and location.

## Technologies Used (past and present)

- C#/.NET 6
- ASP.NET CORE
- MVC API Client Front End
- Entity Framework Core
- EF Core Migrations
- Swashbuckle
- Swagger
- MySQL
- Rest Sharp
- Google MyMaps Integration, Google Icons
- Bootstrap
- Microsoft Azure API Hosting
- Render Web Services
- Microsoft Docker

## Stretch Goals (in developement)

- authO integration for user accounts/profile creation
- Disqus for commenting on profiles

## Setup/Installation Requirements 
* (API/MySQL Instructions removed for now, Database is hardcoded.)

1. Clone this repository
2. Navigate to the client directory using `cd BackyardGleanersClient`
3. Run `dotnet watch run` to use the app locally
4. Optionally visit the site hosted on Render, link above.
5. Feel free to explore the BackyardGleanersApi code, although it is not in use at this time.

## Known Bugs

- 11/05/23: WIP Search functionality
- 08/10/23: Working thru possibly migrating database from Azure to another service. API is shut down for now. In development

### Research & Planning Log:

#### Friday 7/7

- 8:42: researching combining api/client to one repo
- 9:18: may separate into individual projects for modularity
- 9:39: creating combined api/client test project to see how to run project from singular repo
- 10:29: cannot run both api/client in same repo, testing failed
- 11:11: attempting to combine api/client in test project. close
- 11:23: Successfully combined API & Client to a single .Solution project and launched interface!
- 12:59: Looking into embedding location based google maps for each host
- 1:28: Successfully embed custom location based google map on profile view in tests
- 1:56: Researching creating a full independent map view with each host pinned, click pin to go to details
- 2:39: Building initial host Model.cs
- 2:53: Working on Capstone Proposal file
- 3:26: Create initial Host database in MySQL
- 3:49: Building seed database model
- 3:55: updating README fields
- 4:15: research authentication and user roles
- 4:45: Fix corrupted API directory
- 4:52: Building seeded database, Host Controller

#### Friday 7/14

- 8:00: Studying donation form integration
- 8:46: Looking into Google Cal integration
- 9:22: building api controllers
- 10:21: researching user comment section for gardeners
- 11:55: building mvc client front end
- 2:57: break from building Client, researching Comment section
- 4:54: card layout forEach gardener successfull, building views, push and submit

#### Saturday 7/15

- 2:00: Research theme switcher for dark mode toggle

#### Friday 7/21

- 8:16: Research migrating search function to use navbar instead of opening View
- 4:30: Looking into Hosting on a Azure, Render

#### Tuesday 7/25

- 11:55: WIP: Adding Identity is causing many issues, may have to add to stretch goal

#### Wednesday 7/26

- 8:22: Plan for today:
  - Work through setting up hosting on Microsoft Azure
  - Try to debug account creation which was breaking the app
  - Add 'People We Like' / Resources page
  - Add improved unified style/possible css animation to About view
- 9:14: Azure Deployment in progress
- 10:47: Azure deployment success, after encountering Region error when selecting West US(2 or 3) when creating Web App, selecting default East US, deployed without error. moving to connecting database
- 12:00: Deployed Web App to Azure, waiting on live server status
- 4:22: WIP progress since lunch, troubleshooting 404 from Azure

#### Thursday 7/27 Presentation Day!

- 9:00: WIP, setting up an Azure Web App service for my MVC Client side
- 9:42: Polishing styles, working on Azure
- 10:16: Deployed Client side, waiting for results
- 1:43: Azure client side deployment issues, may move to Render for front end.

#### Friday 7/28

- Looking into hosting MVC Client side on Render
- 2:08: Troubleshooting Render deployment
- 3:41: Render Hosting Success for MVC! It's live!

[Back to Top](#backyard-gleaners)

## License

<a rel="license" href="http://creativecommons.org/licenses/by-nc/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc/4.0/88x31.png" /></a><br />This work is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by-nc/4.0/">Creative Commons Attribution-NonCommercial 4.0 International License</a>.

Copyright © 2023 Eusebie Siebenberg

Permission is hereby granted to:

- Share — copy and redistribute the material in any medium or format
- Adapt — remix, transform, and build upon the material
- Attribution — You must give appropriate credit, provide a link to the license, and indicate if changes were made. You may do so in any reasonable manner, but not in any way that suggests the licensor endorses you or your use.
- NonCommercial — You may not use the material for commercial purposes.

If you have any questions, comments, or concerns, please reach out to me at: siebenee@gmail.com
