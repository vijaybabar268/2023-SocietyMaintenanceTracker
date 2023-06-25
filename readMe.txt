#Create .NET 7 Web api project
-----------------------------
dotnet --info
dotnet new sln
dotnet new webapi -o API
dotnet sln add .\API\

#Build & Run .NET 7 Web api project
-----------------------------
dotnet watch run

#Run .NET 6 Web api as Dcoker (Added dockerfile, global.json)
-----------------------------
docker build -t smt .
docker run --rm -p 5000:5000 -p 5001:5001 -e ASPNETCORE_HTTP_PORT=https://+:5001 -e ASPNETCORE_URLS=http://+:5000 smt
or 
docker run --rm -p 5005:5005 -e ASPNETCORE_URLS=http://+:5005 smt

#Nugat Lib's
-----------------------------
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

#Entity Framework Core .NET Command-line Tools update command
-----------------------------
dotnet tool update --global dotnet-ef

#donet ef migrations commands
-----------------------------
dotnet-ef
dotnet ef migrations add InitialCreate -o Data/Migrations -v
dotnet ef database update

-- specific version command
dotnet tool install --global dotnet-ef --version 7.0.5

# Sample Connection String
"DefaultCS": "data source=VIJAYBABAR\\SQLEXPRESS3;initial catalog=TestDb;user id=sa;password=Pass12345!@#$%;TrustServerCertificate=True"

#Project Structure
-----------------------------
Entities -> POCO Classes
Data -> DataContext
    Migrations

