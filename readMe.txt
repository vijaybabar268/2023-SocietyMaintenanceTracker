Create .NET 7 Web api project
-----------------------------
dotnet --info
dotnet new sln
dotnet new webapi -o API
dotnet sln add .\API\

Build & Run .NET 7 Web api project
-----------------------------
dotnet watch run

Run .NET 6 Web api as Dcoker (Added dockerfile, global.json)
-----------------------------
docker build -t smt .
docker run --rm -p 5000:5000 -p 5001:5001 -e ASPNETCORE_HTTP_PORT=https://+:5001 -e ASPNETCORE_URLS=http://+:5000 smt
or 
docker run --rm -p 5005:5005 -e ASPNETCORE_URLS=http://+:5005 smt