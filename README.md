# DeltaCore MVC 

This is a MVC application built on the .NET Core + Angular stack that demonstrates the implementation of SOLID principles within the given code spec. 

## Technology Stack:
 - C#
 - ASP.NET
 - AngularJS
 - Bootstrap
  
## Objective: 
 - Demonstrate implementation of SOLID principles within the given code spec.

## Object Model:

```json
{
  "id": "number",
  "name": "string",
  "description": "string"
}
```
+ id: The unique identifier for the product, 4-digit integer.
+ name: The name of the product, max length of 50 characters.
+ description: The description of the product, max length of 1000 characters.

## Running the application:
1. Setup the dependencies
   ```PowerShell
   dotnet restore
   ```
2. Run the application
	```PowerShell
	dotnet run
	```
The runtime will automatically resolve the node modules and run the application.

