# .NET Standard Workshop - Hands on Lab III
En este Lab crearemos proyectos en distintas plataformas .NET para implementar nuestros paquetes .NET Standard.

## 1 - NET Core Console App & ASP.NET Core MVC

Crear una carpeta Samples en su repo GitHub

Desde Visual Studio
- Nuevo proyecto -> Aplicación de Consola (.NET Core)
- Nuevo proyecto -> Aplicacion web ASP.NET Core

Utilizando .NET CLI y Visual Studio Code
- Console App
``` 
dotnet new console
``` 

- ASP.NET Core MVC
``` 
dotnet new mvc
``` 

- Agregado de paquetes, codeo, build y push
``` 
dotnet add package yourpackage
dotnet restore
code .
dotnet build
dotnet run
git add .
git commit -m "first commit"
git push
```

## 2 - Crear Workspace Ubuntu en cloud9
Ingresar a [cloud9](https://c9.io) y crear una cuenta
- Seleccionar Template Blank (Logo de Ubuntu)
- Clonar su repositorio

Instalar .NET Core en Ubuntu
- Referencia [.NET Core en Ubuntu Linux](https://www.microsoft.com/net/core#linuxubuntu)

```bash
curl https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.gpg

sudo mv microsoft.gpg /etc/apt/trusted.gpg.d/microsoft.gpg

sudo sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/repos/microsoft-ubuntu-trusty-prod trusty main" > /etc/apt/sources.list.d/dotnetdev.list'

sudo apt-get update

sudo apt-get install dotnet-sdk-2.0.0
``` 

## 3 - Android, iOS y UWP

Desde Visual Studio
- Nuevo proyecto -> Cross Platform App (Xamarin)

