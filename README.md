# Cooking# 🍳

CookingSharp es una plataforma completa para un recetario colaborativo, con aplicación web (Blazor WebAssembly), API RESTful y aplicación de escritorio Windows Forms, desarrollada con .NET 8 y C#.

## Tabla de Contenidos

- [Descripción](#descripción)
- [Características](#características)
- [Arquitectura](#arquitectura)
- [Tecnologías Utilizadas](#tecnologías-utilizadas)
- [Cómo Empezar](#cómo-empezar)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Base de Datos](#base-de-datos)
- [Repositorio](#repositorio)

## Descripción

CookingSharp es un sistema integral donde los usuarios pueden crear, compartir y descubrir recetas culinarias. La aplicación ofrece diferentes roles de usuario (Aprendiz, Chef y Administrador), permitiendo la colaboración y gestión de contenido de manera organizada.

## Características

- **Gestión de Recetas**: Crear, editar y publicar recetas con pasos detallados e imágenes (integración con Cloudinary)
- **Sistema de Roles**: Aprendices, Chefs y Administradores con permisos diferenciados
- **Menús Personalizados**: Los chefs pueden crear menús combinando múltiples recetas
- **Sistema de Valoraciones**: Los usuarios pueden calificar recetas y menús
- **Comentarios**: Interacción entre usuarios en cada receta
- **Reportes en PDF**: Generación de reportes analíticos para administradores
- **Autenticación JWT**: Sistema de autenticación seguro con tokens
- **Múltiples Interfaces**: WebApp con MudBlazor y aplicación de escritorio Windows Forms

## Arquitectura

El proyecto sigue los principios de **Clean Architecture** con una clara separación de responsabilidades entre capas. Además, implementa el patrón **Repository** y **Unit of Work** para la gestión de datos, y utiliza **AutoMapper** para el mapeo entre entidades de dominio y DTOs.

![Clean Architecture Diagram](https://blog.cleancoder.com/uncle-bob/images/2012-08-13-the-clean-architecture/CleanArchitecture.jpg)
_Diagrama conceptual de Clean Architecture por Robert C. Martin._

### Patrones Implementados

- **Repository Pattern**: Abstracción del acceso a datos
- **Unit of Work**: Coordinación de transacciones
- **Dependency Injection**: Inyección de dependencias en todas las capas
- **CQRS**: Separación de comandos y consultas en servicios
- **DTO Pattern**: Transferencia de datos entre capas
- **Middleware Pattern**: Manejo centralizado de excepciones

## Tecnologías Utilizadas

### Backend

- **.NET 8**: Framework principal
- **Entity Framework Core**: ORM para acceso a datos
- **SQL Server**: Base de datos relacional
- **AutoMapper**: Mapeo objeto-objeto
- **FluentValidation**: Validación de DTOs
- **BCrypt.NET**: Hash de contraseñas
- **JWT**: Autenticación basada en tokens
- **QuestPDF**: Generación de reportes PDF
- **Cloudinary**: Almacenamiento de imágenes

### Frontend

- **Blazor WebAssembly**: Aplicación web SPA
- **MudBlazor**: Biblioteca de componentes UI
- **Windows Forms**: Aplicación de escritorio nativa

## Cómo Empezar

Para ejecutar el proyecto, necesitarás tener instalado:

- .NET 8 SDK
- SQL Server (LocalDB o instancia completa)
- Visual Studio 2022 (recomendado) o Visual Studio Code

### 1. Configurar la Base de Datos

1. Abre el archivo `appsettings.json` en el proyecto `CookingSharp.WebAPI`
2. Ajusta la cadena de conexión según tu entorno
3. Ejecuta las migraciones:
   ```bash
   dotnet ef database update --project CookingSharp.Infrastructure --startup-project CookingSharp.WebAPI
   ```
4. (Opcional) Ejecuta el script `seed-database.sql` para poblar la base de datos con datos de ejemplo

### 2. Configurar Cloudinary (Opcional)

Si deseas usar el almacenamiento de imágenes:

1. Crea una cuenta gratuita en [Cloudinary](https://cloudinary.com)
2. Agrega tu configuración en `appsettings.json`:
   ```json
   "CloudinarySettings": {
     "CloudName": "tu-cloud-name",
     "ApiKey": "tu-api-key",
     "ApiSecret": "tu-api-secret"
   }
   ```

### 3. Ejecutar la Aplicación

#### Opción A: Ejecutar API + Windows Forms

1. En el **Explorador de Soluciones**, haz clic derecho sobre la **Solución `CookingSharp.sln`**
2. Selecciona **"Configurar proyectos de inicio..."**
3. Selecciona **"Varios proyectos de inicio"**
4. Marca `CookingSharp.WebAPI` y `CookingSharp.WindowsForms` como **"Iniciar"**
5. Presiona **F5**

#### Opción B: Ejecutar API + WebApp

1. Primero inicia la API:
   ```bash
   cd CookingSharp.WebAPI
   dotnet run
   ```
2. En otra terminal, inicia la WebApp:
   ```bash
   cd WebApp
   dotnet run
   ```
3. Accede a `https://localhost:7062` (o el puerto que indique la consola)

### Credenciales de Prueba

Si ejecutaste el script `seed-database.sql`, puedes usar estas credenciales:

- **Administrador**: `admin@cookingsharp.com` / `12345678`
- **Chef**: `chef1@gmail.com` / `12345678`
- **Aprendiz**: `usuario1@gmail.com` / `12345678`

## Estructura del Proyecto

La solución está organizada siguiendo Clean Architecture:

```
CookingSharp/
│
├── CookingSharp.Domain/                    # Capa de Dominio (Entidades y Enums)
│   ├── Entities/                           # Entidades del negocio
│   │   ├── User.cs                         # Usuario con roles (Admin, Chef, Apprentice)
│   │   ├── Recipe.cs                       # Receta con pasos y categorías
│   │   ├── RecipeStep.cs                   # Paso de una receta
│   │   ├── Category.cs                     # Categoría de recetas
│   │   ├── Menu.cs                         # Menú con múltiples recetas
│   │   ├── Comment.cs                      # Comentario en receta
│   │   ├── RecipeRating.cs                 # Valoración de receta
│   │   ├── MenuRating.cs                   # Valoración de menú
│   │   └── Appeal.cs                       # Solicitud para ser Chef
│   └── Enums/                              # Enumeraciones
│       ├── UserRole.cs                     # Roles de usuario
│       ├── RecipeStatus.cs                 # Estados de receta
│       └── AppealStatus.cs                 # Estados de solicitud
│
├── CookingSharp.Application/               # Capa de Aplicación (Casos de Uso)
│   ├── Services/                           # Servicios de aplicación
│   │   ├── UserService.cs
│   │   ├── RecipeService.cs
│   │   ├── MenuService.cs
│   │   ├── AuthService.cs
│   │   ├── RatingService.cs
│   │   ├── CommentService.cs
│   │   ├── CategoryService.cs
│   │   ├── AppealService.cs
│   │   ├── DashboardService.cs
│   │   └── ReportService.cs
│   ├── DTOs/                               # Objetos de Transferencia de Datos
│   ├── Validators/                         # Validadores con FluentValidation
│   ├── Contracts/                          # Interfaces de repositorios
│   └── Common/
│       ├── Mapping/                        # Perfiles de AutoMapper
│       └── Exceptions/                     # Excepciones personalizadas
│
├── CookingSharp.Infrastructure/            # Capa de Infraestructura
│   ├── Persistence/
│   │   ├── CookingSharpDbContext.cs        # Contexto de Entity Framework
│   │   ├── Configurations/                 # Configuraciones de entidades
│   │   ├── Repositories/                   # Implementaciones de repositorios
│   │   │   ├── GenericRepository.cs        # Repositorio genérico base
│   │   │   ├── UnitOfWork.cs               # Patrón Unit of Work
│   │   │   ├── UserRepository.cs
│   │   │   ├── RecipeRepository.cs
│   │   │   ├── MenuRepository.cs
│   │   │   └── ...
│   │   └── Migrations/                     # Migraciones de EF Core
│   ├── Auth/
│   │   ├── JwtTokenGenerator.cs            # Generación de tokens JWT
│   │   └── PasswordHasher.cs               # Hash de contraseñas con BCrypt
│   ├── Reporting/
│   │   └── PdfReportGenerator.cs           # Generación de PDFs con QuestPDF
│   └── PhotoService.cs                     # Integración con Cloudinary
│
├── CookingSharp.WebAPI/                    # API RESTful
│   ├── Controllers/                        # Controladores de la API
│   │   ├── AuthController.cs               # Autenticación y registro
│   │   ├── RecipesController.cs            # CRUD de recetas
│   │   ├── MenusController.cs              # CRUD de menús
│   │   ├── CategoriesController.cs
│   │   ├── UsersController.cs
│   │   ├── CommentsController.cs
│   │   ├── RatingsController.cs
│   │   ├── AppealsController.cs
│   │   ├── DashboardController.cs
│   │   └── ReportsController.cs
│   ├── Middleware/
│   │   └── ExceptionHandlingMiddleware.cs  # Manejo global de excepciones
│   └── Program.cs                          # Configuración y punto de entrada
│
├── WebApp/                                 # Aplicación Web Blazor WebAssembly
│   ├── Pages/                              # Páginas Razor
│   │   ├── Index.razor                     # Dashboard principal
│   │   ├── Login.razor                     # Inicio de sesión
│   │   ├── Register.razor                  # Registro de usuario
│   │   ├── Recipes.razor                   # Explorar recetas
│   │   ├── RecipeDetail.razor              # Detalle de receta
│   │   ├── CreateRecipe.razor              # Crear receta
│   │   ├── EditRecipies.razor              # Editar receta
│   │   ├── MyRecipes.razor                 # Mis recetas (Chef)
│   │   ├── Menus.razor                     # Explorar menús
│   │   ├── MenuDetail.razor                # Detalle de menú
│   │   ├── MyMenus.razor                   # Mis menús (Chef)
│   │   ├── CreateMenu.razor                # Crear menú
│   │   └── ChefApplication.razor           # Solicitar ser Chef
│   ├── Shared/                             # Componentes compartidos
│   │   ├── Layout/
│   │   │   ├── MainLayout.razor            # Layout principal con MudBlazor
│   │   │   ├── NavMenu.razor               # Menú de navegación
│   │   │   └── TopAppBar.razor             # Barra superior
│   │   ├── RecipeCard.razor                # Tarjeta de receta
│   │   ├── MenuCard.razor                  # Tarjeta de menú
│   │   └── Dialog/
│   │       └── CreateAppealDialog.razor    # Diálogo para solicitar ser Chef
│   ├── Auth/
│   │   └── CustomAuthStateProvider.cs      # Proveedor de estado de autenticación
│   ├── Handlers/
│   │   └── AuthenticationHeaderHandler.cs  # Handler para agregar JWT a requests
│   ├── Services/                           # Servicios del lado del cliente
│   └── DTOs/                               # DTOs para el frontend
│
├── CookingSharp.WindowsForms/              # Aplicación de Escritorio
│   ├── Features/                           # Características organizadas por módulos
│   │   ├── Authentication/                 # Login y registro
│   │   ├── Dashboard/                      # Dashboards por rol
│   │   ├── Users/                          # Gestión de usuarios (Admin)
│   │   ├── Categories/                     # Gestión de categorías (Admin)
│   │   ├── Recipes/                        # Gestión de recetas
│   │   ├── Chef/                           # Panel de chef
│   │   ├── Apprentice/                     # Panel de aprendiz
│   │   ├── Appeals/                        # Gestión de solicitudes (Admin)
│   │   └── Reports/                        # Reportes (Admin)
│   └── Resources/                          # Recursos (imágenes, iconos)
│
└── CookingSharp.Clients/                   # Clientes HTTP para consumir la API
    ├── AuthApiClient.cs
    ├── RecipeApiClient.cs
    ├── MenuApiClient.cs
    ├── UserApiClient.cs
    ├── CategoryApiClient.cs
    ├── CommentApiClient.cs
    ├── RatingApiClient.cs
    ├── AppealApiClient.cs
    ├── ReportApiClient.cs
    ├── SessionManager.cs                   # Gestión de sesión
    └── AuthenticationHandler.cs            # Handler para agregar JWT
```

## Base de Datos

El proyecto utiliza **SQL Server** con **Entity Framework Core** para la persistencia de datos.

### Modelo de Datos

- **Users**: Usuarios con roles diferenciados (Admin, Chef, Apprentice)
- **Recipes**: Recetas con título, descripción, imagen y estado
- **RecipeSteps**: Pasos ordenados de cada receta
- **Categories**: Categorías para organizar recetas (relación N:N)
- **Menus**: Colecciones de recetas creadas por chefs
- **RecipeRatings / MenuRatings**: Sistema de valoraciones (1-5 estrellas)
- **Comments**: Comentarios de usuarios en recetas
- **Appeals**: Solicitudes de usuarios para convertirse en chefs

### Migraciones

Para crear una nueva migración:

```bash
dotnet ef migrations add NombreDeLaMigracion --project CookingSharp.Infrastructure --startup-project CookingSharp.WebAPI
```

Para aplicar migraciones:

```bash
dotnet ef database update --project CookingSharp.Infrastructure --startup-project CookingSharp.WebAPI
```

## Repositorio

**Código fuente y documentación completa en:**

[https://github.com/NiconiKimg/CookingSharp](https://github.com/NiconiKimg/CookingSharp)
