# Relativity_Capstone

Fred lives near an airport and hears a lot of planes overhead throughout the day. After a while Fred notices that airplane traffic changes significantly from day to day. Some days there are lots of planes overhead on their way to land, and other days there are barely any planes at all. After performing some research, Fred discovers that planes always take off and land against the prevailing wind. He concludes that overhead airplane traffic for any given day depends on the wind direction.

Fred then gets a brilliant business idea: build a website that predicts the direction of airplane traffic based on the weather report. This will help homeowners near an airport plan the best days to picnic outside and throw awesome parties in their back yards.

Your goal is to build a web application that predicts the landing pattern (the direction from which planes will land) for any airport in the world. The website should provide an airport listing and search feature. The user can select an airport of interest and see the predicted airplane traffic over the next several days.

To solve this problem, you will need several pieces of information:

* A list of airports around the world

* The directions of the runways at each airport

* A weather report for any given airport

Your web application will combine these data points to predict the landing pattern for a given airport. The information will be displayed to the user in a simple but user-friendly website. Your target persona is a homeowner who lives near an airport and wants to see a plane traffic forecast.

The website will be driven by a RESTful API. All business logic will be contained within the API surface, and the API should be callable independent of the UI layer. The API should follow good RESTful design principles.

The backend data will be stored in a SQL Server database. Airport and runway data will be imported from http://ourairports.com/data/ Weather predictions will be retrieved from the APIs at https://openweathermap.org/api using the site’s free service tier. Because retrieving weather data from the API is a heavy operation, we want to cache the weather lookup (per airport) for an hour.

The solution will be built in .NET Core / ASP.Net Core on the backend. You can use any front-end framework you wish. We suggest using AngularJS, React, Aurelia, or another modern JS framework on of your choosing for the front-end.

The solution will be unit tested to ensure correctness. All calculations around the landing pattern should be thoroughly tested with multiple test cases. Unit tests should never hit the database or a web service, so you will need to use object-oriented principles to separate the network calls from your main calculation logic.

The solution will be hosted in Microsoft Azure’s free tier (https://azure.microsoft.com/en-us/free/services/sql-database/). The website will be hosted in Azure AppService, while the database will use Azure SQL Database (Microsoft’s managed SQL Server offering).

The solution will be developed using Git and will be deployed using Azure’s AppService deployment workflow (push to local Git repo -> push to private Azure Git repo -> deploy to staging -> promote to production).

ADDITIONAL ACCEPTANCE CRITERIA:

* The website does not require any authentication (this is a public site)

* Do not hard-code any credential in source code

BONUS GOALS:

* Create an automated job in Azure to refresh the airport and runway data in the database

* Build integration tests that hit the API in Azure and validate that the service is working. Use these integrations tests to verify that the AppService staging site is running properly before promoting to production.

* Write a PowerShell script that fully automates the software development lifecycle: compile, unit test, publish to staging, integration test, promote to production.
