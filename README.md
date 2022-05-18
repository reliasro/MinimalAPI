# MinimalAPI

This is small REST API developed with ASP NET Core and using the minimal API concept.
The model is a simplistic entity: Invoice.

Minimal API use low nuget packages dependencies, less resources and the like. You wont find controllers, filters, etc. The idea is publish a RESTful API with the less amount of resources.
You can create one from the CLI:

>dotnet new web -n myMinimalAPI

The list is kept in memory. But you can go further and implement Entity Framework Core.


### End Points
- GET https://localhost:7052/invoices
- GET https://localhost:7052/invoices/id
- POST https://localhost:7052/invoices/
- DELETE https://localhost:7052/invoices/


### You can find a PostMan collection file for faster testing.

Enjoy!



