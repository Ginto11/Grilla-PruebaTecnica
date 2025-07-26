![Estado](https://img.shields.io/badge/Estado-Terminado-brightgreen)

![Blazor](https://img.shields.io/badge/Blazor-512BD4?logo=blazor&logoColor=white&style=flat) ![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white) ![REST API](https://img.shields.io/badge/API-REST-blue?logo=web&logoColor=white) ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-5C2D91?logo=visual-studio&logoColor=white) ![Git](https://img.shields.io/badge/Git-F05032?logo=git&logoColor=white)

# 🧪 Prueba Técnica - Blazor Web App

Aplicación desarrollada como parte de una prueba técnica solicitada por **Ziur Software**, con el objetivo de demostrar competencias en desarrollo con **Blazor WebAssembly** y consumo de API REST.




## 🚀 Descripción del proyecto

Esta aplicación en **Blazor WebAssembly** consume la siguiente API REST:

```
    https://mainserver.ziursoftware.com/Ziur.API/basedatos_01/ZiurServiceRest.svc/api/DocumentosFillsCombos
```
Utiliza autenticación mediante **Bearer Token**:
```
    ae8bad44-7348-11ee-b962-0242ac120002
```

El objetivo principal es **mostrar en una grilla** los datos devueltos por la API en formato JSON, los cuales representan documentos con su código, descripción y estado de activación.

Ejemplo de respuesta esperada:

```json
[
  { "Codigo": 29, "Descripcion": "Ajuste al Inventario", "VActiva": false },
  { "Codigo": 51, "Descripcion": "Avance Produccion", "VActiva": false },
  { "Codigo": 17, "Descripcion": "Balance Inicial", "VActiva": false }
]
```

## 🧩 Funcionalidades desarrolladas
✅ Consumo de API con HttpClient y Bearer Token
✅ Visualización en grilla de los datos obtenidos
✅ Componente de navegación lateral con enlaces
✅ Iconografía con Bootstrap Icons
✅ Interfaz limpia y responsiva
✅ Footer con derechos reservados


## 📁 Estructura del menú lateral
- 🏠 Bienvenida

- 📘 Prueba Teoría

- 🧪 Prueba Práctica

- 🌐 Perfil de GitHub

- 💼 Ver Portafolio

- 📂 Ver Repositorio
  
Íconos implementados con Bootstrap Icons (locales).

## ⚙️ Tecnologías utilizadas
- Blazor WebAssembly (.NET 8)

- C#

- Bootstrap 5

- Bootstrap Icons (descargadas y alojadas localmente)

- CSS personalizado

## 🧪 Cómo ejecutar el proyecto
1. Clonar el repositorio:
```bash
    git clone https://github.com/Ginto11/Grilla-PruebaTecnica.git
```
2. Abrir con Visual Studio 2022+
3. Ejecutar el proyecto (`Ctrl + F5`)
Asegúrate de que tengas instalado el SDK de .NET 8 o superior.

## 👨‍💻 Autor
- Desarrollado por Nelson Muñoz
- 📧 info@ziursoftware.com
- 🕒 Enviado el: Julio 26 de 2025



