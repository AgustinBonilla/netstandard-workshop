# .NET Standard Workshop - Hands on Lab IV
En este Lab dotaremos a nuestro proyecto de Integración Continua utilizando AppVeyor.

## 1 - Configuración en GitHub
- GitHub Marketplace
- Install AppVeyor
- Authorize AppVeyor

## 2 - Configuración en NuGet
- Crear API Key https://www.nuget.org/account/ApiKeys

## 3 - Configuración en AppVeyor
- https://ci.appveyor.com/projects
- Authorize GitHub
- Add Repository
- Add Deployment

https://dot.net/v1/dotnet-install.ps1 

- Environment Config change Build Worker image to Visual Studio 2017 
- Build Config add Before Build Script

  ``` 
  nuget restore src
  ``` 

## 4 - Versionar elementos de CI en el repo

Agregar Status Badge en README.md

Exportar y agregar appveyor.yml al repo