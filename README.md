### Universidad: Tecnologico de Software
### Materia: Arquitectura de Software
### Maestro: Jorge Javier Pedroza Romero
### Alumno: Heidi Esther Peña Betanzos
### Grado: 3B

# 🎮 CatálogoApp — Catálogo de Videojuegos

Proyecto desarrollado en clase y casa para aprender **arquitectura en capas** en ASP.NET Core MVC, reutilización de código entre proyectos y corrección de errores.

---

## 🖼️ Capturas de pantalla

### 🏠 Home
<img width="1918" height="1077" alt="Captura de pantalla 2026-05-23 000313" src="https://github.com/user-attachments/assets/1adfaf6a-181f-4067-b6ab-50dbfc62c1f6" />


### 📋 Catálogo
<img width="1919" height="1023" alt="Captura de pantalla 2026-05-23 002008" src="https://github.com/user-attachments/assets/c869612a-e718-4d1c-9e18-45e9c21740fa" />


### 🔍 Detalle y Reseñas
<img width="1919" height="1079" alt="Captura de pantalla 2026-05-23 000329" src="https://github.com/user-attachments/assets/c39a6452-e0d6-4580-968d-724ecb64671a" />


### 🔐 Login
<img width="1919" height="1073" alt="Captura de pantalla 2026-05-23 000318" src="https://github.com/user-attachments/assets/9286c803-c84a-4c5e-a0c9-383bcca85f5f" />


---

## 🛠️ Tecnologías usadas

| Tecnología | Uso |
|---|---|
| ASP.NET Core MVC (.NET 8) | Framework principal |
| C# | Lenguaje de programación |
| Razor Views (.cshtml) | Vistas del lado del servidor |
| System.Text.Json | Persistencia de datos en archivos JSON |
| Sesiones HTTP | Autenticación de usuarios sin base de datos |

---

## 📚 ¿Qué aprendimos?

- Diseño en **capas (Clean Architecture)**:
  - `Domain` → modelos e interfaces
  - `Application` → servicios y lógica de negocio
  - `Infrastructure` → repositorios y acceso a datos (JSON)
  - `Presentation` → controladores y vistas MVC
- Cómo **reutilizar código** de un proyecto anterior
- **Inyección de dependencias** en ASP.NET Core
- Persistencia de datos con archivos **JSON** sin base de datos
- Manejo de **sesiones** para autenticación de usuarios
- Corrección de errores comunes en C# y Razor

---

## ✨ Funcionnalidades

| Funcionalidad | Descripción |
|---|---|
| 📋 Catálogo | Lista de videojuegos con filtro por género |
| 🔍 Detalle | Vista individual con info y reseñas del juego |
| ➕ Agregar juego | Formulario para añadir un nuevo videojuego |
| 🗑️ Eliminar juego | Eliminar un videojuego del catálogo |
| ⭐ Reseñas | Los usuarios logueados pueden escribir reseñas con calificación 1-5 |
| 👤 Registro | Crear cuenta con nickname, correo y contraseña |
| 🔐 Login / Logout | Autenticación con sesión, protege el acceso a reseñas |

---

## 🏗️ Arquitectura en capas

```
[ Presentation ]  →  [ Application ]  →  [ Domain ]
       ↓                                      ↑
[ Infrastructure ] ───────────────────────────┘
```

- **Presentation** solo habla con **Application**
- **Application** define interfaces en **Domain**
- **Infrastructure** implementa esas interfaces
- Ninguna capa de abajo conoce a las de arriba

## 🧸Uso de AI

Yo Heidi Esther Peña Betanzos use IA para resolver problemas en en la implemntacion de Usuario y ayudarme a pasar cosas del español al ingles.  Use Gemini  y el pront de inplementacion fue este "necesito ayuda no tengo errores en el programa pero no aparece que exita login"
