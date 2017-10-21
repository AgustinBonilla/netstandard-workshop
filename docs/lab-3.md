# .NET Standard Workshop - Hands on Lab III
En este Lab crearemos proyectos en distintas plataformas .NET para implementar nuestros paquetes .NET Standard.

## 1 - NET Core Console App 

Crear una carpeta samples en la raiz de su repo GitHub, agregar proyectos con código que muestre el uso de su librería .NET Standard

### Desde Visual Studio
- Nuevo proyecto -> Aplicación de Consola (.NET Core), ubicarlo dentro de samples
- Confirmar cambios
- Sincronizar

### Desde .NET CLI y Visual Studio Code

``` 
mkdir consolesample
cd consolesample
dotnet new console
dotnet add package yourpackage
dotnet restore
code .
dotnet build
dotnet run
git add .
git commit -m "sample commit"
git push
```

## 2 - Crear Workspace Ubuntu en cloud9
Ingresar a [cloud9](https://c9.io) y crear una cuenta
- Seleccionar Template Blank (Logo de Ubuntu)
- Agegar espacio en el disco del Workspace (llevarlo a 3 GB)
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

### Desde Visual Studio
- Nuevo proyecto -> Cross Platform App (Xamarin)

