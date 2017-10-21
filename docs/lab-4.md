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

- Environment Config change Build Worker image to Visual Studio 2017 
- Environment Config add Install script cmd:
```
appveyor downloadfile https://dist.nuget.org/win-x86-commandline/v4.3.0/nuget.exe
```
- Build Config add Before build script cmd:
```
nuget restore src
```
## 4 - Versionar elementos de CI en el repo

Exportar y agregar appveyor.yml al repo

```yml
version: 1.0.{build}
image: Visual Studio 2017
configuration: Release
dotnet_csproj:
  patch: true
  file: '**\*.csproj'
  version: '{version}'
  package_version: '{version}'
install:
- cmd: appveyor downloadfile https://dist.nuget.org/win-x86-commandline/v4.3.0/nuget.exe
before_build:
- cmd: nuget restore src
build:
  publish_nuget: true
  publish_nuget_symbols: true
  verbosity: minimal
``` 
Agregar Status Badge en README.md
