# Demo Microservice

```bash
$ dotnet new solution -n Demo -o src
$ cd src
$ dotnet new webapi -n OrderService -o OrderService
$ dotnet sln add OrderService/OrderService.csproj
$ cd OrderService
$ dotnet add package Microsoft.EntityFrameworkCore
$ dotnet add package Microsoft.EntityFrameworkCore.Design
$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer
$ dotnet add package Microsoft.EntityFrameworkCore.Tools
$ dotnet add package Microsoft.AspNetCore.Mvc.Versioning
$ dotnet add package Serilog.AspNetCore
$ dotnet add package Serilog.Extensions.Logging
$ dotnet add package Serilog.Extensions.Hosting
$ dotnet add package Serilog.Sinks.RollingFile
$ dotnet add package Serilog.Sinks.Async
$ dotnet add package Microsoft.Extensions.Diagnostics.HealthChecks
$ dotnet add package Microsoft.Extensions.Diagnostics.HealthChecks.EntityFrameworkCore
```

## Entity Framework
```bash
$ dotnet-ef migrations add InitialCreate -o Migrations --no-build
$ dotnet-ef database update --no-build
```

## Web API versioning
> /api/v{version}/Order/Add

## Logging to microservice
> Serilogs

## Monitoring mechanism
> http://localhost:5000/checkhealth

## Documentation for microservices
> http://localhost:5000/swagger/

## Containerization using Docker
```bash
$ docker-compose up --build
$ docker exec -it microservice-order-service bash
$ chmod +x .docker/clean.sh
$ .docker/clean.sh
```

## Docker Image
```bash
$ docker build -t ms-order-service:latest ./src/OrderService/ -f ./src/OrderService/Dockerfile.prod --no-cache
```

## Requirements
- Docker
- Docker Compose

## Docs
- [Microservices Architecture](https://procodeguide.com/programming/microservices-asp-net-core/?amp#Microservices_Architecture)
- [Identity Provider](https://procodeguide.com/programming/aspnet-core-security/?amp)
- [Entity Framework](https://procodeguide.com/programming/entity-framework-core-in-asp-net-core/?amp)
- [Web API Versioning](https://procodeguide.com/programming/web-api-versioning-in-aspnet-core/?amp)
- [Serilog](https://procodeguide.com/programming/aspnet-core-logging-with-serilog/?amp)
