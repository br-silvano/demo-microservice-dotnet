#!/bin/bash

dotnet restore OrderService.csproj
dotnet build OrderService.csproj
dotnet-ef database update --no-build
dotnet run OrderService.csproj
