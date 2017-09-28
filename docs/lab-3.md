# .NET Standard Workshop - Hands on Lab I
En este Lab repasamos los primeros pasos para trabajar con GitHub, una plataforma de desarrollo colaborativo 
para alojar proyectos utilizando el sistema de control de versiones Git.

## Crear repositorios

- Ingresar a [GitHub](https://github.com/) y crear una cuenta (o Sign in si ya tenían una)
- Crear un fork de [netstandard-workshop](https://github.com/matiasdieguez/netstandard-workshop)
- Clonarlo para descargar localmente el fork
```git clone https://github.com/YOUR-ACCOUNT/netstandard-workshop```
- Crear un nuevo repositorio
- Seleccionar VisualStudio como template de .gitignore para omitir archivos no versionables
- Seleccionar una licencia para generar el archivo LICENSE
- Clonar tu repositorio localmente
```git clone https://github.com/YOUR-ACCOUNT/REPO-NAME```

## Agregar archivos, protegerlos y sincronizarlos

- Agregar un archivo README.md para agregar una descripción del proyecto utilizando [Markdown](https://guides.github.com/features/mastering-markdown/) 
- Informar al repo de las adiciones
``` git add .```
- Confirmar cambios
``` git commit -m "comentario" ```
- Publicar cambios
``` git push ```