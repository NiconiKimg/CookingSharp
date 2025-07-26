# ?? CookingSharp - Plataforma Colaborativa de Recetas

CookingSharp es un sistema de gesti�n de recetas de cocina dise�ado para permitir a una comunidad de usuarios crear, compartir y organizar contenido gastron�mico de manera colaborativa.

---

## ??? Arquitectura del Proyecto

El proyecto est� construido siguiendo los principios de **Clean Architecture** para garantizar una separaci�n clara de responsabilidades, alta mantenibilidad y testeabilidad. La soluci�n est� organizada en las siguientes capas l�gicas:

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
