# .NET Standard Workshop - Hands on Lab II
En este Lab utilizaremos el repo creado en el Lab I para hostear un proyecto de biblioteca .NET Standard 
que implemente un cliente tipado para la API que cada coder elija.

## Crear un proyecto .NET Standard

- Desde Visual Studio
Nuevo proyecto -> Bibliotecac de Clases (.NET Standard)

- Utilizando .NET CLI y Visual Studio Code
Instalar extension C# para VS Code

``` 
dotnet new classlib -f netstandard1.4
dotnet restore
```

Abrir la carpeta actual en VS Code
``` 
code .
```
## Utilizar HttpClient para acceder a APIs REST
```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyApi
{
    public class MyApiClient
    {
        public string ApiUrl {get; set;} = "http://my.api.url";
        public string ApiKey {get; set;} = "MY-API-KEY";
        public async Task<string> GetData()
        {
            var result = string.Empty;
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                
                var response = await client.GetAsync(ApiUrl);
                
                if(response.IsSuccessStatusCode)
                    result = await response.Content.ReadAsStringAsync();
            }

            return result;
        }
    }
}
```csharp

## Agregar un paquete NuGet a nuestro proyecto
- Desde Administar paquetes de NuGet para el proyecto...
Ingresar a esta opción desde el menu contextual del Solution Explorer y seleccionar el paquete
- Desde el Package Administration Console
``` 
install-package newtonsoft.json
```
- Desde .NET CLI
``` 
dotnet add package newtonsoft.json
```

## Crear un paquete NuGet

- Desde Visual Studio
VS lo hace automáticamente en el build!
Podemos configurar la metadata desde las propiedades del proyecto 
- Utilizando NuGet Package Explorer


## Publicar un paquete a nuget.org
- Crear una cuenta de usuario en [NuGet](https://nuget.org)
- Realizar el upload del paquete