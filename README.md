# APIVersionTesting
Small solution of projects verifying API Versioning functionality in different .NET web API framework setups 
## Framework Setups Tested
The following different setups were tested with their own **ASP.NET Core**[^1] project
| Platform | Structuring | Versioning Library | Project |
| -------- | ----------- |--------------------| --------|
| .NET 7   | Using default MVC | Asp.Versioning [![NuGet Package](https://img.shields.io/nuget/v/Asp.Versioning.Mvc.svg)](https://www.nuget.org/packages/Asp.Versioning.Mvc)  | `SampleNet7APIService` |
| .NET 7   | Using OData       | Asp.Versioning [![NuGet Package](https://img.shields.io/nuget/v/Asp.Versioning.OData.svg)](https://www.nuget.org/packages/Asp.Versioning.OData) |         |
| .NET 6   | Using default MVC | Microsoft.AspNetCore.Mvc.Versioning |         |
| .NET 6   | Using OData       | Microsoft.AspNetCore.Mvc.Versioning |         |

[^1]: In these setups tested, we are using the *ASP.NET Core* web framework, which is not to be confused with the *ASP.NET* / *ASP.NET Web API* web framework

## Postman Testing
The services and the API endpoints created by them can be tested by running the service locally and using the Postman collection provided, consisting of requests testing the endpoints and attached with tests verifying with the expected result.
The Postman collection file can be imported into Postman.