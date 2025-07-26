# ?? CookingSharp - Plataforma Colaborativa de Recetas

CookingSharp es un sistema de gestión de recetas de cocina diseñado para permitir a una comunidad de usuarios crear, compartir y organizar contenido gastronómico de manera colaborativa.

---

## ??? Arquitectura del Proyecto

El proyecto está construido siguiendo los principios de **Clean Architecture** para garantizar una separación clara de responsabilidades, alta mantenibilidad y testeabilidad. La solución está organizada en las siguientes capas lógicas:

```
??? ?? CookingSharp.sln
    ??? ?? 1. Presentation
    ?   ??? ?? WebAPI
    ?   ??? ?? WindowsForms
    ?
    ??? ?? 2. Application
    ?   ??? ?? Application.Services
    ?   ??? ?? DTOs
    ?
    ??? ?? 3. Domain
    ?   ??? ?? Domain.Model
    ?
    ??? ?? 4. Infrastructure
        ??? ?? API.Clients
        ??? ?? Data
```
