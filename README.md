# Cooking# 🍳

CookingSharp es una aplicación de escritorio y API para un recetario colaborativo, desarrollada con .NET y C#.

## Tabla de Contenidos
- [Descripción](#descripción)
- [Arquitectura](#arquitectura)
- [Cómo Empezar](#cómo-empezar)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Repositorio](#repositorio)

## Descripción

El objetivo de CookingSharp es servir como un sistema donde los usuarios pueden gestionar y compartir recetas, organizadas por categorías. Actúa como un proyecto de referencia para aplicar patrones de diseño modernos en el ecosistema .NET.

## Arquitectura

El proyecto busca seguir los principios de **Clean Architecture**, asegurando una clara separación de conceptos entre las diferentes capas de la aplicación. Esto permite que la lógica de negocio principal sea independiente de la interfaz de usuario y de la base de datos.

![Clean Architecture Diagram](https://blog.cleancoder.com/uncle-bob/images/2012-08-13-the-clean-architecture/CleanArchitecture.jpg)
*Diagrama conceptual de Clean Architecture por Robert C. Martin.*

## Cómo Empezar

Para ejecutar el proyecto, necesitarás tener instalado el SDK de .NET 8.

### 1. Ejecutar el Backend (la API)

1.  En el **Explorador de Soluciones**, haz clic derecho sobre la **Solución `CookingSharp.sln`** (el elemento de más arriba en el árbol).

2.  Selecciona **"Configurar proyectos de inicio..."** (o "Set Startup Projects...").

3.  En la ventana que aparece, selecciona la opción **"Varios proyectos de inicio"** (Multiple startup projects).

4.  Busca los proyectos `CookingSharp.WebAPI` y `CookingSharp.WindowsForms` en la lista.

5.  En la columna "Acción" (Action) de **ambos** proyectos, cambia el valor de "Ninguno" (None) a **"Iniciar"** (Start).

6.  Haz clic en "Aceptar" o "Aplicar".

Ahora, al presionar **F5**, Visual Studio compilará y ejecutará tanto la API (que se abrirá en tu navegador) como la aplicación de escritorio de Windows Forms al mismo tiempo.

## Estructura del Proyecto

La solución está organizada en carpetas que representan las capas de Clean Architecture:

-   `1. Presentation/`: Interfaces de usuario.
    -   `CookingSharp.WebAPI`: Proyecto de la API RESTful.
    -   `CookingSharp.WindowsForms`: Aplicación de escritorio.
-   `2. Application/`: Lógica de los casos de uso.
    -   `CookingSharp.Application.Services`: Servicios de la aplicación.
    -   `CookingSharp.DTOs`: Objetos de Transferencia de Datos.
-   `3. Domain/`: El núcleo del negocio.
    -   `CookingSharp.Domain.Model`: Entidades puras.
-   `4. Infrastructure/`: Implementaciones de servicios externos.
    -   `CookingSharp.Data`: Lógica de persistencia de datos.
    -   `CookingSharp.API.Clients`: Clientes para consumir la API.

---

## Repositorio

Código fuente y avances en:

https://github.com/NiconiKimg/CookingSharp