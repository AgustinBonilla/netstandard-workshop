# .NET Standard Workshop - Hands on Lab II
En este Lab utilizaremos el nuevo repo creado en el Lab I para hostear un proyecto de biblioteca .NET Standard 
que implemente un cliente tipado para la API que cada coder elija.

## 1 - Crear un proyecto .NET Standard en la carpeta lib
Desde Visual Studio
- Nuevo proyecto -> Biblioteca de Clases (.NET Standard)
``` 
install-package newtonsoft.json
``` 

Utilizando .NET CLI y Visual Studio Code
- Instalar extensión C# para VS Code

``` 
dotnet new classlib 
dotnet add package newtonsoft.json
dotnet restore
code .
```

Renombrar .csproj, namespace y class para ajustarlo al proyecto (por default toma el nombre de la carpeta). También pueden utilizar el parámetro -n "name"  -o . (y nombre y salida en el directorio actual) en la línea de comandos.
 
## 2 - Utilizar HttpClient para acceder a APIs REST
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
```

- Según cada API, es necesario configurar ciertos Headers y Api Keys
- Luego sería ideal agregar validaciones de parámetros y control de respuestas

## 3 - Deseralizar json a clase .NET
- Agregar using
```csharp
using Newtonsoft.Json;
```
Agregar clases para representar los datos tipados de la respuesta de la API
- Podemos usar [json2csharp](http://json2csharp.com/) para generar automáticamente las clases de respuesta usando un json de muestra
- Newtonsoft.Json tiene diversos mecanismos para controlar la deserialización, como JsonProperty
```csharp
[JsonProperty(PropertyName = "FooBar")]
public string Foo { get; set; }
```
Deserializar utilizando JsonConvert
```csharp
var json = await response.Content.ReadAsStringAsync();
var obj = JsonConvert.DeserializeObject<MyEntity>(json);
```
## 4 - Agregar un proyecto de prueba en la carpeta test
Moverse a la carpeta test y agregar un proyecto de MSTest

Desde Visual Studio
- Nuevo proyecto -> Proyecto de Prueba Unitaria (.NET Core)
- Agregar referencia al proyecto en ../lib

Utilizando .NET CLI y Visual Studio Code
- Instalar extensión C# para VS Code

``` 
cd test
dotnet new mstest 
dotnet add reference ../lib/projectName.csproj
dotnet restore
code .
dotnet build
dotnet test
```

Agregar solución en la raiz del src en VS o via .NET CLI
``` 
dotnet new sln -n "SOLUTION-NAME.sln"
dotnet sln SOLUTION-NAME.sln add lib/PROJECT-NAME.csproj
dotnet sln SOLUTION-NAME.sln add test/Tests.csjproj
``` 

## 5 - Crear un paquete NuGet
Desde Visual Studio
- VS lo puede hacer automáticamente en el build
- Podemos configurar la metadata desde las propiedades del proyecto

Build Release desde VS
- Configuration Manager (Release)

Desde .NET CLI
```
dotnet pack -c release
```

Utilizando NuGet Package Explorer
- Crear nuevo paquete
- Editar metadatos
- Agregar dependencias para el grupo netstandard2.0
- Agregar dependencia a NETStandard.Library y Newtonsoft.Json
- Agregar contenido /lib/netstanard2.0
- Save



## 6 - Publicar un paquete a nuget.org
- Crear una cuenta de usuario en [NuGet](https://nuget.org)
- Realizar el upload del paquete