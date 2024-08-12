<h1 align="center" style="font-weight: bold;">Mini Human Resource Information System</h1>

## Overview

This is a mini Human Resource Information System (HRIS) project built using C# and LINQ. It allows users to manage and view employee details along with their associated position information.

## Features

- Retrieve all employee details.
- Retrieve details of a specific employee by ID.


<h2 id="technologies">💻 Technologies</h2>

- C#
- LINQ
- ASP.NET Core (for Web API)
- Entity Framework Core (if used for data access)

# Employee API Spec

## Create Employee

Endpoint : POST /api/master/Employee

Request Body :

```json
{
  "positionId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "name": "string",
  "email": "string",
  "phone": "string",
  "status": "string"
}
```
